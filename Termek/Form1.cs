using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TermekProjekt.model;

namespace TermekProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            double termekAr = Convert.ToDouble(textBoxAr.Text);
            double afa = Convert.ToDouble(textBoxAFA.Text);
            int mennyiseg = Convert.ToInt32(textBoxMennyiseg.Text);
        }
    }
}
