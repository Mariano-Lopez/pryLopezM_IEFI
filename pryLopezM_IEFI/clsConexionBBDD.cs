using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;


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
                    TimeSpan horaDeAlta = TimeSpan.Parse(fila[12].ToString());
                    string permisos = fila[13].ToString();

                    clsUsuario aux = new clsUsuario(id, usuario, contra, nombre, apellido, edad, dni, direccion, telefono, email, fechaNacimiento, fechaDeAlta, horaDeAlta, permisos);

                    lst.lstUsuarios.Add(aux);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void cargarCombo(ComboBox cmb, string tabla)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = $"SELECT * FROM {tabla}";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable.
                DataTable tablaProductos = new DataTable();

                //Llenar el DataTable.
                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    tablaProductos.Load(reader);
                }

                cmb.Items.Clear();

                foreach (DataRow fila in tablaProductos.Rows)
                {
                    cmb.Items.Add(fila[1].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cargar combo");

            }
        }

        public void agregarDatoCombo(string tabla, string dato)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                nombreBaseDeDatos = conexionBaseDatos.Database;
                conexionBaseDatos.Open();

                string query = $"INSERT INTO {tabla} (opcion) VALUES (@opcion)";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                // Asignar los parámetros
                command.Parameters.AddWithValue("@opcion", dato);


                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void eliminarDatoCombo(string tabla, string dato)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                nombreBaseDeDatos = conexionBaseDatos.Database;
                conexionBaseDatos.Open();

                string query = $"DELETE FROM {tabla} WHERE opcion = @opcion";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                // Asignar los parámetros
                command.Parameters.AddWithValue("@opcion", dato);


                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void actualizarSesion(int idSesion, TimeSpan tiempoSesion, TimeSpan tiempoTotal, DateTime fechaActual)
        {
            string query = "UPDATE sesionUsuario SET tiempoSesion = @tiempoSesion, tiempoTotal = @tiempoTotal, fechaActual = @fechaActual WHERE idSesion = @idSesion";

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TiempoSesion", tiempoSesion.ToString(@"hh\:mm\:ss"));
                    cmd.Parameters.AddWithValue("@TiempoTotal", tiempoTotal.ToString(@"hh\:mm\:ss"));
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

            string query = @"SELECT SUM(DATEDIFF(SECOND, 0, tiempoSesion)) 
                     FROM sesionUsuario 
                     WHERE idUsuarioSesion = @idUsuarioSesion";

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idUsuarioSesion", idUs);
                conn.Open();

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    total = Convert.ToInt64(result); // Total en segundos
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
                cmd.Parameters.AddWithValue("@tiempoSesion", TimeSpan.Zero);
                cmd.Parameters.AddWithValue("@tiempoTotal", TimeSpan.Zero);
                cmd.Parameters.AddWithValue("@idUsuarioSesion", idUs);

                conn.Open();
                idSesion = (int)cmd.ExecuteScalar(); // Devuelve el ID generado automáticamente
            }

            return idSesion;
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
                DataTable tablaUsuario = new DataTable();


                dataAdapter.Fill(tablaUsuario);

                dgv.AllowUserToOrderColumns = false;

                tablaUsuario.Columns["idUsuario"].ColumnName = "N°ID";
                tablaUsuario.Columns["fechaDeNacimiento"].ColumnName = "Fecha de nacimiento";
                tablaUsuario.Columns["fechaDeAlta"].ColumnName = "Fecha de alta";
                tablaUsuario.Columns["horaDeAlta"].ColumnName = "Hora de alta";

                dgv.DataSource = tablaUsuario;

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");

            }
        }

        public void crearUsuario(TextBox txt, TextBox txt1, TextBox txt2, TextBox txt3, int edad,
            TextBox txt5, TextBox txt6, TextBox txt7, TextBox txt8, DateTime dtN, DateTime dtA, ComboBox cmb)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                conexionBaseDatos.Open();



                string query = @"INSERT INTO Usuarios 
                         (usuario, contraseña, nombre, apellido, edad, DNI, direccion, telefono, email, fechaDeNacimiento, fechaDeAlta, permisos ) 
                         VALUES (@usuario, @contraseña, @nombre, @apellido, @edad, @DNI, @direccion, @telefono, @email, @fechaDeNacimiento, @fechaDeAlta, @permisos)";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                
                command.Parameters.AddWithValue("@usuario", txt.Text);
                command.Parameters.AddWithValue("@contraseña", txt1.Text);
                command.Parameters.AddWithValue("@nombre", txt2.Text);
                command.Parameters.AddWithValue("@apellido", txt3.Text);
                command.Parameters.AddWithValue("@edad", edad);
                command.Parameters.AddWithValue("@DNI", txt5.Text);
                command.Parameters.AddWithValue("@direccion", txt6.Text);
                command.Parameters.AddWithValue("@telefono", txt7.Text);
                command.Parameters.AddWithValue("@email", txt8.Text);
                command.Parameters.AddWithValue("@fechaDeNacimiento", dtN);
                command.Parameters.AddWithValue("@fechaDeAlta", dtA);
                command.Parameters.AddWithValue("@permisos", cmb.Text);
                
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error");
            }
        }

        public void actualizarDatosUsuario(int id, TextBox txt, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4,
            TextBox txt5, TextBox txt6, TextBox txt7, TextBox txt8, DateTime dtP, ComboBox cmb)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                nombreBaseDeDatos = conexionBaseDatos.Database;
                conexionBaseDatos.Open();

                string query = @"UPDATE Usuarios SET usuario = @usuario, contraseña = @contraseña, 
                    nombre = @nombre, apellido = @apellido,  edad = @edad, DNI = @dni, direccion = @direccion,  telefono = @telefono,
                    email = @email,  fechaDeNacimiento = @fechaDeNacimiento,
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
                command.Parameters.AddWithValue("@fechaDeNacimiento", dtP);
                command.Parameters.AddWithValue("@permisos", cmb.Text);
                command.Parameters.AddWithValue("@idUsuario", id);


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

        public void eliminarDatosUsusario(int id)
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

        public void registrarAcciones(string evento, string desc, int id, DateTime fecha)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                nombreBaseDeDatos = conexionBaseDatos.Database;
                conexionBaseDatos.Open();

                


                string query = @"INSERT INTO accionRealizada (evento, descripcion, fechaDeAccion, idUsuarioAccion) VALUES (@evento,
                                @descripcion, @fechaDeAccion, @idUsuarioAccion)";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                // Asignar los parámetros
                command.Parameters.AddWithValue("@evento", evento);
                command.Parameters.AddWithValue("@descripcion", desc);
                command.Parameters.AddWithValue("@fechaDeAccion", fecha);
                command.Parameters.AddWithValue("@idUsuarioAccion", id);


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void datosAuditoriaAcciones(DataGridView dgv)
        {

            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = "SELECT * FROM accionRealizada";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable.
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comandoBaseDatos);
                DataTable tablaUsuario = new DataTable();

                dataAdapter.Fill(tablaUsuario);

                dgv.AllowUserToOrderColumns = false;

                tablaUsuario.Columns["idAccionRealizada"].ColumnName = "N°ID";
                tablaUsuario.Columns["evento"].ColumnName = "Evento";
                tablaUsuario.Columns["descripcion"].ColumnName = "Descripción";
                tablaUsuario.Columns["fechaDeAccion"].ColumnName = "Fecha";
                tablaUsuario.Columns["horaDeAccion"].ColumnName = "Hora";
                tablaUsuario.Columns["idUsuarioAccion"].ColumnName = "ID usuario";

                dgv.DataSource = tablaUsuario;

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");

            }
        }

        public void datosAuditoriaSesiones(DataGridView dgv)
        {

            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = "SELECT * FROM sesionUsuario";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable.
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comandoBaseDatos);
                DataTable tablaUsuario = new DataTable();

                dataAdapter.Fill(tablaUsuario);

                dgv.AllowUserToOrderColumns = false;

                tablaUsuario.Columns["idSesion"].ColumnName = "N° sesión";
                tablaUsuario.Columns["fechaUltConeccion"].ColumnName = "Fecha última conección";
                tablaUsuario.Columns["horaUltConeccion"].ColumnName = "Hora de última conección";
                tablaUsuario.Columns["fechaActual"].ColumnName = "Fecha actual";
                tablaUsuario.Columns["horaActual"].ColumnName = "Hora actual";
                tablaUsuario.Columns["tiempoSesion"].ColumnName = "Tiempo de sesión";
                tablaUsuario.Columns["tiempoTotal"].ColumnName = "Tiempo total";
                tablaUsuario.Columns["idUsuarioSesion"].ColumnName = "ID usuario";

                dgv.DataSource = tablaUsuario;

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");

            }
        }

        public void datosAuditoriaId(int id, DataGridView dgv, string tabla, string campo)
        {
            try
            {
                using (SqlConnection conexionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    conexionBaseDatos.Open();

                    string query = $@"SELECT * FROM {tabla} WHERE {campo} = @{campo}";

                    using (SqlCommand command = new SqlCommand(query, conexionBaseDatos))
                    {
                        command.Parameters.AddWithValue($"@{campo}", id);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable tablaSesion = new DataTable();

                        dataAdapter.Fill(tablaSesion);

                        dgv.AllowUserToOrderColumns = false;
                        dgv.DataSource = tablaSesion;

                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public void datosAuditoriaFecha(string fecha, DataGridView dgv, string tabla, string campo)
        {
            try
            {
                using (SqlConnection conexionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    conexionBaseDatos.Open();

                    string query = $@"SELECT * FROM {tabla} WHERE {campo} = @{campo}";

                    using (SqlCommand command = new SqlCommand(query, conexionBaseDatos))
                    {
                        command.Parameters.AddWithValue($"@{campo}", fecha);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable tablaSesion = new DataTable();

                        dataAdapter.Fill(tablaSesion);

                        dgv.AllowUserToOrderColumns = false;
                        dgv.DataSource = tablaSesion;

                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public void datosAuditoriaIdFecha(int id, string fecha, DataGridView dgv, string tabla, string campo, string campo2)
        {
            try
            {
                using (SqlConnection conexionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    conexionBaseDatos.Open();

                    string query = $@"SELECT * FROM {tabla} WHERE {campo} = @{campo} AND {campo2} = @{campo2}";

                    using (SqlCommand command = new SqlCommand(query, conexionBaseDatos))
                    {
                        command.Parameters.AddWithValue($"@{campo}", fecha);
                        command.Parameters.AddWithValue($"@{campo2}", id);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable tablaSesion = new DataTable();

                        dataAdapter.Fill(tablaSesion);


                        dgv.AllowUserToOrderColumns = false;
                        dgv.DataSource = tablaSesion;

                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public void mostrarDatosTarea(DataGridView dgv)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = @"SELECT * FROM registrarTarea";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable.
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comandoBaseDatos);
                DataTable tablaUsuario = new DataTable();

                dataAdapter.Fill(tablaUsuario);

                dgv.AllowUserToOrderColumns = false;

                dgv.DataSource = tablaUsuario;

                tablaUsuario.Columns["idTarea"].ColumnName = "ID Tarea";
                tablaUsuario.Columns["fechaTarea"].ColumnName = "Fecha de tarea";
                tablaUsuario.Columns["tareaPrincipal"].ColumnName = "Tarea principal";
                tablaUsuario.Columns["lugarTarea"].ColumnName = "Lugar";
                tablaUsuario.Columns["detalle"].ColumnName = "Detalle";
                tablaUsuario.Columns["comentario"].ColumnName = "Comentario";
                tablaUsuario.Columns["fechaRegistro"].ColumnName = "Fecha registro";
                tablaUsuario.Columns["horaTareaRegistrada"].ColumnName = "Hora registro";
                tablaUsuario.Columns["idUsuarioTarea"].ColumnName = "ID usuario";
                

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");

            }
        }

        public void registrarTarea(DateTime fecha, string tarea, string lugar, TimeSpan hora, int idUsuario, string comentario, string Detalle, DateTime fechaC)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                nombreBaseDeDatos = conexionBaseDatos.Database;
                conexionBaseDatos.Open();




                string query = @"INSERT INTO registrarTarea (fechaTarea, tareaPrincipal, lugarTarea, detalle, comentario, fechaRegistro, horaTareaRegistrada, idUsuarioTarea) VALUES (@fechaTarea, @tareaPrincipal,
                                   @lugarTarea, @detalle, @comentario, @fechaRegistro, @horaTareaRegistrada, @idUsuarioTarea)";

                SqlCommand command = new SqlCommand(query, conexionBaseDatos);

                // Asignar los parámetros
                command.Parameters.AddWithValue("@fechaTarea", fecha);
                command.Parameters.AddWithValue("@tareaPrincipal", tarea);
                command.Parameters.AddWithValue("@lugarTarea", lugar);
                command.Parameters.AddWithValue("@detalle", Detalle);
                command.Parameters.AddWithValue("@comentario", comentario);
                command.Parameters.AddWithValue("@fechaRegistro", fechaC);
                command.Parameters.AddWithValue("@horaTareaRegistrada", hora);
                command.Parameters.AddWithValue("@idUsuarioTarea", idUsuario);


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void filtrarTareaPorDato(DataGridView dgv, string dato, string campo)
        {
            try
            {
                using (SqlConnection conexionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    conexionBaseDatos.Open();

                    string query = $@"SELECT * FROM registrarTarea WHERE {campo} = @{campo}";

                    using (SqlCommand command = new SqlCommand(query, conexionBaseDatos))
                    {
                        command.Parameters.AddWithValue($"@{campo}", dato);


                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable tablaSesion = new DataTable();

                        dataAdapter.Fill(tablaSesion);


                        dgv.AllowUserToOrderColumns = false;
                        dgv.DataSource = tablaSesion;

                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public void filtrarTareaPorDato(DataGridView dgv, int dato)
        {
            try
            {
                using (SqlConnection conexionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    conexionBaseDatos.Open();

                    string query = $@"SELECT * FROM registrarTarea WHERE idUsuarioTarea = @idUsuarioTarea";

                    using (SqlCommand command = new SqlCommand(query, conexionBaseDatos))
                    {
                        command.Parameters.AddWithValue("@idUsuarioTarea", dato);


                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable tablaSesion = new DataTable();

                        dataAdapter.Fill(tablaSesion);


                        dgv.AllowUserToOrderColumns = false;
                        dgv.DataSource = tablaSesion;

                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public void filtrarTareaPorDato(string dato, string campo, DataGridView dgv)
        {
            try
            {
                using (SqlConnection conexionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    conexionBaseDatos.Open();

                    string query = $@"SELECT * FROM registrarTarea WHERE {campo} LIKE @valor";

                    using (SqlCommand command = new SqlCommand(query, conexionBaseDatos))
                    {
                        command.Parameters.AddWithValue("@valor", $"%{dato}%");


                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable tablaSesion = new DataTable();

                        dataAdapter.Fill(tablaSesion);


                        dgv.AllowUserToOrderColumns = false;
                        dgv.DataSource = tablaSesion;

                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }



    }
}
