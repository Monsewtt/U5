using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace tarea_U5
{
    public partial class Form1 : Form
    {
        private string rutaBusqueda = @"C:\Users\miamo\OneDrive\Desktop\U5 tarea";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            listarchivos.Items.Clear();
            richtxtcontenido.Clear();

            string textoBusqueda = txtbuscar.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                MessageBox.Show("Por favor escribe una parte del nombre del archivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(rutaBusqueda))
            {
                MessageBox.Show("La carpeta especificada no existe: " + rutaBusqueda, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] archivos = Directory.GetFiles(rutaBusqueda, $"{textoBusqueda}*.txt");

            if (archivos.Length == 0)
            {
                MessageBox.Show("No se encontraron archivos que coincidan.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (string archivo in archivos)
            {
                listarchivos.Items.Add(Path.GetFileName(archivo));
            }
        }

        private void listarchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listarchivos == null) return;

            string archivoSeleccionado = listarchivos.ToString();
            string rutaCompleta = Path.Combine(rutaBusqueda, archivoSeleccionado);

            try
            {
                string contenido = File.ReadAllText(rutaCompleta);
                richtxtcontenido.Text = contenido;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

