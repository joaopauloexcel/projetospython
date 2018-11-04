namespace Projeto1
{
    partial class frmImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCarregaImg = new System.Windows.Forms.Panel();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.cmdGrava = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEscolhas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCarregaImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.pnlResultado.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCarregaImg
            // 
            this.pnlCarregaImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCarregaImg.BackColor = System.Drawing.Color.Transparent;
            this.pnlCarregaImg.Controls.Add(this.picFoto);
            this.pnlCarregaImg.Controls.Add(this.btnFoto);
            this.pnlCarregaImg.Controls.Add(this.btnFiltros);
            this.pnlCarregaImg.Enabled = false;
            this.pnlCarregaImg.Location = new System.Drawing.Point(16, 74);
            this.pnlCarregaImg.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlCarregaImg.Name = "pnlCarregaImg";
            this.pnlCarregaImg.Size = new System.Drawing.Size(419, 419);
            this.pnlCarregaImg.TabIndex = 0;
            this.pnlCarregaImg.Visible = false;
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.ErrorImage = null;
            this.picFoto.ImageLocation = "t";
            this.picFoto.Location = new System.Drawing.Point(12, 59);
            this.picFoto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(389, 332);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 6;
            this.picFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.Location = new System.Drawing.Point(24, 17);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(111, 29);
            this.btnFoto.TabIndex = 4;
            this.btnFoto.Text = "Carregar imagem";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.cmdFoto_Click);
            // 
            // btnFiltros
            // 
            this.btnFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltros.Location = new System.Drawing.Point(247, 17);
            this.btnFiltros.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(113, 29);
            this.btnFiltros.TabIndex = 7;
            this.btnFiltros.Text = "Filtros";
            this.btnFiltros.UseVisualStyleBackColor = true;
            this.btnFiltros.Visible = false;
            this.btnFiltros.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // cmdGrava
            // 
            this.cmdGrava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGrava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrava.Location = new System.Drawing.Point(275, 17);
            this.cmdGrava.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdGrava.Name = "cmdGrava";
            this.cmdGrava.Size = new System.Drawing.Size(113, 29);
            this.cmdGrava.TabIndex = 5;
            this.cmdGrava.Text = "Salvar Imagem";
            this.cmdGrava.UseVisualStyleBackColor = true;
            this.cmdGrava.Click += new System.EventHandler(this.cmdGrava_Click);
            // 
            // picResult
            // 
            this.picResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult.Location = new System.Drawing.Point(2, 59);
            this.picResult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(386, 332);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 10;
            this.picResult.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlResultado
            // 
            this.pnlResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResultado.BackColor = System.Drawing.Color.Transparent;
            this.pnlResultado.Controls.Add(this.cmdGrava);
            this.pnlResultado.Controls.Add(this.picResult);
            this.pnlResultado.Enabled = false;
            this.pnlResultado.Location = new System.Drawing.Point(665, 74);
            this.pnlResultado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(403, 419);
            this.pnlResultado.TabIndex = 1;
            this.pnlResultado.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "ULTRASHOW - FILTROS AVANÇADOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiltros.Controls.Add(this.label2);
            this.pnlFiltros.Controls.Add(this.button1);
            this.pnlFiltros.Controls.Add(this.label4);
            this.pnlFiltros.Controls.Add(this.cmbEscolhas);
            this.pnlFiltros.Controls.Add(this.label3);
            this.pnlFiltros.Location = new System.Drawing.Point(433, 133);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(232, 255);
            this.pnlFiltros.TabIndex = 11;
            this.pnlFiltros.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "1- Média Gausiana";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(60, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "3- Adição (Img Original + Img Subtraída)";
            // 
            // cmbEscolhas
            // 
            this.cmbEscolhas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEscolhas.FormattingEnabled = true;
            this.cmbEscolhas.Items.AddRange(new object[] {
            "Gaussiano",
            "Subtração",
            "Adição"});
            this.cmbEscolhas.Location = new System.Drawing.Point(44, 64);
            this.cmbEscolhas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbEscolhas.Name = "cmbEscolhas";
            this.cmbEscolhas.Size = new System.Drawing.Size(137, 21);
            this.cmbEscolhas.TabIndex = 22;
            this.cmbEscolhas.Text = "Selecione o filtro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "2- Subtrai (Img Original - Img Gausiana)";
            // 
            // frmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Projeto1.Properties.Resources.fundo_form;
            this.ClientSize = new System.Drawing.Size(1079, 524);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlResultado);
            this.Controls.Add(this.pnlCarregaImg);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmImage";
            this.Text = "Ultrassom";
            this.pnlCarregaImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.pnlResultado.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCarregaImg;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button cmdGrava;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEscolhas;
        private System.Windows.Forms.Label label3;
    }
}

