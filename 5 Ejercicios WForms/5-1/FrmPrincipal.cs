using System;
using System.Windows.Forms;

namespace _5_1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cmb_materias.DropDownStyle = ComboBoxStyle.DropDownList;
            //con esto impedimos que se cambien los datos del combobox
            cmb_materias.Items.Add("Programación I");
            cmb_materias.Items.Add("Laboratorio de Computación I");
            cmb_materias.Items.Add("Sistema de procesamiento de datos");
            cmb_materias.Items.Add("Inglés I");
            cmb_materias.Items.Add("Matemática");
            cmb_materias.Items.Add("Programación II");
            cmb_materias.Items.Add("Laboratorio de Computación II");
            cmb_materias.Items.Add("Inglés II");
            cmb_materias.Items.Add("Metodología de la investigación");
            cmb_materias.Items.Add("Arquitectura y sistemas operativos");
            cmb_materias.Items.Add("Estadística");
            cmb_materias.SelectedIndex = 0;
            
        }
        private void btn_saludar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_nombre.Text) && string.IsNullOrWhiteSpace(txb_apellido.Text))
            {
                MessageBox.Show("Ingrese los siguientes datos:\n-Nombre\n-Apellido", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(txb_apellido.Text))
            {
                MessageBox.Show("Ingrese los siguientes datos:\n-Apellido", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(string.IsNullOrWhiteSpace(txb_nombre.Text))
            {
                MessageBox.Show("Ingrese los siguientes datos:\n-Nombre", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                FrmTitulo ventanaSaludo = new FrmTitulo("Hola, Windows Forms", $"Soy {txb_nombre.Text} {txb_apellido.Text}, mi materia favorita es {cmb_materias.Text}");
                ventanaSaludo.ShowDialog();
            }
        }
    }
}
