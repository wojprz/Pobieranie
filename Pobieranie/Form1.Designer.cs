namespace Pobieranie
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
            this.adres = new System.Windows.Forms.TextBox();
            this.lista = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(16, 35);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(358, 22);
            this.adres.TabIndex = 0;
            this.adres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 16;
            this.lista.Items.AddRange(new object[] {
            "openload"});
            this.lista.Location = new System.Drawing.Point(388, 38);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(182, 20);
            this.lista.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "pobranie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button button1;
    }
}

