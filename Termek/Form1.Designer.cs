namespace TermekProjekt
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
            this.labelTermekAr = new System.Windows.Forms.Label();
            this.textBoxAr = new System.Windows.Forms.TextBox();
            this.labelAFA = new System.Windows.Forms.Label();
            this.textBoxAFA = new System.Windows.Forms.TextBox();
            this.labelMennyiseg = new System.Windows.Forms.Label();
            this.textBoxMennyiseg = new System.Windows.Forms.TextBox();
            this.buttonSzamol = new System.Windows.Forms.Button();
            this.labelFizetendoBruttoAr = new System.Windows.Forms.Label();
            this.textBoxBruttoAr = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTermekAr
            // 
            this.labelTermekAr.AutoSize = true;
            this.labelTermekAr.Location = new System.Drawing.Point(13, 13);
            this.labelTermekAr.Name = "labelTermekAr";
            this.labelTermekAr.Size = new System.Drawing.Size(119, 13);
            this.labelTermekAr.TabIndex = 0;
            this.labelTermekAr.Text = "Adja meg a termék árát:";
            // 
            // textBoxAr
            // 
            this.textBoxAr.Location = new System.Drawing.Point(234, 6);
            this.textBoxAr.Name = "textBoxAr";
            this.textBoxAr.Size = new System.Drawing.Size(100, 20);
            this.textBoxAr.TabIndex = 1;
            // 
            // labelAFA
            // 
            this.labelAFA.AutoSize = true;
            this.labelAFA.Location = new System.Drawing.Point(13, 62);
            this.labelAFA.Name = "labelAFA";
            this.labelAFA.Size = new System.Drawing.Size(97, 13);
            this.labelAFA.TabIndex = 2;
            this.labelAFA.Text = "Adja meg az AFA-t:";
            // 
            // textBoxAFA
            // 
            this.textBoxAFA.Location = new System.Drawing.Point(234, 55);
            this.textBoxAFA.Name = "textBoxAFA";
            this.textBoxAFA.Size = new System.Drawing.Size(100, 20);
            this.textBoxAFA.TabIndex = 3;
            // 
            // labelMennyiseg
            // 
            this.labelMennyiseg.AutoSize = true;
            this.labelMennyiseg.Location = new System.Drawing.Point(13, 105);
            this.labelMennyiseg.Name = "labelMennyiseg";
            this.labelMennyiseg.Size = new System.Drawing.Size(165, 13);
            this.labelMennyiseg.TabIndex = 4;
            this.labelMennyiseg.Text = "Adja meg a vásárolt mennyiséget:";
            // 
            // textBoxMennyiseg
            // 
            this.textBoxMennyiseg.Location = new System.Drawing.Point(234, 98);
            this.textBoxMennyiseg.Name = "textBoxMennyiseg";
            this.textBoxMennyiseg.Size = new System.Drawing.Size(100, 20);
            this.textBoxMennyiseg.TabIndex = 5;
            // 
            // buttonSzamol
            // 
            this.buttonSzamol.Location = new System.Drawing.Point(234, 153);
            this.buttonSzamol.Name = "buttonSzamol";
            this.buttonSzamol.Size = new System.Drawing.Size(100, 23);
            this.buttonSzamol.TabIndex = 6;
            this.buttonSzamol.Text = "Számol bruttó árat";
            this.buttonSzamol.UseVisualStyleBackColor = true;
            this.buttonSzamol.Click += new System.EventHandler(this.buttonSzamol_Click);
            // 
            // labelFizetendoBruttoAr
            // 
            this.labelFizetendoBruttoAr.AutoSize = true;
            this.labelFizetendoBruttoAr.Location = new System.Drawing.Point(16, 197);
            this.labelFizetendoBruttoAr.Name = "labelFizetendoBruttoAr";
            this.labelFizetendoBruttoAr.Size = new System.Drawing.Size(98, 13);
            this.labelFizetendoBruttoAr.TabIndex = 7;
            this.labelFizetendoBruttoAr.Text = "Fizetendő bruttó ár:";
            // 
            // textBoxBruttoAr
            // 
            this.textBoxBruttoAr.Location = new System.Drawing.Point(19, 238);
            this.textBoxBruttoAr.Name = "textBoxBruttoAr";
            this.textBoxBruttoAr.ReadOnly = true;
            this.textBoxBruttoAr.Size = new System.Drawing.Size(315, 20);
            this.textBoxBruttoAr.TabIndex = 8;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(234, 302);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Kilépés";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 352);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxBruttoAr);
            this.Controls.Add(this.labelFizetendoBruttoAr);
            this.Controls.Add(this.buttonSzamol);
            this.Controls.Add(this.textBoxMennyiseg);
            this.Controls.Add(this.labelMennyiseg);
            this.Controls.Add(this.textBoxAFA);
            this.Controls.Add(this.labelAFA);
            this.Controls.Add(this.textBoxAr);
            this.Controls.Add(this.labelTermekAr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTermekAr;
        private System.Windows.Forms.TextBox textBoxAr;
        private System.Windows.Forms.Label labelAFA;
        private System.Windows.Forms.TextBox textBoxAFA;
        private System.Windows.Forms.Label labelMennyiseg;
        private System.Windows.Forms.TextBox textBoxMennyiseg;
        private System.Windows.Forms.Button buttonSzamol;
        private System.Windows.Forms.Label labelFizetendoBruttoAr;
        private System.Windows.Forms.TextBox textBoxBruttoAr;
        private System.Windows.Forms.Button buttonExit;
    }
}

