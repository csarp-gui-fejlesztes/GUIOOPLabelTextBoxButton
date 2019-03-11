using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GUIOOP.model;

namespace GUIOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            double sugar = Convert.ToDouble(textBoxSugar.Text);
            Kor k = new Kor(sugar);
            textBoxKerulet.Text = k.getKerulet().ToString();
        }
    }
}
