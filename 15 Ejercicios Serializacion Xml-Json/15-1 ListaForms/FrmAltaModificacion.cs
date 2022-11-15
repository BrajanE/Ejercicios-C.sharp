using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_1_ListaForms
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion(string titulo, string textoObjeto, string txtBotonconfirmar)
        {
            InitializeComponent();
            Text = titulo;
            txt_objeto.Text = textoObjeto;
            btn_confirmar.Text = txtBotonconfirmar;
        }

        public string Objeto
        {
            get
            {
                return txt_objeto.Text;
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void txt_objeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                Confirmar();
            }
            else if(e.KeyChar == (char)27)
            {
                Cancelar();
            }
        }

        private void Confirmar()
        {
            if (!string.IsNullOrEmpty(Objeto))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Sin datos para trabajar", "Error", MessageBoxButtons.OK);
        }
        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
    }
}
