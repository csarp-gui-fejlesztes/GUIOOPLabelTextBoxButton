namespace GUIOOP
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
            this.labelSugar = new System.Windows.Forms.Label();
            this.textBoxSugar = new System.Windows.Forms.TextBox();
            this.buttonSzamol = new System.Windows.Forms.Button();
            this.labelKerulet = new System.Windows.Forms.Label();
            this.textBoxKerulet = new System.Windows.Forms.TextBox();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSugar
            // 
            this.labelSugar.AutoSize = true;
            this.labelSugar.Location = new System.Drawing.Point(25, 23);
            this.labelSugar.Name = "labelSugar";
            this.labelSugar.Size = new System.Drawing.Size(119, 13);
            this.labelSugar.TabIndex = 0;
            this.labelSugar.Text = "Adja meg a kör sugarát:";
            // 
            // textBoxSugar
            // 
            this.textBoxSugar.Location = new System.Drawing.Point(151, 23);
            this.textBoxSugar.Name = "textBoxSugar";
            this.textBoxSugar.Size = new System.Drawing.Size(100, 20);
            this.textBoxSugar.TabIndex = 1;
            // 
            // buttonSzamol
            // 
            this.buttonSzamol.Location = new System.Drawing.Point(28, 69);
            this.buttonSzamol.Name = "buttonSzamol";
            this.buttonSzamol.Size = new System.Drawing.Size(223, 23);
            this.buttonSzamol.TabIndex = 2;
            this.buttonSzamol.Text = "Számol";
            this.buttonSzamol.UseVisualStyleBackColor = true;
            this.buttonSzamol.Click += new System.EventHandler(this.buttonSzamol_Click);
            // 
            // labelKerulet
            // 
            this.labelKerulet.AutoSize = true;
            this.labelKerulet.Location = new System.Drawing.Point(28, 139);
            this.labelKerulet.Name = "labelKerulet";
            this.labelKerulet.Size = new System.Drawing.Size(98, 13);
            this.labelKerulet.TabIndex = 3;
            this.labelKerulet.Text = "A kiszámolt kerület:";
            // 
            // textBoxKerulet
            // 
            this.textBoxKerulet.Location = new System.Drawing.Point(31, 156);
            this.textBoxKerulet.Name = "textBoxKerulet";
            this.textBoxKerulet.Size = new System.Drawing.Size(220, 20);
            this.textBoxKerulet.TabIndex = 4;
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Location = new System.Drawing.Point(639, 387);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonKilepes.TabIndex = 5;
            this.buttonKilepes.Text = "Kilépés";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            this.buttonKilepes.Click += new System.EventHandler(this.buttonKilepes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.textBoxKerulet);
            this.Controls.Add(this.labelKerulet);
            this.Controls.Add(this.buttonSzamol);
            this.Controls.Add(this.textBoxSugar);
            this.Controls.Add(this.labelSugar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSugar;
        private System.Windows.Forms.TextBox textBoxSugar;
        private System.Windows.Forms.Button buttonSzamol;
        private System.Windows.Forms.Label labelKerulet;
        private System.Windows.Forms.TextBox textBoxKerulet;
        private System.Windows.Forms.Button buttonKilepes;
    }
}

