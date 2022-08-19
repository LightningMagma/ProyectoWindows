using CapaEntidad;
using CapaDatos;
using System.Windows.Forms;
using System.Data;
namespace CapaNegocio
{
    public class CNCliente
    {
        CDCliente cdCliente = new CDCliente();
        public bool ValidarDatos(CECliente cliente)
        {
            bool resultado = true;
            if (cliente.Nombre==string.Empty)
            {
                MessageBox.Show("NOMBRE es un campo obligatorio");
            }

            if (cliente.Apellido == string.Empty)
            {
                MessageBox.Show("Apellido es un campo obligatorio");
            }
            
            if (cliente.Foto == null)
            {
                MessageBox.Show("añadir foto");
            }

            return resultado;
        }

        public void PruebaMySQL()
        {
            cdCliente.PruebaConexion();
        }
        public void CrearCliente(CECliente cec)
        {
            cdCliente.Insertar(cec);
        }
    }
}