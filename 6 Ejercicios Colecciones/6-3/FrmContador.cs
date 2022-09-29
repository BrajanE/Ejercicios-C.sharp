using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_3
{
    public partial class FrmContador : Form
    {
        public FrmContador()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string texto = rtb_palabras.Text;           
            Dictionary<string, int> contadorPalabras = LogicaForm.ObtenerContadorPalabras(texto);
           
            //Transformamos el diccionario de par clave - valor
            //En una lista de clave - valor
            List<KeyValuePair<string, int>> palabrasPorCantidad = contadorPalabras.ToList();
            palabrasPorCantidad.Sort(LogicaForm.CompararCantidadRepeticiones);     
            
            MessageBox.Show(LogicaForm.MostrarPalabras(palabrasPorCantidad), "Palabras repetidas");
        }    
    }
}
