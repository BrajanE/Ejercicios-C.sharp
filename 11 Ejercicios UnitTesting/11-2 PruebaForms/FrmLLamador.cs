using _11_2_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_2_PruebaForms
{  
    public partial class FrmLLamador : Form
    {
        Centralita centralLLamador;
        public FrmLLamador(Centralita central)
        {
            InitializeComponent();
            centralLLamador = central;
            cmb_franja.DataSource = Enum.GetValues(typeof(EFranja));
            cmb_franja.Enabled = false;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text += "1";
            btn_numeral.Enabled = false;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text += "2";
            btn_numeral.Enabled = false;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text += "3";
            btn_numeral.Enabled = false;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text += "4";
            btn_numeral.Enabled = false;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text += "5";
            btn_numeral.Enabled = false;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text += "6";
            btn_numeral.Enabled = false;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text += "7";
            btn_numeral.Enabled = false;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text += "8";
            btn_numeral.Enabled = false;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text += "9";
            btn_numeral.Enabled = false;
        }

        private void btn_asterisco_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text += "*";
            btn_numeral.Enabled = false;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text += "0";
            btn_numeral.Enabled = false;
        }

        private void btn_numeral_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text += "#";
            cmb_franja.Enabled = true;
            btn_numeral.Enabled = false;
        }

        private void btn_llamar_Click(object sender, EventArgs e)
        {
            string origen = txtb_nroOrigen.Text;
            string destino = txtb_nroDestino.Text;
            Random rnd = new Random();
            float duracion = rnd.Next(1, 50);
            float costo = rnd.Next(1, 6);
            try
            {
                if (destino.StartsWith("#"))
                {
                    EFranja franjas;
                    Enum.TryParse<EFranja>(cmb_franja.SelectedValue.ToString(), out franjas);
                    Provincial llProv = new Provincial(origen, franjas, duracion, destino);
                    centralLLamador += llProv;
                }
                else
                {
                    Local llLocal = new Local(origen, duracion, destino, costo);
                    centralLLamador += llLocal;
                }
            }
            catch (CentralitaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txtb_nroDestino.Text = "";
            txtb_nroOrigen.Text = "";
            btn_numeral.Enabled = true;
            cmb_franja.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
