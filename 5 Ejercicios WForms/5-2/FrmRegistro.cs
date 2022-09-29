using _5_2_Registrate;
using System;
using System.Windows.Forms;

namespace _5_2
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            lbx_paises.Items.Add("Argentina");
            lbx_paises.Items.Add("Chile");
            lbx_paises.Items.Add("Uruguay");
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_nombre.Text) && string.IsNullOrWhiteSpace(txb_direccion.Text))
            {
                MessageBox.Show("Complete los datos", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] cursos = new string[3];
                cursos = AgregarCursos(chb_cSharp, cursos);
                cursos = AgregarCursos(chb_cMas, cursos);
                cursos = AgregarCursos(chb_javaScript, cursos);


                string direccion = txb_direccion.Text;
                int edad = (int)nud_edad.Value;
                string genero = "";
                if (rbtn_masculino.Checked)
                {
                    genero = rbtn_masculino.Text;
                }
                else if (rbtn_femenino.Checked)
                {
                    genero = rbtn_femenino.Text;
                }
                else if (rbtn_noBinario.Checked)
                {
                    genero = rbtn_noBinario.Text;
                }

                string nombre = txb_nombre.Text;
              
                string pais = lbx_paises.Text;

               

                Ingresante ingresante = new Ingresante(cursos, direccion, edad, genero, nombre, pais);
                MessageBox.Show(ingresante.Mostrar());
            }
        }
        public string[] AgregarCursos(CheckBox chb, string[] cursos)
        {
            if (chb.Checked)
            {
                for (int i = 0; i < cursos.Length; i++)
                {
                    if (cursos[i] is null)
                    {
                        cursos[i] = chb.Text;
                        return cursos;
                    }

                }
            }
            return cursos;
        }
    }
}
