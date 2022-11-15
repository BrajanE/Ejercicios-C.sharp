using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _15_1_ListaForms
{
    public partial class FrmListaSuper : Form
    {
        private List<string> listaSupermercado;
        string ruta;
        public FrmListaSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\listaSupermercado.xml";

        }
        private void AsignarToolTip()
        {
            toolt_agregar.SetToolTip(btn_agregar, "Agregar objeto");
            toolt_quitar.SetToolTip(btn_quitar, "Quitar objeto");
            toolt_modificar.SetToolTip(btn_modificar, "Modificar objeto");
        }
        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            AsignarToolTip();
            CargarArchivoXml();
            ActualizarListado();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAltaMod = new FrmAltaModificacion("Agregar objeto", String.Empty, "Agregar");
            frmAltaMod.ShowDialog();
            if (frmAltaMod.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(frmAltaMod.Objeto);
                GuardarEnArchivoXml();
                ActualizarListado();
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = lsbx_objetos.SelectedItem as string;
            if (objetoSeleccionado is not null)
            {
                listaSupermercado.Remove(objetoSeleccionado);
                GuardarEnArchivoXml();
                ActualizarListado();

            }
            else MessageBox.Show("Debe seleccionar el objeto a eliminar", "Atencion", MessageBoxButtons.OK);

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = lsbx_objetos.SelectedItem as string;
            FrmAltaModificacion frmAltaMod = new FrmAltaModificacion("Modificar objeto", objetoSeleccionado, "Modificar");

            if (objetoSeleccionado is not null)
            {
                frmAltaMod.ShowDialog();
                if (frmAltaMod.DialogResult == DialogResult.OK)
                {
                    int posicion = listaSupermercado.IndexOf(objetoSeleccionado);

                    listaSupermercado[posicion] = frmAltaMod.Objeto;
                    GuardarEnArchivoXml();
                    ActualizarListado();
                }
            }
            else MessageBox.Show("Debe seleccionar el objeto a modificar", "Atencion", MessageBoxButtons.OK);
        }
        private void ActualizarListado()
        {
            lsbx_objetos.DataSource = null;
            lsbx_objetos.DataSource = listaSupermercado;
        }
        private void CargarArchivoXml()
        {

            if (File.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    try
                    {
                        XmlSerializer lectorXml = new XmlSerializer(listaSupermercado.GetType());
                        listaSupermercado = lectorXml.Deserialize(sr) as List<string>;
                    }
                    catch
                    {
                        MessageBox.Show("No se encontro el archivo/lista", "Atencion", MessageBoxButtons.OK);
                    }
                }

            }
        }
        private void GuardarEnArchivoXml()
        {
            if (!File.Exists(ruta))
            {
                File.Create(ruta);
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    XmlSerializer escritorXml = new XmlSerializer(listaSupermercado.GetType());
                    escritorXml.Serialize(sw, listaSupermercado);
                }
            }
            catch
            {
                MessageBox.Show("Error en guardado de archivo/lista", "Atencion", MessageBoxButtons.OK);
            }

        }
    }
}
