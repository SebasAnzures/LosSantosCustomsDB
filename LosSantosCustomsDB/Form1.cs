using LosSantosCustomsDB.Controller;

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
    }
}
