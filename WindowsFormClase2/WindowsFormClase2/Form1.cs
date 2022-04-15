using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
