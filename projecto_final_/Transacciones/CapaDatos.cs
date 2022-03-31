using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Transacciones
{
    internal class CapaDatos
    {
        private SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cxc;Data Source=DESKTOP-VDTAR1V");

        public void InsertTransaccion(Transaccion transaccion)
        {
            try
            {
                conexion.Open();
                string query = @"
                                 Insert Into Transacciones (TipoMovimiento, IdentificadorTipoDocumento, NumeroDocumento, Fecha, IdentificadorCliente, Monto)
                                 Values (@TipoMovimiento, @IdentificadorTipoDocumento, @NumeroDocumento, @Fecha, @IdentificadorCliente, @Monto) ";

                SqlParameter tipoMovimiento = new SqlParameter("@TipoMovimiento", transaccion.TipoMovimiento);
                SqlParameter identificadorTipoDocumento = new SqlParameter("@IdentificadorTipoDocumento", transaccion.IdentificadorTipoDocumento);
                SqlParameter numeroDocumento = new SqlParameter("@NumeroDocumento", transaccion.NumeroDocumento);
                SqlParameter fecha = new SqlParameter("@Fecha", transaccion.Fecha);
                SqlParameter identificadorCliente = new SqlParameter("@IdentificadorCliente", transaccion.IdentificadorCliente);
                SqlParameter monto = new SqlParameter("@Monto", transaccion.Monto);

                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.Add(tipoMovimiento);
                command.Parameters.Add(identificadorTipoDocumento);
                command.Parameters.Add(numeroDocumento);
                command.Parameters.Add(fecha);
                command.Parameters.Add(identificadorCliente);
                command.Parameters.Add(monto);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public void UpdateTransaccion(Transaccion transaccion)
        {
            try
            {
                conexion.Open();
                string query = @" Update Transacciones 
                                  Set TipoMovimiento = @TipoMovimiento,
                                      IdentificadorTipoDocumento = @IdentificadorTipoDocumento,
                                      NumeroDocumento = @NumeroDocumento,
                                      Fecha = @Fecha,
                                      IdentificadorCliente = @IdentificadorCliente,
                                      Monto = @Monto
                                  Where IdentificadorTransaccion = @IdentificadorTransaccion ";

                SqlParameter identificadorTransaccion = new SqlParameter("@IdentificadorTransaccion", transaccion.IdentificadorTransaccion);
                SqlParameter tipoMovimiento = new SqlParameter("@TipoMovimiento", transaccion.TipoMovimiento);
                SqlParameter identificadorTipoDocumento = new SqlParameter("@IdentificadorTipoDocumento", transaccion.IdentificadorTipoDocumento);
                SqlParameter numeroDocumento = new SqlParameter("@NumeroDocumento", transaccion.NumeroDocumento);
                SqlParameter fecha = new SqlParameter("@Fecha", transaccion.Fecha);
                SqlParameter identificadorCliente = new SqlParameter("@IdentificadorCliente", transaccion.IdentificadorCliente);
                SqlParameter monto = new SqlParameter("@Monto", transaccion.Monto);

                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.Add(identificadorTransaccion);
                command.Parameters.Add(tipoMovimiento);
                command.Parameters.Add(identificadorTipoDocumento);
                command.Parameters.Add(numeroDocumento);
                command.Parameters.Add(fecha);
                command.Parameters.Add(identificadorCliente);
                command.Parameters.Add(monto);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void DeleteTransaccion(int identificadorTransaccion)
        {
            try
            {
                conexion.Open();
                string query = @"Delete From Transacciones
                                 Where IdentificadorTransaccion = @IdentificadorTransaccion";

                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.Add(new SqlParameter("@IdentificadorTransaccion", identificadorTransaccion));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Transaccion> GetTransacciones(string search = null)
        {
            List<Transaccion> transacciones = new List<Transaccion>();

            try
            {
                conexion.Open();
                string query = @" Select IdentificadorTransaccion, TipoMovimiento, IdentificadorTipoDocumento, NumeroDocumento, Fecha, IdentificadorCliente, Monto
                                  From Transacciones ";

                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(search))
                {
                    query += "Where IdentificadorTransaccion Like @search Or TipoMovimiento Like @search Or IdentificadorTipoDocumento Like @search Or NumeroDocumento Like @search Or Fecha Like @search Or IdentificadorCliente Like @search Or Monto Like @search";

                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }

                command.CommandText = query;
                command.Connection = conexion;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    transacciones.Add(new Transaccion
                    {
                        IdentificadorTransaccion = int.Parse(reader["IdentificadorTransaccion"].ToString()),
                        TipoMovimiento = reader["TipoMovimiento"].ToString(),
                        IdentificadorTipoDocumento = reader["IdentificadorTipoDocumento"].ToString(),
                        NumeroDocumento = reader["NumeroDocumento"].ToString(),
                        Fecha = (DateTime)reader["Fecha"],
                        IdentificadorCliente = reader["IdentificadorCliente"].ToString(),
                        Monto = reader["Monto"].ToString()
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return transacciones;
        }
    }
}
