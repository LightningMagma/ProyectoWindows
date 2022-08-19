using System;
using MySql.Data.MySqlClient;
using CapaEntidad;
using System.Windows.Forms;
using System.Data;
namespace CapaDatos
{
    public class CDCliente
    {
        string CadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;database=proyectocrud";
        public void PruebaConexion()
        {
            MySqlConnection conex = new MySqlConnection(CadenaConexion);
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show ("NO SE PUDO CONECTAR "+ex.Message);
                return;
            }

            conex.Close();
            MessageBox.Show("CONEXION EXITOSA");
        }

        public void Insertar(CECliente ce)
        {
            MySqlConnection conn = new MySqlConnection(CadenaConexion);
            conn.Open();
            string query = "INSERT INTO cliente (NombreCliente, ApellidosCliente, FotoCliente) VALUES ('" + ce.Nombre+"', '" + ce.Apellido+"', '" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(ce.Foto)+"')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Registro exitoso");
        }
    }
}