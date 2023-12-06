using System;

namespace Programação_06._09
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtemail = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.textnome = new System.Windows.Forms.TextBox();
            this.listinha = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textcpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.BackColor = System.Drawing.Color.Transparent;
            this.txtemail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.White;
            this.txtemail.Location = new System.Drawing.Point(425, 350);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(46, 18);
            this.txtemail.TabIndex = 2;
            this.txtemail.Text = "Email";
            this.txtemail.Click += new System.EventHandler(this.textemail_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.AutoSize = true;
            this.txtsenha.BackColor = System.Drawing.Color.Transparent;
            this.txtsenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.ForeColor = System.Drawing.Color.White;
            this.txtsenha.Location = new System.Drawing.Point(425, 419);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(53, 18);
            this.txtsenha.TabIndex = 3;
            this.txtsenha.Text = "Senha";
            this.txtsenha.Click += new System.EventHandler(this.textsenha_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.AutoSize = true;
            this.txtcpf.BackColor = System.Drawing.Color.Transparent;
            this.txtcpf.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.ForeColor = System.Drawing.Color.White;
            this.txtcpf.Location = new System.Drawing.Point(425, 494);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(38, 18);
            this.txtcpf.TabIndex = 5;
            this.txtcpf.Text = "CPF";
            this.txtcpf.Click += new System.EventHandler(this.textcpf_Click);
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(428, 378);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(123, 20);
            this.textemail.TabIndex = 1;
            // 
            // textsenha
            // 
            this.textsenha.Location = new System.Drawing.Point(428, 451);
            this.textsenha.MaxLength = 8;
            this.textsenha.Name = "textsenha";
            this.textsenha.Size = new System.Drawing.Size(125, 20);
            this.textsenha.TabIndex = 2;
            this.textsenha.TextChanged += new System.EventHandler(this.textsenha_TextChanged);
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.BackColor = System.Drawing.Color.Transparent;
            this.lbnome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.ForeColor = System.Drawing.Color.Transparent;
            this.lbnome.Location = new System.Drawing.Point(425, 286);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(49, 18);
            this.lbnome.TabIndex = 10;
            this.lbnome.Text = "Nome";
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(428, 307);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(123, 20);
            this.textnome.TabIndex = 0;
            // 
            // listinha
            // 
            this.listinha.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listinha.HideSelection = false;
            this.listinha.Location = new System.Drawing.Point(688, 394);
            this.listinha.Name = "listinha";
            this.listinha.Size = new System.Drawing.Size(379, 97);
            this.listinha.TabIndex = 13;
            this.listinha.UseCompatibleStateImageBehavior = false;
            this.listinha.View = System.Windows.Forms.View.Details;
            this.listinha.SelectedIndexChanged += new System.EventHandler(this.listinha_SelectedIndexChanged_1);
            this.listinha.DoubleClick += new System.EventHandler(this.listinha_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-mail";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Senha";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CPF";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(444, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(468, 624);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(45, 24);
            this.btneditar.TabIndex = 5;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Black;
            this.checkBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkBox1.Location = new System.Drawing.Point(426, 541);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Aceitar Termos e Condições";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textcpf
            // 
            this.textcpf.Location = new System.Drawing.Point(426, 515);
            this.textcpf.Mask = "00000000000";
            this.textcpf.Name = "textcpf";
            this.textcpf.Size = new System.Drawing.Size(127, 20);
            this.textcpf.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Programação_06._09.Properties.Resources.Seja_um_fiel__2_;
            this.ClientSize = new System.Drawing.Size(1363, 727);
            this.Controls.Add(this.textcpf);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listinha);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.textsenha);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtemail);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cad_Click(object sender, EventArgs e) => throw new NotImplementedException();

        private void textemail_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textsenha_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textcpf_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.Label txtsenha;
        private System.Windows.Forms.Label txtcpf;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textsenha;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.ListView listinha;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox textcpf;
    }
}

