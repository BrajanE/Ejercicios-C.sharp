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
    public partial class FrmMenu : Form
    {
        Centralita central;
        public FrmMenu()
        {
            InitializeComponent();
            central = new Centralita();
        }

        private void btn_generarLLamada_Click(object sender, EventArgs e)
        {
            FrmLLamador llamador = new FrmLLamador(central);
            llamador.Show();
        }

        private void btn_facTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrarDatos = new FrmMostrar(central);

            mostrarDatos.Show();
        }

        private void btn_facLocal_Click(object sender, EventArgs e)
        {
            Centralita auxLocal = new Centralita();
            foreach (LLamada ll in central.LLamadas)
            {
                if (ll is Local llLocal)
                {
                    auxLocal += llLocal;
                }
            }
            FrmMostrar mostrarDatos = new FrmMostrar(auxLocal);
            mostrarDatos.Show();
        }

        private void btn_facProvincial_Click(object sender, EventArgs e)
        {
            Centralita auxProvincial = new Centralita();
            foreach (LLamada ll in central.LLamadas)
            {
                if (ll is Provincial llProvincial)
                {
                    auxProvincial += llProvincial;
                }
            }
            FrmMostrar mostrarDatos = new FrmMostrar(auxProvincial);
            mostrarDatos.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
