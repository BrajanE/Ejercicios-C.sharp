using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _14_3_Forms
{
    public partial class Notepad : Form
    {
        private OpenFileDialog buscarArchivo;
        private SaveFileDialog guardarArchivo;
        private string ultimoArchivo;

        public Notepad()
        {
            InitializeComponent();
            buscarArchivo = new OpenFileDialog();
            guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "Archivo de texto |*.txt";
        }

        private string UltimoArchivo
        {
            get
            {
                return ultimoArchivo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    ultimoArchivo = value;
                }
            }
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            tsSs_cantCaracteres.Text = "0 caracteres";
        }

        private void abrirTs_archivo_Click(object sender, EventArgs e)
        {
            if (buscarArchivo.ShowDialog() == DialogResult.OK)
            {
                UltimoArchivo = buscarArchivo.FileName;
                try
                {
                    using (StreamReader lector = new StreamReader(UltimoArchivo))
                    {
                        rtbx_lectoescritura.Text = lector.ReadToEnd();
                    }
                    tsSs_cantCaracteres.Text = $"{rtbx_lectoescritura.Text.Length}";
                }
                catch (Exception ex)
                {
                    RegistroError(ex);
                }
            }
        }

        private void guardarComoTs_archivo_Click(object sender, EventArgs e)
        {
            UltimoArchivo = GuardarRuta();
            GuardarArchivo(UltimoArchivo);
        }

        private void guardarTs_archivo_Click(object sender, EventArgs e)
        {
            if (!File.Exists(UltimoArchivo))
            {
                UltimoArchivo = GuardarRuta();
            }
            GuardarArchivo(UltimoArchivo);
        }

        private void GuardarArchivo(string ruta)
        {         
            try
            {
                if (!string.IsNullOrWhiteSpace(ruta))
                {
                    using (StreamWriter escritor = new StreamWriter(ruta))
                    {
                        escritor.Write(rtbx_lectoescritura.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                RegistroError(ex);
            }

        }
        private string GuardarRuta()
        {
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                return guardarArchivo.FileName;
            }
            return string.Empty;
        }
        private void RegistroError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error: {ex.Message}");
            sb.AppendLine($"{ex.StackTrace}");

            MessageBox.Show(sb.ToString());
        }
    }
}
