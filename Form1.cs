using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Web;



namespace Convertor_Valutar_Generic
{

    public partial class Convertor : Form
    {

        string[] CurrencyShortCut = new string[50]; //numele monedelor
        double[] CurrencyCost = new double[50]; // valoarea lor initiala (in lei)
        int IndexFirstListBox; // indexul pentru valoarea din primul listbox
        int IndexSecondListBox;// indexul pentru valoarea din al doilea listbox
        int PressSw; // numarul de apasari al butonului de swith
        

        public Convertor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // initializarea vectorului cu numele monedelor cu " "
            for (int i=0; i<CurrencyShortCut.Length;i++)
            {
                CurrencyShortCut[i] = " ";
            }

            int index = 1, indexCost = 1; // indexul pentru arrays
            String URLString = "https://www.bnr.ro/nbrfxrates.xml"; // link-ul pentru fisierul xml bnr
            XmlTextReader reader = new XmlTextReader(URLString); //instantiere pentru citire (reader)

            while (reader.Read()) //cat timp se citeste
            {
                switch (reader.NodeType) // tipul nodului
                {
                    case XmlNodeType.Element: // Nodul este un element.

                        while (reader.MoveToNextAttribute()) // Citim atributele.
                        {
                            if (Char.IsLetter(reader.Value[0]) && (reader.Value.Length == 3)) // daca primul caracter este char si are dimensiunea 3
                            {
                                CurrencyShortCut[index] = reader.Value; // stocam numele monedei

                                index = index + 1; // incrementam indexul

                            }

                        }
                        break;
                    case XmlNodeType.Text: //preluam textul din fiecare element

                        double copy = 0;
                        double.TryParse(reader.Value, out copy); // convertim din string in double valorile si verificam daca acestea sunt mai mari decat 0
                        if (copy > 0)
                        {
                            CurrencyCost[indexCost] = copy; // salvam in array ul cu valoarea monezilor (lei)
                            indexCost = indexCost + 1; // incremendeam indexul
                        }

                        break;
                }
            }
            // initializarea vectorilor cu nume si cost
            CurrencyShortCut[0] = "LEU";
            CurrencyCost[0] = 1;

            foreach (var item in CurrencyShortCut) // adaugam in lists box numele monezilor
            {
                if (item != " ")
                {
                    listboxFirstCurrency.Items.Add(item);
                    listboxSecondCurrency.Items.Add(item);
                }
                else
                    break; // daca lista s-a terminat, iesim din for
            }

        }

        private void Switch_Click(object sender, EventArgs e)
        {
            if (listboxFirstCurrency.SelectedIndex > -1 && listboxSecondCurrency.SelectedIndex > -1)
            { PressSw++; }
            else MessageBox.Show("Select from both listboxs!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ; // in caz contrar, aplicatia nu poate continua
           // numaram de cate ori s-a apasat butonul de switch sides
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double n; // verificam daca valoarea introdusa in txtbox este un numar
            bool isNumeric = double.TryParse(txtFirstCurrency.Text, out n);

            if (txtFirstCurrency.Text=="" || isNumeric==false)//daca nu este numar sau nu s-a introdus nimic
            {
             
                MessageBox.Show("Field is empty or is not a number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // nu modificam formul pana cand nu se introduc datele corect
            }

            //salvam textul din txtbox
            double a = 0;
            a = Convert.ToDouble(txtFirstCurrency.Text);

            if (PressSw%2!=0) //daca butonul de switch s-a apasat de un numar impar se realizeaza swichtul 
            {
                IndexFirstListBox = listboxSecondCurrency.SelectedIndex;
                IndexSecondListBox = listboxFirstCurrency.SelectedIndex;
                PressSw = 0;
            }
            else // daca este par nu se realizeaza si se reseteaza contorul
            {
                IndexFirstListBox = listboxFirstCurrency.SelectedIndex;
                IndexSecondListBox = listboxSecondCurrency.SelectedIndex;
                PressSw = 0;
            }


            //daca ambele currency uri au fost selectate se poate merge mai departe
            if (listboxFirstCurrency.SelectedIndex > -1 && listboxSecondCurrency.SelectedIndex > -1)
            { }
            else
            {

                MessageBox.Show("Select from both listboxs! .", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ; // in caz contrar, aplicatia nu poate continua
                return;
            }

                // salvam indexul valorilor pe care le selectam din lists box
            string NameFirstBox, NameSecondBox; 
            NameFirstBox = CurrencyShortCut[IndexFirstListBox];
            NameSecondBox= CurrencyShortCut[IndexSecondListBox];

            // valoarea conversiei este numarul introdus pentru conversie inmultit cu diferenta dintre prima si a doua moneda
            double result = a * (CurrencyCost[IndexFirstListBox] / CurrencyCost[IndexSecondListBox]);


            // ascundem primul forms la aparitia celui de al doilea, la inchiderea celuilalt va aparea din nou primul
            this.Hide();
            var form2 = new Form2(NameFirstBox, NameSecondBox, result); 
            form2.ShowDialog();
            form2 = null;
            this.Show();

            listboxSecondCurrency.SelectedIndex = -1;
            listboxFirstCurrency.SelectedIndex = -1;

        }

        // metoda primului listbox
        private void listboxFirstCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        // metoda pentru al doilea listbox
        private void listboxSecondCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        // metoda txtbox in care introducem valoarea de convertit
        private void txtFirstCurrency_Click(object sender, EventArgs e)
        {
            

        }

        private void txtFirstCurrency_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
