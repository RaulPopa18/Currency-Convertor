using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertor_Valutar_Generic
{
    public partial class Form2 : Form
    {
        // stocam valorile data prin parametrii (valori globale)
        double result2;
        string NameSecondBox2;
        string NameFirstBox2;
        public Form2(string NameFirstBox, string NameSecondBox, double result)
        {
            InitializeComponent();
            //preluam valorile
            NameFirstBox2 = NameFirstBox;
            NameSecondBox2 = NameSecondBox;
            result2 = result;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //modificam in form
            txtBox1Form2.Text = NameFirstBox2;
            txtBox2Form2.Text = NameSecondBox2;
            txtBoxCurrecy.Text = NameSecondBox2;

            //afisam numarul cu 4 zecimale
            result2 = (double)System.Math.Round(result2, 4);

            string ex = Convert.ToString(result2);
            txtBoxResultForm2.Text += ex;

        }
        // metoda txtboxului
        private void txtBoxCurrecy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
