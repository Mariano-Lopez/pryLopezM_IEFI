using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace pryLopezM_IEFI
{
    public class clsConexionBBDD
    {
        //cadena de conexion.
        string cadenaConexion = "Server=localhost;Database=BBDDUsuarios;Trusted_Connection=True;";

        //conector.
        SqlConnection conexionBaseDatos;

        //comando.
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;

        public void cargarUsuarios(clsUsuarios lst)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = "SELECT * FROM Usuarios";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable.
                DataTable tablaProductos = new DataTable();

                //Llenar el DataTable.
                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    tablaProductos.Load(reader);
                }

                
                foreach (DataRow fila in tablaProductos.Rows)
                {
                    int id = Convert.ToInt32(fila[0]);
                    string usuario = fila[1].ToString();
                    string contra = fila[2].ToString();
                    int permisos = Convert.ToInt32(fila[3]);

                    clsUsuario aux = new clsUsuario(id, usuario, contra, permisos);

                    lst.lstUsuarios.Add(aux);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void actualizarSesion(int idSesion, TimeSpan tiempoSesion, TimeSpan tiempoTotal, DateTime fechaActual)
        {
            string query = "UPDATE sesionUs SET tiempoSesion = @tiempoSesion, tiempoTotal = @tiempoTotal, fechaActual = @fechaActual WHERE idSesion = @idSesion";

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tiempoSesion", (long)tiempoSesion.TotalSeconds);
                    cmd.Parameters.AddWithValue("@tiempoTotal", (long)tiempoTotal.TotalSeconds);
                    cmd.Parameters.AddWithValue("@fechaActual", fechaActual);
                    cmd.Parameters.AddWithValue("@idSesion", idSesion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public long obtenerTiempoTotalAcumulado(int idUs)
        {
            long total = 0;

            string query = "SELECT SUM(tiempoSesion) FROM sesionUs WHERE idUs = @idUs";

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idUs", idUs);
                conn.Open();

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    total = Convert.ToInt64(result);
                }
            }

            return total;
        }

        public int insertarNuevaSesionYObtenerID(int idUs)
        {
            int idSesion = 0;

            string query = "INSERT INTO sesionUs (fechaUltConex, fechaActual, tiempoSesion, tiempoTotal, idUs) " +
                           "OUTPUT INSERTED.idSesion " +
                           "VALUES (@fechaUltConex, @fechaActual, @tiempoSesion, @tiempoTotal, @idUs)";

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fechaUltConex", DateTime.Now);
                cmd.Parameters.AddWithValue("@fechaActual", DateTime.Now);
                cmd.Parameters.AddWithValue("@tiempoSesion", 0); // todavía no hay tiempo
                cmd.Parameters.AddWithValue("@tiempoTotal", 0);
                cmd.Parameters.AddWithValue("@idUs", idUs);

                conn.Open();
                idSesion = (int)cmd.ExecuteScalar(); // acá se recupera el ID generado
            }

            return idSesion;
        }

        public void mostrarDatos(DataGridView dgv, string comando)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = comando;
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable.
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comandoBaseDatos);
                DataTable tablaProductos = new DataTable();

                dataAdapter.Fill(tablaProductos);

                dgv.DataSource = tablaProductos;




            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Error");

            }
        }

    }
}
