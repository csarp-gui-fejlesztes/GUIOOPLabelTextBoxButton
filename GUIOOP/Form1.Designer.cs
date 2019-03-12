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
            this.components = new System.ComponentModel.Container();
            this.labelSugar = new System.Windows.Forms.Label();
            this.textBoxSugar = new System.Windows.Forms.TextBox();
            this.buttonSzamol = new System.Windows.Forms.Button();
            this.labelKerulet = new System.Windows.Forms.Label();
            this.textBoxKerulet = new System.Windows.Forms.TextBox();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.textBoxTerulet = new System.Windows.Forms.TextBox();
            this.errorProviderSugar = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelTerulet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSugar)).BeginInit();
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
            this.textBoxSugar.TextChanged += new System.EventHandler(this.textBoxSugar_TextChanged);
            // 
            // buttonSzamol
            // 
            this.buttonSzamol.Location = new System.Drawing.Point(28, 69);
            this.buttonSzamol.Name = "buttonSzamol";
            this.buttonSzamol.Size = new System.Drawing.Size(223, 23);
            this.buttonSzamol.TabIndex = 2;
            this.buttonSzamol.Text = "Számol kör adatokat";
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
            this.textBoxKerulet.ReadOnly = true;
            this.textBoxKerulet.Size = new System.Drawing.Size(220, 20);
            this.textBoxKerulet.TabIndex = 4;
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Location = new System.Drawing.Point(323, 249);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonKilepes.TabIndex = 5;
            this.buttonKilepes.Text = "Kilépés";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            this.buttonKilepes.Click += new System.EventHandler(this.buttonKilepes_Click);
            // 
            // textBoxTerulet
            // 
            this.textBoxTerulet.Location = new System.Drawing.Point(31, 231);
            this.textBoxTerulet.Name = "textBoxTerulet";
            this.textBoxTerulet.ReadOnly = true;
            this.textBoxTerulet.Size = new System.Drawing.Size(220, 20);
            this.textBoxTerulet.TabIndex = 6;
            // 
            // errorProviderSugar
            // 
            this.errorProviderSugar.ContainerControl = this;
            // 
            // labelTerulet
            // 
            this.labelTerulet.AutoSize = true;
            this.labelTerulet.Location = new System.Drawing.Point(28, 215);
            this.labelTerulet.Name = "labelTerulet";
            this.labelTerulet.Size = new System.Drawing.Size(92, 13);
            this.labelTerulet.TabIndex = 7;
            this.labelTerulet.Text = "A kiszámolt terület";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Számol gömb adatokat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTerulet);
            this.Controls.Add(this.textBoxTerulet);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.textBoxKerulet);
            this.Controls.Add(this.labelKerulet);
            this.Controls.Add(this.buttonSzamol);
            this.Controls.Add(this.textBoxSugar);
            this.Controls.Add(this.labelSugar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSugar)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxTerulet;
        private System.Windows.Forms.ErrorProvider errorProviderSugar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTerulet;
    }
}

