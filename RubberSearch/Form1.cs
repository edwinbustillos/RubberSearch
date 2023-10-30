using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers.Classic;
using Lucene.Net.Search;
using Lucene.Net.Store;
using MaterialWinforms;
using MaterialWinforms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Directory = System.IO.Directory;

namespace RubberSearch
{
    public partial class Form1 : MaterialForm
    {
        private static string exePath = AppDomain.CurrentDomain.BaseDirectory;
        private string indexDir = Path.Combine(exePath, "Index");
        private string dataDir = Path.Combine(exePath, "Data");

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue700, Primary.Blue700, Accent.LightBlue200, TextShade.WHITE);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(indexDir))
            {
                System.IO.Directory.CreateDirectory(indexDir);
            }
           
      
            if (!System.IO.Directory.Exists(dataDir))
            {
                System.IO.Directory.CreateDirectory(dataDir);
            }

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            IndexFiles();
            MessageBox.Show("Indexação concluída com sucesso!");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void IndexFiles()
        {
            if (System.IO.Directory.Exists(indexDir))
            {
                System.IO.Directory.Delete(indexDir, true);
            }
            var dirInfo = new DirectoryInfo(dataDir);
            var files = dirInfo.GetFiles("*.txt", SearchOption.AllDirectories);

            using (var dir = FSDirectory.Open(new DirectoryInfo(indexDir)))
            using (var analyzer = new StandardAnalyzer(Lucene.Net.Util.LuceneVersion.LUCENE_48))
            using (var writer = new IndexWriter(dir, new IndexWriterConfig(Lucene.Net.Util.LuceneVersion.LUCENE_48, analyzer)))
            {
                foreach (var file in files)
                {
                    var doc = new Document();
                    doc.Add(new TextField("path", file.FullName, Field.Store.YES));
                    doc.Add(new TextField("contents", File.ReadAllText(file.FullName), Field.Store.YES));
                    writer.AddDocument(doc);
                }

                writer.Flush(true, true);
                writer.Commit();
            }
        }

        [Obsolete]
        private List<SearchResult> SearchIndex(string query)
        {
            FSDirectory dir = FSDirectory.Open(new DirectoryInfo(indexDir));
            
            // Criar um analisador padrão
            StandardAnalyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.LuceneVersion.LUCENE_48);
            
            IndexReader reader = IndexReader.Open(dir, 1);
             
            IndexSearcher searcher = new IndexSearcher(reader);

            var results = new List<SearchResult>();

            {  
                // Criar um parser de consulta para o campo "contents"
                var parser = new QueryParser(Lucene.Net.Util.LuceneVersion.LUCENE_48, "contents", analyzer);

                //Escapar caracteres especiais na consulta
                var escaped_query = QueryParserBase.Escape(query);

                // Criar uma consulta fuzzy com o termo "featured" e a similaridade mínima de 0.7
                //var luceneQuery = parser.GetFuzzyQuery("contents", escaped_query, 0.7f);
               
               Query luceneQuery = parser.Parse(QueryParser.Escape(escaped_query));

                var hits = searcher.Search(luceneQuery, 1000);

                for (int i = 0; i < hits.ScoreDocs.Length; ++i)
                {
                    ScoreDoc scoreDoc = hits.ScoreDocs[i];

                    int docId = scoreDoc.Doc;
                    //float score = scoreDoc.Score;

                    Document doc = searcher.Doc(docId);
                    var path = doc.Get("path");
                    var content = File.ReadAllText(path);
                    results.Add(new SearchResult { Path = path, Content = content });
                }
            }      
            return results;
        }

        public class SearchResult
        {
            public string Path { get; set; }
            public string Content { get; set; }
        }

        [Obsolete]
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string query = materialTextBox1.Text;

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Por favor, informe um valor de busca.");
                return;
            }

            var results = SearchIndex(query);

            if (results.Any())
            {
                listView1.Items.Clear();

                foreach (var result in results)
                {
                    var item = new ListViewItem(result.Path);
                    item.Tag = result.Content;
                    item.Text = Path.GetFileNameWithoutExtension(result.Path);
                    Console.WriteLine(result);
                    listView1.Items.Add(item);
                }

                MessageBox.Show($"Foram encontrados {results.Count} resultados para a busca.");

            }
            else
            {
                MessageBox.Show("Nenhum resultado encontrado para a busca informada.");
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var content = listView1.SelectedItems[0].Tag.ToString();
                materialTextBox2.Clear();
                materialTextBox2.Text = content;
            }
        }

        private void materialProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
