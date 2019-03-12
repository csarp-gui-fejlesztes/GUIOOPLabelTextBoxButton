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
            elrejtEredemnyt();
        }

        private void megjelenitEredmenyt()
        {
            labelKerulet.Visible = true;
            labelTerulet.Visible = true;
            textBoxTerulet.Visible = true;
            textBoxKerulet.Visible = true;
        }

        public void elrejtEredemnyt()
        {
            labelKerulet.Visible = false;                        
            labelTerulet.Visible = false;
            textBoxTerulet.Visible = false;
            textBoxKerulet.Visible = false;
        }

        private void buttonKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                double sugar = Convert.ToDouble(textBoxSugar.Text);
                Kor k = new Kor(sugar);
                textBoxKerulet.Text = k.getKerulet().ToString();
                megjelenitEredmenyt();
            }
            catch (FormatException fe)
            {
                errorProviderSugar.SetError(textBoxSugar, "A szám formátuma nem megfelelő!");
            }
            catch(OverflowException oe)
            {
                errorProviderSugar.SetError(textBoxSugar, "A szám túl nagy vagy túl kicsi!");
            }
            catch (KornekRosszASugaraException krs)
            {
                errorProviderSugar.SetError(textBoxSugar, krs.Message);
            }
            catch(Exception ex)
            {
                errorProviderSugar.SetError(textBoxSugar, "Ismeretlen hiba!");
            }
            
        }

        private void textBoxSugar_TextChanged(object sender, EventArgs e)
        {
            errorProviderSugar.Clear();
            elrejtEredemnyt();
        }
    }
}
