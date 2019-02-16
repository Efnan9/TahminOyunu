namespace TahminOyunu
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Tahmın_et = new System.Windows.Forms.Button();
            this.TahmınEttır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tahmın_et
            // 
            this.Tahmın_et.Location = new System.Drawing.Point(12, 70);
            this.Tahmın_et.Name = "Tahmın_et";
            this.Tahmın_et.Size = new System.Drawing.Size(170, 47);
            this.Tahmın_et.TabIndex = 0;
            this.Tahmın_et.Text = "Tahmin Et";
            this.Tahmın_et.UseVisualStyleBackColor = true;
            this.Tahmın_et.Click += new System.EventHandler(this.Tahmınet_Click);
            // 
            // TahmınEttır
            // 
            this.TahmınEttır.Location = new System.Drawing.Point(259, 70);
            this.TahmınEttır.Name = "TahmınEttır";
            this.TahmınEttır.Size = new System.Drawing.Size(194, 47);
            this.TahmınEttır.TabIndex = 1;
            this.TahmınEttır.Text = "Tahmin Ettir";
            this.TahmınEttır.UseVisualStyleBackColor = true;
            this.TahmınEttır.Click += new System.EventHandler(this.TahmınEttır_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 253);
            this.Controls.Add(this.TahmınEttır);
            this.Controls.Add(this.Tahmın_et);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Tahmın_et;
        private System.Windows.Forms.Button TahmınEttır;
    }
}

