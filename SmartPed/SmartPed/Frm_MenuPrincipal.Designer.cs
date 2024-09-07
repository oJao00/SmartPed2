namespace SmartPed
{
    partial class Frm_Menu
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
            this.Btn_ANB = new System.Windows.Forms.Button();
            this.Btn_GAM = new System.Windows.Forms.Button();
            this.Btn_Profarma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_ANB
            // 
            this.Btn_ANB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ANB.Location = new System.Drawing.Point(182, 196);
            this.Btn_ANB.Name = "Btn_ANB";
            this.Btn_ANB.Size = new System.Drawing.Size(123, 74);
            this.Btn_ANB.TabIndex = 0;
            this.Btn_ANB.Text = "ANB";
            this.Btn_ANB.UseVisualStyleBackColor = true;
            this.Btn_ANB.Click += new System.EventHandler(this.Btn_ANB_Click);
            // 
            // Btn_GAM
            // 
            this.Btn_GAM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GAM.Location = new System.Drawing.Point(362, 197);
            this.Btn_GAM.Name = "Btn_GAM";
            this.Btn_GAM.Size = new System.Drawing.Size(123, 74);
            this.Btn_GAM.TabIndex = 1;
            this.Btn_GAM.Text = "GAM";
            this.Btn_GAM.UseVisualStyleBackColor = true;
            this.Btn_GAM.Click += new System.EventHandler(this.Btn_GAM_Click);
            // 
            // Btn_Profarma
            // 
            this.Btn_Profarma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Profarma.Location = new System.Drawing.Point(537, 197);
            this.Btn_Profarma.Name = "Btn_Profarma";
            this.Btn_Profarma.Size = new System.Drawing.Size(123, 74);
            this.Btn_Profarma.TabIndex = 2;
            this.Btn_Profarma.Text = "PROFARMA";
            this.Btn_Profarma.UseVisualStyleBackColor = true;
            this.Btn_Profarma.Click += new System.EventHandler(this.Btn_Profarma_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 488);
            this.Controls.Add(this.Btn_Profarma);
            this.Controls.Add(this.Btn_GAM);
            this.Controls.Add(this.Btn_ANB);
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ANB;
        private System.Windows.Forms.Button Btn_GAM;
        private System.Windows.Forms.Button Btn_Profarma;
    }
}