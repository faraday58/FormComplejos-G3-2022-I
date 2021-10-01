using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Complejos;
namespace FormComplejos_G3_2022_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool cI1Error=false;
        bool cR1Error=false;

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                if( txtbImaginariaComplejo1.Text == ""   )
                {
                    cI1Error = true;
                    string error = "Debes de introducir  un valor numérico";
                    throw new ApplicationException(error);
                    
                }
                if( txtbRealComplejo1.Text == ""   )
                {
                    cR1Error = true;
                    string error = "Debes de introducir  un valor numérico";
                    throw new ApplicationException(error);
                    
                }


                Complejo c1 = new Complejo(float.Parse(txtbRealComplejo1.Text), float.Parse(txtbImaginariaComplejo1.Text));
                Complejo c2 = new Complejo(float.Parse(txtbRealComplejo2.Text), float.Parse(txtbImaginarioComplejo2.Text));
                Complejo c3 = c1 + c2;
                lbResultadoComplejo1.Text = c3.ToString();

            }
            catch( ApplicationException error   )
            {
                if(cI1Error    )
                {
                    errorProvider1.SetError(txtbImaginariaComplejo1, error.Message);
                }
                else if (cR1Error )
                {
                    errorProvider1.SetError(txtbRealComplejo1, error.Message);
                }
                
            }

            catch(FormatException error)
            {
                MessageBox.Show("Error " + error.Message);
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }

        }
    }
}
