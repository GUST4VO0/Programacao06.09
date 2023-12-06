namespace Programação_06._09
{
    partial class Form5
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
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listinha = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textrua = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.textcasa = new System.Windows.Forms.TextBox();
            this.textbairro = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(466, 130);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(39, 20);
            this.textID.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(463, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID";
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
            this.listinha.Location = new System.Drawing.Point(357, 174);
            this.listinha.Name = "listinha";
            this.listinha.Size = new System.Drawing.Size(379, 97);
            this.listinha.TabIndex = 47;
            this.listinha.UseCompatibleStateImageBehavior = false;
            this.listinha.View = System.Windows.Forms.View.Details;
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
            // textrua
            // 
            this.textrua.Location = new System.Drawing.Point(97, 87);
            this.textrua.Name = "textrua";
            this.textrua.Size = new System.Drawing.Size(123, 20);
            this.textrua.TabIndex = 39;
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.BackColor = System.Drawing.Color.Transparent;
            this.lbnome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbnome.Location = new System.Drawing.Point(94, 66);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(36, 18);
            this.lbnome.TabIndex = 46;
            this.lbnome.Text = "Rua";
            // 
            // textcasa
            // 
            this.textcasa.Location = new System.Drawing.Point(97, 231);
            this.textcasa.MaxLength = 8;
            this.textcasa.Name = "textcasa";
            this.textcasa.Size = new System.Drawing.Size(125, 20);
            this.textcasa.TabIndex = 41;
            // 
            // textbairro
            // 
            this.textbairro.Location = new System.Drawing.Point(97, 158);
            this.textbairro.Name = "textbairro";
            this.textbairro.Size = new System.Drawing.Size(123, 20);
            this.textbairro.TabIndex = 40;
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.BackColor = System.Drawing.Color.Transparent;
            this.txtemail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtemail.Location = new System.Drawing.Point(94, 130);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(52, 18);
            this.txtemail.TabIndex = 42;
            this.txtemail.Text = "Bairro";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 28);
            this.button3.TabIndex = 50;
            this.button3.Text = "Cadastrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(94, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Casa";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listinha);
            this.Controls.Add(this.textrua);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.textcasa);
            this.Controls.Add(this.textbairro);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listinha;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textrua;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox textcasa;
        private System.Windows.Forms.TextBox textbairro;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}