using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormClase2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new ServiceReference1.WebService1SoapClient();
            string cuil = Tipo_txtBox.Text + DNI_txtBox.Text + DV_txtBox.Text;
            if (validacion(cuil))
            {
                var result = client.CUILValidator(Convert.ToInt32(Tipo_txtBox.Text), DNI_txtBox.Text, Convert.ToInt32(DV_txtBox.Text));
                if (result)
                {
                    MessageBox.Show("El CUIL es valido");
                }
                else
                {
                    MessageBox.Show("El CUIL es invalido");
                }
            }
            else
                MessageBox.Show("El CUIT/CUIL está ingresado en un formato invalido.");
        }
        
        private bool validacion(string cuil)
        {
            bool esValido = Regex.IsMatch(cuil, @"^\d{2}\d{7,8}\d{1}$");
            return esValido;
        }
    }
}
