namespace SzabalyosTetraeder
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
            this.labelElhossz = new System.Windows.Forms.Label();
            this.textBoxElhossz = new System.Windows.Forms.TextBox();
            this.buttonSzamitas = new System.Windows.Forms.Button();
            this.labelFelszin = new System.Windows.Forms.Label();
            this.labelTerfogat = new System.Windows.Forms.Label();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelElhossz
            // 
            this.labelElhossz.AutoSize = true;
            this.labelElhossz.Location = new System.Drawing.Point(13, 13);
            this.labelElhossz.Name = "labelElhossz";
            this.labelElhossz.Size = new System.Drawing.Size(150, 13);
            this.labelElhossz.TabIndex = 0;
            this.labelElhossz.Text = "Szabályos tetraéder  élhossza:";
            // 
            // textBoxElhossz
            // 
            this.textBoxElhossz.Location = new System.Drawing.Point(169, 12);
            this.textBoxElhossz.Name = "textBoxElhossz";
            this.textBoxElhossz.Size = new System.Drawing.Size(82, 20);
            this.textBoxElhossz.TabIndex = 1;
            // 
            // buttonSzamitas
            // 
            this.buttonSzamitas.Location = new System.Drawing.Point(16, 51);
            this.buttonSzamitas.Name = "buttonSzamitas";
            this.buttonSzamitas.Size = new System.Drawing.Size(235, 23);
            this.buttonSzamitas.TabIndex = 2;
            this.buttonSzamitas.Text = "Számítások";
            this.buttonSzamitas.UseVisualStyleBackColor = true;
            // 
            // labelFelszin
            // 
            this.labelFelszin.AutoSize = true;
            this.labelFelszin.Location = new System.Drawing.Point(16, 96);
            this.labelFelszin.Name = "labelFelszin";
            this.labelFelszin.Size = new System.Drawing.Size(44, 13);
            this.labelFelszin.TabIndex = 3;
            this.labelFelszin.Text = "Felszín:";
            // 
            // labelTerfogat
            // 
            this.labelTerfogat.AutoSize = true;
            this.labelTerfogat.Location = new System.Drawing.Point(16, 144);
            this.labelTerfogat.Name = "labelTerfogat";
            this.labelTerfogat.Size = new System.Drawing.Size(50, 13);
            this.labelTerfogat.TabIndex = 4;
            this.labelTerfogat.Text = "Térfogat:";
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Location = new System.Drawing.Point(189, 209);
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
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.labelTerfogat);
            this.Controls.Add(this.labelFelszin);
            this.Controls.Add(this.buttonSzamitas);
            this.Controls.Add(this.textBoxElhossz);
            this.Controls.Add(this.labelElhossz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelElhossz;
        private System.Windows.Forms.TextBox textBoxElhossz;
        private System.Windows.Forms.Button buttonSzamitas;
        private System.Windows.Forms.Label labelFelszin;
        private System.Windows.Forms.Label labelTerfogat;
        private System.Windows.Forms.Button buttonKilepes;
    }
}

