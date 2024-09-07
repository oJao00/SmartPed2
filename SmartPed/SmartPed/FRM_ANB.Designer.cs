namespace SmartPed
{
    partial class FRM_ANB
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
            this.Box_Razao = new System.Windows.Forms.TextBox();
            this.Box_CNPJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Box_Codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSaidaEmail = new System.Windows.Forms.Label();
            this.Btn_GerarEmail = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enviar Email ANB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razão Social:";
            // 
            // Box_Razao
            // 
            this.Box_Razao.Location = new System.Drawing.Point(346, 120);
            this.Box_Razao.Name = "Box_Razao";
            this.Box_Razao.Size = new System.Drawing.Size(263, 20);
            this.Box_Razao.TabIndex = 2;
            // 
            // Box_CNPJ
            // 
            this.Box_CNPJ.Location = new System.Drawing.Point(346, 173);
            this.Box_CNPJ.Name = "Box_CNPJ";
            this.Box_CNPJ.Size = new System.Drawing.Size(263, 20);
            this.Box_CNPJ.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "CNPJ:";
            // 
            // Box_Codigo
            // 
            this.Box_Codigo.Location = new System.Drawing.Point(346, 224);
            this.Box_Codigo.Name = "Box_Codigo";
            this.Box_Codigo.Size = new System.Drawing.Size(263, 20);
            this.Box_Codigo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código do Cliente:";
            // 
            // LblSaidaEmail
            // 
            this.LblSaidaEmail.AutoSize = true;
            this.LblSaidaEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaidaEmail.Location = new System.Drawing.Point(251, 287);
            this.LblSaidaEmail.Name = "LblSaidaEmail";
            this.LblSaidaEmail.Size = new System.Drawing.Size(0, 18);
            this.LblSaidaEmail.TabIndex = 7;
            // 
            // Btn_GerarEmail
            // 
            this.Btn_GerarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GerarEmail.Location = new System.Drawing.Point(707, 155);
            this.Btn_GerarEmail.Name = "Btn_GerarEmail";
            this.Btn_GerarEmail.Size = new System.Drawing.Size(139, 52);
            this.Btn_GerarEmail.TabIndex = 8;
            this.Btn_GerarEmail.Text = "Gerar Email";
            this.Btn_GerarEmail.UseVisualStyleBackColor = true;
            this.Btn_GerarEmail.Click += new System.EventHandler(this.Btn_GerarEmail_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.Location = new System.Drawing.Point(740, 398);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(78, 27);
            this.Btn_Limpar.TabIndex = 9;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(158, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Copiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_ANB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_GerarEmail);
            this.Controls.Add(this.LblSaidaEmail);
            this.Controls.Add(this.Box_Codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Box_CNPJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Box_Razao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_ANB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email ANB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Box_Razao;
        private System.Windows.Forms.TextBox Box_CNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Box_Codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblSaidaEmail;
        private System.Windows.Forms.Button Btn_GerarEmail;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button button1;
    }
}