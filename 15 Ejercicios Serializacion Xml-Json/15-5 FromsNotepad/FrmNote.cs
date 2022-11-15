using _15_5_IO;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _15_5_FromsNotepad
{
    public partial class FrmNote : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private string ultimoArchivo;
        private PuntoJson<string> puntoJson;
        private PuntoTxt puntoTxt;
        private PuntoXml<string> puntoXml;

        public FrmNote()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Archivo de texto |*.txt;*.json;*.xml";
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            puntoJson = new PuntoJson<string>();
            puntoTxt = new PuntoTxt();
            puntoXml = new PuntoXml<string>();
        }

        public string UltimoArchivo
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

        private void FrmNote_Load(object sender, EventArgs e)
        {
            tsSs_cantCaracteres.Text = "0 caracteres";
        }

        private void abrirTs_archivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                UltimoArchivo = openFileDialog.FileName;
                try
                {                  
                    switch (Path.GetExtension(UltimoArchivo))
                    {
                        case ".json":
                            rtbx_lectoescritura.Text = puntoJson.Leer(UltimoArchivo);
                            tsSs_cantCaracteres.Text = $"{rtbx_lectoescritura.Text.Length} - caracteres";
                            break;
                        case ".xml":
                            rtbx_lectoescritura.Text = puntoXml.Leer(UltimoArchivo);
                            tsSs_cantCaracteres.Text = $"{rtbx_lectoescritura.Text.Length} - caracteres";
                            break;
                        case ".txt":
                            rtbx_lectoescritura.Text = puntoTxt.Leer(UltimoArchivo);
                            tsSs_cantCaracteres.Text = $"{rtbx_lectoescritura.Text.Length} - caracteres";
                            break;
                    }
                }
                catch (Exception ex)
                {
                    RegistroError(ex);
                }
            }
        }

        private void guardarComoTs_archivo_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void guardarTs_archivo_Click(object sender, EventArgs e)
        {

            if (!File.Exists(UltimoArchivo))
            {
                GuardarComo();
            }
            else Guardar();
        }

        private void GuardarComo()
        {
            UltimoArchivo = GuardarRuta();
            try
            {
                //switch (Path.GetExtension(UltimoArchivo))
                //{
                //    case ".json":
                //        puntoJson.GuardarComo(UltimoArchivo, rtbx_lectoescritura.Text);
                //        break;
                //    case ".xml":
                //        puntoXml.GuardarComo(UltimoArchivo, rtbx_lectoescritura.Text);
                //        break;
                //    case ".txt":
                //        puntoTxt.GuardarComo(UltimoArchivo, rtbx_lectoescritura.Text);
                //        break;
                //}
                Guardar();
            }
            catch (Exception ex)
            {
                RegistroError(ex);
            }
        }
        private void Guardar()
        {
            try
            {
                switch (Path.GetExtension(UltimoArchivo))
                {
                    case ".json":
                        puntoJson.GuardarComo(UltimoArchivo, rtbx_lectoescritura.Text);
                        break;
                    case ".xml":
                        puntoXml.GuardarComo(UltimoArchivo, rtbx_lectoescritura.Text);
                        break;
                    case ".txt":
                        puntoTxt.GuardarComo(UltimoArchivo, rtbx_lectoescritura.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                RegistroError(ex);
            }
        }

        private string GuardarRuta()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            return string.Empty;
        }
        private void RegistroError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error: {ex.Message}");
            sb.AppendLine($"{ex.StackTrace}");

            MessageBox.Show(sb.ToString(), "Problema con Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void toolStrip1_TextChanged(object sender, EventArgs e)
        {     
            tsSs_cantCaracteres.Text = $"{rtbx_lectoescritura.Text.Length} - caracteres";
        }
    }
}
