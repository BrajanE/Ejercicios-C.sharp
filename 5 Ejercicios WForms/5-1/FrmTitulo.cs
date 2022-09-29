using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_1
{
    public partial class FrmTitulo : Form
    {
        private string titulo;
        private string mensaje;
        public FrmTitulo(string titulo, string mensaje)
        {
            InitializeComponent();
            this.titulo = titulo;
            this.mensaje = mensaje;
        }

        private void FrmTitulo_Load(object sender, EventArgs e)
        {
            lbl_titulo.Text = titulo;
            lbl_nombreCompleto.Text = mensaje;
        }
    }
}
