namespace Decoder
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
            this.btnNormalni = new System.Windows.Forms.Button();
            this.tbNormalniText = new System.Windows.Forms.TextBox();
            this.tbMorseovka = new System.Windows.Forms.TextBox();
            this.btnMorseovka = new System.Windows.Forms.Button();
            this.btnBeep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNormalni
            // 
            this.btnNormalni.Location = new System.Drawing.Point(107, 96);
            this.btnNormalni.Name = "btnNormalni";
            this.btnNormalni.Size = new System.Drawing.Size(75, 23);
            this.btnNormalni.TabIndex = 0;
            this.btnNormalni.Text = "Odeslat";
            this.btnNormalni.UseVisualStyleBackColor = true;
            this.btnNormalni.Click += new System.EventHandler(this.btnNormalni_Click);
            // 
            // tbNormalniText
            // 
            this.tbNormalniText.Location = new System.Drawing.Point(13, 13);
            this.tbNormalniText.Multiline = true;
            this.tbNormalniText.Name = "tbNormalniText";
            this.tbNormalniText.Size = new System.Drawing.Size(259, 77);
            this.tbNormalniText.TabIndex = 1;
            // 
            // tbMorseovka
            // 
            this.tbMorseovka.Location = new System.Drawing.Point(13, 125);
            this.tbMorseovka.Multiline = true;
            this.tbMorseovka.Name = "tbMorseovka";
            this.tbMorseovka.Size = new System.Drawing.Size(259, 86);
            this.tbMorseovka.TabIndex = 2;
            // 
            // btnMorseovka
            // 
            this.btnMorseovka.Location = new System.Drawing.Point(107, 226);
            this.btnMorseovka.Name = "btnMorseovka";
            this.btnMorseovka.Size = new System.Drawing.Size(75, 23);
            this.btnMorseovka.TabIndex = 3;
            this.btnMorseovka.Text = "Odeslat";
            this.btnMorseovka.UseVisualStyleBackColor = true;
            this.btnMorseovka.Click += new System.EventHandler(this.btnMorseovka_Click);
            // 
            // btnBeep
            // 
            this.btnBeep.Location = new System.Drawing.Point(227, 226);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(45, 22);
            this.btnBeep.TabIndex = 4;
            this.btnBeep.Text = "Beep";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnBeep);
            this.Controls.Add(this.btnMorseovka);
            this.Controls.Add(this.tbMorseovka);
            this.Controls.Add(this.tbNormalniText);
            this.Controls.Add(this.btnNormalni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNormalni;
        private System.Windows.Forms.TextBox tbNormalniText;
        private System.Windows.Forms.TextBox tbMorseovka;
        private System.Windows.Forms.Button btnMorseovka;
        private System.Windows.Forms.Button btnBeep;
    }
}

