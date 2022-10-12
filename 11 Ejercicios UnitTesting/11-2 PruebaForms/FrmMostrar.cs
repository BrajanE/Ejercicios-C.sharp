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
    public partial class FrmMostrar : Form
    {
        Centralita centralMostrador;
        public FrmMostrar(Centralita central)
        {
            InitializeComponent();
            centralMostrador = central;
            rtbx_informador.Text = centralMostrador.ToString();
        }
    }
}
