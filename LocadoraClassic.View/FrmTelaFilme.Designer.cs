namespace LocadoraClassic.View
{
    partial class FrmTelaFilme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.multiSinopse = new System.Windows.Forms.TextBox();
            this.checkLocado = new System.Windows.Forms.CheckBox();
            this.mskDuracao = new System.Windows.Forms.MaskedTextBox();
            this.imgBanner = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gênero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Filme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duração";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sinopse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Banner";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(61, 47);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(356, 21);
            this.cmbCategoria.TabIndex = 7;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            this.cmbCategoria.SelectedValueChanged += new System.EventHandler(this.cmbCategoria_SelectedValueChanged);
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(59, 98);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(358, 21);
            this.cmbGenero.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 150);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(356, 20);
            this.txtNome.TabIndex = 9;
            // 
            // multiSinopse
            // 
            this.multiSinopse.Location = new System.Drawing.Point(59, 258);
            this.multiSinopse.Multiline = true;
            this.multiSinopse.Name = "multiSinopse";
            this.multiSinopse.Size = new System.Drawing.Size(358, 90);
            this.multiSinopse.TabIndex = 11;
            // 
            // checkLocado
            // 
            this.checkLocado.AutoSize = true;
            this.checkLocado.Location = new System.Drawing.Point(59, 364);
            this.checkLocado.Name = "checkLocado";
            this.checkLocado.Size = new System.Drawing.Size(62, 17);
            this.checkLocado.TabIndex = 12;
            this.checkLocado.Text = "Locado";
            this.checkLocado.UseVisualStyleBackColor = true;
            // 
            // mskDuracao
            // 
            this.mskDuracao.Location = new System.Drawing.Point(61, 193);
            this.mskDuracao.Mask = "90:00";
            this.mskDuracao.Name = "mskDuracao";
            this.mskDuracao.Size = new System.Drawing.Size(356, 20);
            this.mskDuracao.TabIndex = 13;
            this.mskDuracao.ValidatingType = typeof(System.DateTime);
            // 
            // imgBanner
            // 
            this.imgBanner.Location = new System.Drawing.Point(441, 47);
            this.imgBanner.Name = "imgBanner";
            this.imgBanner.Size = new System.Drawing.Size(273, 301);
            this.imgBanner.TabIndex = 14;
            this.imgBanner.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(61, 388);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(653, 23);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTelaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.imgBanner);
            this.Controls.Add(this.mskDuracao);
            this.Controls.Add(this.checkLocado);
            this.Controls.Add(this.multiSinopse);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTelaFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTelaFilme";
            this.Load += new System.EventHandler(this.FrmTelaFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox multiSinopse;
        private System.Windows.Forms.CheckBox checkLocado;
        private System.Windows.Forms.MaskedTextBox mskDuracao;
        private System.Windows.Forms.PictureBox imgBanner;
        private System.Windows.Forms.Button btnCadastrar;
    }
}