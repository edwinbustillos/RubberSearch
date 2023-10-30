using System;

namespace RubberSearch
{
    partial class Form1
    {
        /// <sumário>
        /// Variável de designer necessária.
        /// </sumário>

        /// <sumário>
        /// Limpar os recursos que estão sendo usados.
        /// </sumário>
        /// <param name = "disposing"> true se os recursos
        private void InitializeComponent()
        {
            MaterialWinforms.Controls.MaterialRaisedButton materialRaisedButton2;
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Windows.Forms.Label label1;
            System.Drawing.Drawing2D.GraphicsPath graphicsPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialProgressBar1 = new MaterialWinforms.Controls.MaterialProgressBar();
            this.materialTextBox1 = new MaterialWinforms.Controls.MaterialTextBox();
            this.materialRaisedButton1 = new MaterialWinforms.Controls.MaterialRaisedButton();
            this.materialTextBox2 = new MaterialWinforms.Controls.MaterialTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            materialRaisedButton2 = new MaterialWinforms.Controls.MaterialRaisedButton();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            this.Load += new System.EventHandler(this.Form1_Load);
            // 
            // materialRaisedButton2
            // 
            materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialRaisedButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            materialRaisedButton2.CausesValidation = false;
            materialRaisedButton2.Depth = 0;
            materialRaisedButton2.Elevation = 5;
            materialRaisedButton2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            materialRaisedButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            materialRaisedButton2.Location = new System.Drawing.Point(168, 26);
            materialRaisedButton2.MouseState = MaterialWinforms.MouseState.HOVER;
            materialRaisedButton2.Name = "materialRaisedButton2";
            materialRaisedButton2.Primary = true;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            materialRaisedButton2.ShadowBorder = graphicsPath1;
            materialRaisedButton2.Size = new System.Drawing.Size(76, 45);
            materialRaisedButton2.TabIndex = 9;
            materialRaisedButton2.TabStop = false;
            materialRaisedButton2.Text = "Indexar";
            materialRaisedButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            materialRaisedButton2.UseMnemonic = false;
            materialRaisedButton2.UseVisualStyleBackColor = false;
            materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            label1.CausesValidation = false;
            label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Image = global::RubberSearch.Properties.Resources.logo2;
            label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(166, 71);
            label1.TabIndex = 8;
            label1.Text = "RubberSearch";
            label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.InvertedProgressBar = false;
            this.materialProgressBar1.Location = new System.Drawing.Point(3, 450);
            this.materialProgressBar1.Maximum = 100;
            this.materialProgressBar1.Minimum = 0;
            this.materialProgressBar1.MouseState = MaterialWinforms.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.materialProgressBar1.Size = new System.Drawing.Size(712, 5);
            this.materialProgressBar1.Step = 100;
            this.materialProgressBar1.Style = MaterialWinforms.Controls.MaterialProgressBar.ProgressStyle.Determinate;
            this.materialProgressBar1.TabIndex = 1;
            this.materialProgressBar1.Text = "materialProgressBar1";
            this.materialProgressBar1.Value = 100;
            this.materialProgressBar1.Click += new System.EventHandler(this.materialProgressBar1_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Hint = "Digite sua busca:";
            this.materialTextBox1.Location = new System.Drawing.Point(245, 26);
            this.materialTextBox1.MaxLength = 2147483647;
            this.materialTextBox1.MouseState = MaterialWinforms.MouseState.HOVER;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.ReadOnly = false;
            this.materialTextBox1.SelectedText = "";
            this.materialTextBox1.SelectionLength = 0;
            this.materialTextBox1.SelectionStart = 0;
            this.materialTextBox1.Size = new System.Drawing.Size(386, 45);
            this.materialTextBox1.TabIndex = 3;
            this.materialTextBox1.TabStop = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Elevation = 5;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.Location = new System.Drawing.Point(632, 26);
            this.materialRaisedButton1.MouseState = MaterialWinforms.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.materialRaisedButton1.ShadowBorder = graphicsPath2;
            this.materialRaisedButton1.Size = new System.Drawing.Size(83, 45);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "Buscar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Hint = "";
            this.materialTextBox2.Location = new System.Drawing.Point(3, 3);
            this.materialTextBox2.MaxLength = 2147483647;
            this.materialTextBox2.MouseState = MaterialWinforms.MouseState.HOVER;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.materialTextBox2.ReadOnly = false;
            this.materialTextBox2.SelectedText = "";
            this.materialTextBox2.SelectionLength = 0;
            this.materialTextBox2.SelectionStart = 0;
            this.materialTextBox2.Size = new System.Drawing.Size(534, 367);
            this.materialTextBox2.TabIndex = 6;
            this.materialTextBox2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(3, 74);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitContainer1.Panel2.Controls.Add(this.materialTextBox2);
            this.splitContainer1.Size = new System.Drawing.Size(712, 375);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(158, 371);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(718, 463);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(materialRaisedButton2);
            this.Controls.Add(label1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.materialProgressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private MaterialWinforms.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialWinforms.Controls.MaterialTextBox materialTextBox1;
        private MaterialWinforms.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialWinforms.Controls.MaterialTextBox materialTextBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
    }
}