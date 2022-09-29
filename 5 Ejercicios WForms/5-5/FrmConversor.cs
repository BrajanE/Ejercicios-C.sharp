using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _5_5_ConversorBinario;

namespace _5_5
{
    public partial class FrmConversor : Form
    {
        public FrmConversor()
        {
            InitializeComponent();
        }

        private void btn_binXdecimal_Click(object sender, EventArgs e)
        {
            if (txb_binario.Text == "1" || txb_binario.Text == "0")
            {
                NumeroBinario binario = (NumeroBinario)txb_binario.Text;
                txb_binResult.Text = (((NumeroDecimal)binario).Numero).ToString();
            }
            else MessageBox.Show("Datos invalidos");
            
       

        }

        private void btn_deciXbinario_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txb_decimal.Text,out double numIngresado))
            {
                string numero = Conversor.ConvertirDecimalABinario(numIngresado);
                txb_decimResult.Text = numero;
            }
            else MessageBox.Show("Datos invalidos");
        }
    }
}
