using System;
using System.Windows.Forms;
using _5_3_Cotizadora;

namespace _5_3
{
    public partial class FrmCotizador : Form
    {
        bool flag;
        Pesos pesos;
        Euro euros;
        Dolar dolares;

        public FrmCotizador()
        {
            InitializeComponent();
            pesos = new Pesos();
            euros = new Euro();
            dolares = new Dolar();
        }
        private void FrmCotizador_Load(object sender, EventArgs e)
        {
           
        }
        private void btn_cotizar_Click(object sender, EventArgs e)
        {        
            flag = Bloquear(flag);       
        }
        public bool Bloquear(bool opcion)
        {
            txb_dolarValor.Enabled = opcion;
            txb_euroValor.Enabled = opcion;
            txb_pesoValor.Enabled = opcion;

            txb_dolarXdolar.Enabled = opcion;
            txb_dolarXeuro.Enabled = opcion;
            txb_dolarXpeso.Enabled = opcion;

            txb_euroXdolar.Enabled = opcion;
            txb_euroXeuro.Enabled = opcion;
            txb_euroXpeso.Enabled = opcion;

            txb_pesoXdolar.Enabled = opcion;
            txb_pesoXeuro.Enabled = opcion;
            txb_pesoXpeso.Enabled = opcion;

            return !opcion;
        }

        private void btn_euro_Click(object sender, EventArgs e)
        {           
            euros.SetCantidad(txb_euroCant.Text);
            Euro.SetCotizacion(txb_euroValor.Text);

            txb_euroXdolar.Text = Math.Round(((Dolar)euros).GetCantidad(), 2).ToString();
            txb_euroXeuro.Text = (euros.GetCantidad()).ToString();
            txb_euroXpeso.Text = Math.Round(((Pesos)euros).GetCantidad(), 2).ToString();
        }

        private void btn_dolar_Click(object sender, EventArgs e)
        {
            dolares.SetCantidad(txb_dolarCant.Text);
            Dolar.SetCotizacion(txb_dolarValor.Text);

            txb_dolarXeuro.Text = Math.Round(((Euro)dolares).GetCantidad(), 2).ToString();
            txb_dolarXdolar.Text = (dolares.GetCantidad()).ToString();
            txb_dolarXpeso.Text = Math.Round(((Pesos)dolares).GetCantidad(), 2).ToString();
        }

        private void btn_pesos_Click(object sender, EventArgs e)
        {
            pesos.SetCantidad(txb_pesosCant.Text);
            Pesos.SetCotizacion(txb_pesoValor.Text);

            txb_pesoXdolar.Text = Math.Round(((Dolar)pesos).GetCantidad(), 2).ToString();
            txb_pesoXeuro.Text = Math.Round(((Euro)pesos).GetCantidad(), 2).ToString();
            txb_pesoXpeso.Text = (pesos.GetCantidad()).ToString();
        }
    }
}
