namespace GUIOOPLabelTextBoxButtonNegyzet
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
            this.labelOldal = new System.Windows.Forms.Label();
            this.textBoxOldal = new System.Windows.Forms.TextBox();
            this.buttonSzamol = new System.Windows.Forms.Button();
            this.labelKerulet = new System.Windows.Forms.Label();
            this.labelTerulet = new System.Windows.Forms.Label();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOldal
            // 
            this.labelOldal.AutoSize = true;
            this.labelOldal.Location = new System.Drawing.Point(33, 28);
            this.labelOldal.Name = "labelOldal";
            this.labelOldal.Size = new System.Drawing.Size(88, 13);
            this.labelOldal.TabIndex = 0;
            this.labelOldal.Text = "A négyztet oldala";
            // 
            // textBoxOldal
            // 
            this.textBoxOldal.Location = new System.Drawing.Point(36, 52);
            this.textBoxOldal.Name = "textBoxOldal";
            this.textBoxOldal.Size = new System.Drawing.Size(100, 20);
            this.textBoxOldal.TabIndex = 1;
            // 
            // buttonSzamol
            // 
            this.buttonSzamol.Location = new System.Drawing.Point(36, 100);
            this.buttonSzamol.Name = "buttonSzamol";
            this.buttonSzamol.Size = new System.Drawing.Size(75, 23);
            this.buttonSzamol.TabIndex = 2;
            this.buttonSzamol.Text = "Számol";
            this.buttonSzamol.UseVisualStyleBackColor = true;
            // 
            // labelKerulet
            // 
            this.labelKerulet.AutoSize = true;
            this.labelKerulet.Location = new System.Drawing.Point(43, 163);
            this.labelKerulet.Name = "labelKerulet";
            this.labelKerulet.Size = new System.Drawing.Size(43, 13);
            this.labelKerulet.TabIndex = 3;
            this.labelKerulet.Text = "Kerület:";
            // 
            // labelTerulet
            // 
            this.labelTerulet.AutoSize = true;
            this.labelTerulet.Location = new System.Drawing.Point(43, 191);
            this.labelTerulet.Name = "labelTerulet";
            this.labelTerulet.Size = new System.Drawing.Size(43, 13);
            this.labelTerulet.TabIndex = 4;
            this.labelTerulet.Text = "Terület:";
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Location = new System.Drawing.Point(194, 236);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonKilepes.TabIndex = 5;
            this.buttonKilepes.Text = "Kilépés";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.labelTerulet);
            this.Controls.Add(this.labelKerulet);
            this.Controls.Add(this.buttonSzamol);
            this.Controls.Add(this.textBoxOldal);
            this.Controls.Add(this.labelOldal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOldal;
        private System.Windows.Forms.TextBox textBoxOldal;
        private System.Windows.Forms.Button buttonSzamol;
        private System.Windows.Forms.Label labelKerulet;
        private System.Windows.Forms.Label labelTerulet;
        private System.Windows.Forms.Button buttonKilepes;
    }
}

