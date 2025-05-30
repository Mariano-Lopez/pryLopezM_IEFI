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
                    string nombre = fila[3].ToString();
                    string apellido = fila[4].ToString();
                    int edad = Convert.ToInt32(fila[5]);
                    string dni = fila[6].ToString();
                    string direccion = fila[7].ToString();
                    string telefono = fila[8].ToString();
                    string email = fila[9].ToString();
                    DateTime fechaNacimiento = Convert.ToDateTime(fila[10].ToString());
                    DateTime fechaDeAlta = Convert.ToDateTime(fila[11].ToString());
                    string permisos = fila[12].ToString();

                    clsUsuario aux = new clsUsuario(id, usuario, contra, nombre, apellido, edad, dni, direccion, telefono, email, fechaNacimiento, fechaDeAlta, permisos);

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
            string query = "UPDATE sesionUsuario SET tiempoSesion = @tiempoSesion, tiempoTotal = @tiempoTotal, fechaActual = @fechaActual WHERE idSesion = @idSesion";

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TiempoSesion", (long)tiempoSesion.TotalSeconds);
                    cmd.Parameters.AddWithValue("@TiempoTotal", (long)tiempoTotal.TotalSeconds);
                    cmd.Parameters.AddWithValue("@FechaActual", fechaActual);
                    cmd.Parameters.AddWithValue("@IdSesion", idSesion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }



        public long obtenerTiempoTotalAcumulado(int idUs)
        {
            long total = 0;

            string query = "SELECT SUM(tiempoSesion) FROM sesionUsuario WHERE idUsuarioSesion = @idUsuarioSesion";

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idUsuarioSesion", idUs);
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

            string query = @"INSERT INTO sesionUsuario (fechaUltConeccion, fechaActual, tiempoSesion, tiempoTotal, idUsuarioSesion)
                            OUTPUT INSERTED.idSesion 
                            VALUES (@fechaUltConeccion, @fechaActual, @tiempoSesion, @tiempoTotal, @idUsuarioSesion)";

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fechaUltConeccion", DateTime.Now);
                cmd.Parameters.AddWithValue("@fechaActual", DateTime.Now);
                cmd.Parameters.AddWithValue("@tiempoSesion", 0); // todavía no hay tiempo
                cmd.Parameters.AddWithValue("@tiempoTotal", 0);
                cmd.Parameters.AddWithValue("@idUsuarioSesion", idUs);

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

        public void crearUsuario(TextBox txt2,TextBox txt, TextBox txt1, string per)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                conexionBaseDatos.Open();

                string query = @"INSERT INTO Usuarios 
                         (id, usuario, contraseña, permisos ) 
                         VALUES (@id, @usuario, @contraseña, @permisos)";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                command.Parameters.AddWithValue("@id", txt2.Text);
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

        public void actualizarDatosUs(int id, TextBox txt, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4,
            TextBox txt5, TextBox txt6, TextBox txt7, TextBox txt8, DateTimePicker dtP, ComboBox cmb)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                nombreBaseDeDatos = conexionBaseDatos.Database;
                conexionBaseDatos.Open();

                string query = @"UPDATE Usuarios SET usuario = @usuario, contraseña = @contraseña, 
                    nombre = @nombre, apellido = @apellido,  edad = @edad,  direccion = @direccion,  telefono = @telefono,
                    email = @email,  fechaNacimiento = @fechaNacimiento,
                    permisos = @permisos WHERE idUsuario = @idUsuario";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);



                // Asignar los parámetros
                command.Parameters.AddWithValue("@usuario", txt.Text);
                command.Parameters.AddWithValue("@contraseña", txt1.Text);
                command.Parameters.AddWithValue("@nombre", txt2.Text);
                command.Parameters.AddWithValue("@apellido", txt3.Text);
                command.Parameters.AddWithValue("@edad", txt4.Text);
                command.Parameters.AddWithValue("@dni", txt5.Text);
                command.Parameters.AddWithValue("@direccion", txt6.Text);
                command.Parameters.AddWithValue("@telefono", txt7.Text);
                command.Parameters.AddWithValue("@email", txt8.Text);
                command.Parameters.AddWithValue("@fechaNacimiento", dtP.Value);
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

                string query = "DELETE FROM Usuarios WHERE idUsuario = @idUsuario";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                // Asignar los parámetros
                command.Parameters.AddWithValue("@idUsuario", id);


                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }

    }
}
