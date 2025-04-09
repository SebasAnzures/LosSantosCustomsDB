using LosSantosCustomsDB.Controller;
using LosSantosCustomsDB.Model;
using System.Xml.Linq;

namespace LosSantosCustomsDB
{
    public partial class Form1 : Form
    {
        private AutosRepository acciones = new AutosRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            gvDatos.DataSource = acciones.Leer();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Autos ni = new Autos(
                    Convert.ToInt32(tbID.Text),
                    tbMarca.Text,
                    tbModelo.Text,
                    Convert.ToInt32(tbAno.Text),
                    Convert.ToInt32(tbDisponible.Text)

                );
                if (acciones.Insertar(ni))
                {
                    gvDatos.DataSource = null;
                    gvDatos.DataSource = acciones.Leer();
                    tbID.Text = "";
                    tbMarca.Text = "";
                    tbModelo.Text = "";
                    tbAno.Text = "";
                    tbDisponible.Text = "";


                }
                else
                {
                    MessageBox.Show("No se pudo agregar el elemento");
                }
            }
            catch (FormatException) // Específicamente capturamos el error de formato al intentar convertir el ID
            {
                MessageBox.Show("El ID debe ser un número válido.");
            }
            catch (Exception ex) // Para cualquier otro tipo de excepción
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Autos ni = new Autos(
                    Convert.ToInt32(tbID.Text),
                    tbMarca.Text,
                    tbModelo.Text,
                    Convert.ToInt32(tbAno.Text),
                    Convert.ToInt32(tbDisponible.Text)

                );
                if (acciones.Actualizar(ni))
                {
                    gvDatos.DataSource = null;
                    gvDatos.DataSource = acciones.Leer();
                    tbID.Text = "";
                    tbMarca.Text = "";
                    tbModelo.Text = "";
                    tbAno.Text = "";
                    tbDisponible.Text = "";


                }
                else
                {
                    MessageBox.Show("No se pudo agregar el elemento");
                }
            }
            catch (FormatException) // Específicamente capturamos el error de formato al intentar convertir el ID
            {
                MessageBox.Show("El ID debe ser un número válido.");
            }
            catch (Exception ex) // Para cualquier otro tipo de excepción
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                acciones.Eliminar(Convert.ToInt32(tbID.Text));
                gvDatos.DataSource = null;
                gvDatos.DataSource = acciones.Leer();
                tbID.Text = "";
            }
            catch (FormatException) // Específicamente capturamos el error de formato al intentar convertir el ID
            {
                MessageBox.Show("El ID debe ser un número válido.");
            }
            catch (Exception ex) // Para cualquier otro tipo de excepción
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
