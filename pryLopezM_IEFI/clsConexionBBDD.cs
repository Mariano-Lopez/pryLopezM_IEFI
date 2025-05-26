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
using static System.Net.Mime.MediaTypeNames;

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
                    string permisos = fila[3].ToString();

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

        public void mostrarDatos(DataGridView dgv)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = "SELECT * FROM Usuarios";
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

        public void crearUsuario(TextBox txt, TextBox txt1, string per)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                conexionBaseDatos.Open();

                string query = @"INSERT INTO Usuarios 
                         (usuario, contraseña, permisos ) 
                         VALUES (@usuario, @contraseña, @permisos)";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                command.Parameters.AddWithValue("@usuario", txt.Text);
                command.Parameters.AddWithValue("@contraseña", txt1.Text);
                command.Parameters.AddWithValue("@permisos", per);
                

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error");
            }
        }

        public void actualizarDatosUs(TextBox txt, TextBox txt1, ComboBox cmb, int id)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                nombreBaseDeDatos = conexionBaseDatos.Database;
                conexionBaseDatos.Open();

                string query = "UPDATE Usuarios SET usuario = @usuario, contraseña = @contraseña, permisos = @permisos WHERE id = @id";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);



                // Asignar los parámetros
                command.Parameters.AddWithValue("@usuario", txt.Text);
                command.Parameters.AddWithValue("@contraseña", txt1.Text);
                command.Parameters.AddWithValue("@permisos", cmb.Text);
                command.Parameters.AddWithValue("@id", id);


                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }

        public void eliminarDatosUs(int id)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                nombreBaseDeDatos = conexionBaseDatos.Database;
                conexionBaseDatos.Open();

                string query = "DELETE FROM Usuarios WHERE id = @id";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                // Asignar los parámetros
                command.Parameters.AddWithValue("@id", id);


                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }

    }
}
