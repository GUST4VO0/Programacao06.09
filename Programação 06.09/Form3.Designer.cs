namespace Programação_06._09
{
    partial class Form3
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
            this.textnome = new System.Windows.Forms.TextBox();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(586, 278);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(265, 20);
            this.textnome.TabIndex = 12;
            // 
            // textsenha
            // 
            this.textsenha.Location = new System.Drawing.Point(586, 371);
            this.textsenha.Name = "textsenha";
            this.textsenha.Size = new System.Drawing.Size(265, 20);
            this.textsenha.TabIndex = 13;
            // 
            // txtnome
            // 
            this.txtnome.AutoSize = true;
            this.txtnome.BackColor = System.Drawing.Color.Transparent;
            this.txtnome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(583, 257);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(46, 18);
            this.txtnome.TabIndex = 14;
            this.txtnome.Text = "Email";
            this.txtnome.Click += new System.EventHandler(this.txtnome_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.AutoSize = true;
            this.txtsenha.BackColor = System.Drawing.Color.Transparent;
            this.txtsenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.ForeColor = System.Drawing.Color.White;
            this.txtsenha.Location = new System.Drawing.Point(583, 350);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(53, 18);
            this.txtsenha.TabIndex = 15;
            this.txtsenha.Text = "Senha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(583, 394);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cadastrar-se";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Programação_06._09.Properties.Resources.Seja_um_fiel__1_;
            this.ClientSize = new System.Drawing.Size(1364, 731);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.textsenha);
            this.Controls.Add(this.textnome);
            this.Name = "Form3";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.TextBox textsenha;
        private System.Windows.Forms.Label txtnome;
        private System.Windows.Forms.Label txtsenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}