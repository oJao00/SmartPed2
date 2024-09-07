namespace SmartPed
{
    partial class Frm_Profarma
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
            this.Box_Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_Senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_GerarFTP = new System.Windows.Forms.Button();
            this.Lbl_Saida = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 110);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gerar código FTP Profarma\r\n\r\nNúmero da profarma: 30040506\r\nDigitar 1 e depois 4\r\n" +
    "Gostaria de solicitar os dados ftp de um cliente\r\n";
            // 
            // Box_Codigo
            // 
            this.Box_Codigo.Location = new System.Drawing.Point(336, 189);
            this.Box_Codigo.Name = "Box_Codigo";
            this.Box_Codigo.Size = new System.Drawing.Size(263, 20);
            this.Box_Codigo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Código do cliente (com c no começo)";
            // 
            // Box_Senha
            // 
            this.Box_Senha.Location = new System.Drawing.Point(336, 232);
            this.Box_Senha.Name = "Box_Senha";
            this.Box_Senha.Size = new System.Drawing.Size(263, 20);
            this.Box_Senha.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Senha";
            // 
            // Btn_GerarFTP
            // 
            this.Btn_GerarFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GerarFTP.Location = new System.Drawing.Point(648, 204);
            this.Btn_GerarFTP.Name = "Btn_GerarFTP";
            this.Btn_GerarFTP.Size = new System.Drawing.Size(106, 27);
            this.Btn_GerarFTP.TabIndex = 20;
            this.Btn_GerarFTP.Text = "Gerar FTP";
            this.Btn_GerarFTP.UseVisualStyleBackColor = true;
            this.Btn_GerarFTP.Click += new System.EventHandler(this.Btn_GerarFTP_Click);
            // 
            // Lbl_Saida
            // 
            this.Lbl_Saida.AutoSize = true;
            this.Lbl_Saida.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Saida.Location = new System.Drawing.Point(332, 304);
            this.Lbl_Saida.Name = "Lbl_Saida";
            this.Lbl_Saida.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Saida.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "Copiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.Location = new System.Drawing.Point(695, 411);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(78, 27);
            this.Btn_Limpar.TabIndex = 23;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Frm_Profarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_Saida);
            this.Controls.Add(this.Btn_GerarFTP);
            this.Controls.Add(this.Box_Senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Box_Codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Profarma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Profarma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Box_Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Box_Senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_GerarFTP;
        private System.Windows.Forms.Label Lbl_Saida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Limpar;
    }
}