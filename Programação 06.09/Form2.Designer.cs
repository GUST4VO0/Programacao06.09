namespace Programação_06._09
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listinha = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textnome = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.textcpf = new System.Windows.Forms.TextBox();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.listinha.Location = new System.Drawing.Point(342, 176);
            this.listinha.Name = "listinha";
            this.listinha.Size = new System.Drawing.Size(379, 97);
            this.listinha.TabIndex = 34;
            this.listinha.UseCompatibleStateImageBehavior = false;
            this.listinha.View = System.Windows.Forms.View.Details;
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
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(82, 89);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(123, 20);
            this.textnome.TabIndex = 25;
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.BackColor = System.Drawing.Color.Transparent;
            this.lbnome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbnome.Location = new System.Drawing.Point(79, 68);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(49, 18);
            this.lbnome.TabIndex = 33;
            this.lbnome.Text = "Nome";
            // 
            // textcpf
            // 
            this.textcpf.Location = new System.Drawing.Point(80, 297);
            this.textcpf.Name = "textcpf";
            this.textcpf.Size = new System.Drawing.Size(125, 20);
            this.textcpf.TabIndex = 29;
            this.textcpf.TextChanged += new System.EventHandler(this.textcpf_TextChanged);
            // 
            // textsenha
            // 
            this.textsenha.Location = new System.Drawing.Point(82, 233);
            this.textsenha.MaxLength = 8;
            this.textsenha.Name = "textsenha";
            this.textsenha.Size = new System.Drawing.Size(125, 20);
            this.textsenha.TabIndex = 27;
            this.textsenha.TextChanged += new System.EventHandler(this.textsenha_TextChanged_1);
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(82, 160);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(123, 20);
            this.textemail.TabIndex = 26;
            // 
            // txtcpf
            // 
            this.txtcpf.AutoSize = true;
            this.txtcpf.BackColor = System.Drawing.Color.Transparent;
            this.txtcpf.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtcpf.Location = new System.Drawing.Point(79, 276);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(38, 18);
            this.txtcpf.TabIndex = 32;
            this.txtcpf.Text = "CPF";
            // 
            // txtsenha
            // 
            this.txtsenha.AutoSize = true;
            this.txtsenha.BackColor = System.Drawing.Color.Transparent;
            this.txtsenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtsenha.Location = new System.Drawing.Point(79, 201);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(53, 18);
            this.txtsenha.TabIndex = 30;
            this.txtsenha.Text = "Senha";
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.BackColor = System.Drawing.Color.Transparent;
            this.txtemail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtemail.Location = new System.Drawing.Point(79, 132);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(46, 18);
            this.txtemail.TabIndex = 28;
            this.txtemail.Text = "Email";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(451, 132);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(39, 20);
            this.textID.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(448, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listinha);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.textcpf);
            this.Controls.Add(this.textsenha);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Editar Cadastro";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listinha;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox textcpf;
        private System.Windows.Forms.TextBox textsenha;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label txtcpf;
        private System.Windows.Forms.Label txtsenha;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
    }
}