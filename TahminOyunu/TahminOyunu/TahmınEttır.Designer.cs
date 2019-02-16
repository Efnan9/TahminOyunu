namespace TahminOyunu
{
    partial class TahmınEttır
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
            this.Basla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRakam = new System.Windows.Forms.Label();
            this.Tekrar = new System.Windows.Forms.Button();
            this.txtAynı = new System.Windows.Forms.TextBox();
            this.lblAynı = new System.Windows.Forms.Label();
            this.btnDogru = new System.Windows.Forms.Button();
            this.txtFarklı = new System.Windows.Forms.TextBox();
            this.lblFarklı = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bir Sayı Tut !! (Rakamları farklı ve 4 Basamaklı )";
            // 
            // Basla
            // 
            this.Basla.Location = new System.Drawing.Point(33, 60);
            this.Basla.Name = "Basla";
            this.Basla.Size = new System.Drawing.Size(75, 23);
            this.Basla.TabIndex = 6;
            this.Basla.Text = "Başla";
            this.Basla.UseVisualStyleBackColor = true;
            this.Basla.Click += new System.EventHandler(this.Basla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tahmin ettiğim rakam :";
            // 
            // lblRakam
            // 
            this.lblRakam.AutoSize = true;
            this.lblRakam.Location = new System.Drawing.Point(187, 116);
            this.lblRakam.Name = "lblRakam";
            this.lblRakam.Size = new System.Drawing.Size(46, 17);
            this.lblRakam.TabIndex = 8;
            this.lblRakam.Text = "label3";
            this.lblRakam.Visible = false;
            // 
            // Tekrar
            // 
            this.Tekrar.Location = new System.Drawing.Point(382, 256);
            this.Tekrar.Name = "Tekrar";
            this.Tekrar.Size = new System.Drawing.Size(135, 37);
            this.Tekrar.TabIndex = 14;
            this.Tekrar.Text = "Tekrar Dene";
            this.Tekrar.UseVisualStyleBackColor = true;
            this.Tekrar.Visible = false;
            this.Tekrar.Click += new System.EventHandler(this.Tekrar_Click);
            // 
            // txtAynı
            // 
            this.txtAynı.Location = new System.Drawing.Point(305, 162);
            this.txtAynı.Name = "txtAynı";
            this.txtAynı.Size = new System.Drawing.Size(100, 22);
            this.txtAynı.TabIndex = 12;
            this.txtAynı.Visible = false;
            // 
            // lblAynı
            // 
            this.lblAynı.AutoSize = true;
            this.lblAynı.Location = new System.Drawing.Point(30, 167);
            this.lblAynı.Name = "lblAynı";
            this.lblAynı.Size = new System.Drawing.Size(253, 17);
            this.lblAynı.TabIndex = 10;
            this.lblAynı.Text = "Aynı Basamağı Doğru ise +1 Değilse 0 ";
            this.lblAynı.Visible = false;
            // 
            // btnDogru
            // 
            this.btnDogru.Location = new System.Drawing.Point(260, 110);
            this.btnDogru.Name = "btnDogru";
            this.btnDogru.Size = new System.Drawing.Size(118, 33);
            this.btnDogru.TabIndex = 15;
            this.btnDogru.Text = "Doğru";
            this.btnDogru.UseVisualStyleBackColor = true;
            this.btnDogru.Visible = false;
            this.btnDogru.Click += new System.EventHandler(this.btnDogru_Click);
            // 
            // txtFarklı
            // 
            this.txtFarklı.Location = new System.Drawing.Point(305, 202);
            this.txtFarklı.Name = "txtFarklı";
            this.txtFarklı.Size = new System.Drawing.Size(100, 22);
            this.txtFarklı.TabIndex = 17;
            this.txtFarklı.Visible = false;
            // 
            // lblFarklı
            // 
            this.lblFarklı.AutoSize = true;
            this.lblFarklı.Location = new System.Drawing.Point(30, 202);
            this.lblFarklı.Name = "lblFarklı";
            this.lblFarklı.Size = new System.Drawing.Size(215, 17);
            this.lblFarklı.TabIndex = 16;
            this.lblFarklı.Text = "Farklı Basamakta ise -1 Değlse 0";
            this.lblFarklı.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "label4";
            // 
            // TahmınEttır
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 340);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFarklı);
            this.Controls.Add(this.lblFarklı);
            this.Controls.Add(this.btnDogru);
            this.Controls.Add(this.Tekrar);
            this.Controls.Add(this.txtAynı);
            this.Controls.Add(this.lblAynı);
            this.Controls.Add(this.lblRakam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Basla);
            this.Controls.Add(this.label1);
            this.Name = "TahmınEttır";
            this.Text = "TahmınEttır";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Basla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRakam;
        private System.Windows.Forms.Button Tekrar;
        private System.Windows.Forms.TextBox txtAynı;
        private System.Windows.Forms.Label lblAynı;
        private System.Windows.Forms.Button btnDogru;
        private System.Windows.Forms.TextBox txtFarklı;
        private System.Windows.Forms.Label lblFarklı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}