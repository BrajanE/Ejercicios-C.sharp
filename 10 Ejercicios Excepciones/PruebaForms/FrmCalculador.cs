using _10_2_Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PruebaForms
{
    public partial class FrmCalculador : Form
    {
        public FrmCalculador()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarParametros(txb_kilometros.Text, txb_litros.Text);
                float kilometros = float.Parse(txb_kilometros.Text);
                float litros = float.Parse(txb_litros.Text);
                string resultado = (Calculador.Calcular(kilometros, litros)).ToString();
                List<string> historialResultados = new List<string>();
                historialResultados.Add(resultado);
                foreach (string res in historialResultados)
                {
                        rtb_informacion.Text += res+"\n";
                }
                

            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Datos invalidos, ingrese numeros");
            }
        }
        private void VerificarParametros(string kilometros, string litros)
        {
            if (txb_kilometros.Text == "" || txb_litros.Text == "" || txb_kilometros.Text is null || txb_litros.Text is null)
            {
                throw new ParametrosVaciosException();
            }           
        }
    }
}
