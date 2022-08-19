using CapaEntidad;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class FRCliente : Form
    {
        CNCliente cnCliente=new CNCliente();
        public FRCliente()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtID.Value = 5;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            PicFoto.Image = null;
        }
        private void lnkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdFoto.FileName = string.Empty;
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                PicFoto.Load(ofdFoto.FileName);
            }
            ofdFoto.FileName = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado;
            CECliente ceCliente = new CECliente();
            ceCliente.Id = (int)txtID.Value;
            ceCliente.Nombre = txtNombre.Text;
            ceCliente.Apellido = txtApellido.Text;
            ceCliente.Foto = PicFoto.ImageLocation;
            resultado=cnCliente.ValidarDatos(ceCliente);

            if (resultado==false)
            {
                return;
            }
            //MessageBox.Show("OOKK");
            cnCliente.CrearCliente(ceCliente);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cnCliente.PruebaMySQL();
        }
    }
}