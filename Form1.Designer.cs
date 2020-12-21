namespace Karar_Yapıları
{
    partial class Form1
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnAdminKontrol = new System.Windows.Forms.Button();
            this.btnNotKontrol = new System.Windows.Forms.Button();
            this.btnTekCiftKontrol = new System.Windows.Forms.Button();
            this.btnDegerKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(12, 12);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(237, 20);
            this.txtDeger.TabIndex = 0;
            // 
            // btnAdminKontrol
            // 
            this.btnAdminKontrol.BackColor = System.Drawing.Color.Red;
            this.btnAdminKontrol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdminKontrol.Location = new System.Drawing.Point(12, 38);
            this.btnAdminKontrol.Name = "btnAdminKontrol";
            this.btnAdminKontrol.Size = new System.Drawing.Size(237, 50);
            this.btnAdminKontrol.TabIndex = 1;
            this.btnAdminKontrol.Text = "ADMİN KONTROLÜ";
            this.btnAdminKontrol.UseVisualStyleBackColor = false;
            this.btnAdminKontrol.Click += new System.EventHandler(this.btnAdminKontrol_Click);
            // 
            // btnNotKontrol
            // 
            this.btnNotKontrol.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNotKontrol.Location = new System.Drawing.Point(12, 94);
            this.btnNotKontrol.Name = "btnNotKontrol";
            this.btnNotKontrol.Size = new System.Drawing.Size(237, 50);
            this.btnNotKontrol.TabIndex = 2;
            this.btnNotKontrol.Text = "NOT KONTROLÜ";
            this.btnNotKontrol.UseVisualStyleBackColor = false;
            this.btnNotKontrol.Click += new System.EventHandler(this.btnNotKontrol_Click);
            // 
            // btnTekCiftKontrol
            // 
            this.btnTekCiftKontrol.BackColor = System.Drawing.Color.Teal;
            this.btnTekCiftKontrol.ForeColor = System.Drawing.Color.Yellow;
            this.btnTekCiftKontrol.Location = new System.Drawing.Point(12, 150);
            this.btnTekCiftKontrol.Name = "btnTekCiftKontrol";
            this.btnTekCiftKontrol.Size = new System.Drawing.Size(237, 50);
            this.btnTekCiftKontrol.TabIndex = 3;
            this.btnTekCiftKontrol.Text = "TEK - ÇİFT KONTROLÜ";
            this.btnTekCiftKontrol.UseVisualStyleBackColor = false;
            this.btnTekCiftKontrol.Click += new System.EventHandler(this.btnTekCiftKontrol_Click);
            // 
            // btnDegerKontrol
            // 
            this.btnDegerKontrol.Location = new System.Drawing.Point(12, 206);
            this.btnDegerKontrol.Name = "btnDegerKontrol";
            this.btnDegerKontrol.Size = new System.Drawing.Size(237, 50);
            this.btnDegerKontrol.TabIndex = 4;
            this.btnDegerKontrol.Text = "DEĞER KONTROLÜ";
            this.btnDegerKontrol.UseVisualStyleBackColor = true;
            this.btnDegerKontrol.Click += new System.EventHandler(this.btnDegerKontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 269);
            this.Controls.Add(this.btnDegerKontrol);
            this.Controls.Add(this.btnNotKontrol);
            this.Controls.Add(this.btnTekCiftKontrol);
            this.Controls.Add(this.btnAdminKontrol);
            this.Controls.Add(this.txtDeger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnAdminKontrol;
        private System.Windows.Forms.Button btnNotKontrol;
        private System.Windows.Forms.Button btnTekCiftKontrol;
        private System.Windows.Forms.Button btnDegerKontrol;
    }
}

