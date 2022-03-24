using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Balances
{
    internal class CapaDatos
    {
        private SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cxc;Data Source=DESKTOP-VDTAR1V");

        public void InsertBalance(Balance balance)
        {
            try
            {
                conexion.Open();
                string query = @"
                                 Insert Into Balances (FechaCorte, AntigüedadPromedioSaldos, Monto)
                                 Values (@FechaCorte, @AntigüedadPromedioSaldos, @Monto) ";

                SqlParameter fechaCorte = new SqlParameter("@FechaCorte", balance.FechaCorte);
                SqlParameter antigüedadPromedioSaldos = new SqlParameter("@AntigüedadPromedioSaldos", balance.AntigüedadPromedioSaldos);
                SqlParameter monto = new SqlParameter("@Monto", balance.Monto);

                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.Add(fechaCorte);
                command.Parameters.Add(antigüedadPromedioSaldos);
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

        public void UpdateBalance(Balance balance)
        {
            try
            {
                conexion.Open();
                string query = @" Update Balances 
                                  Set FechaCorte = @FechaCorte,
                                      AntigüedadPromedioSaldos = @AntigüedadPromedioSaldos,
                                      Monto = @Monto
                                  Where IdentificadorCliente = @IdentificadorCliente ";

                SqlParameter identidicadorCliente = new SqlParameter("@IdentificadorCliente", balance.IdentificadorCliente);
                SqlParameter fechaCorte = new SqlParameter("@FechaCorte", balance.FechaCorte);
                SqlParameter antigüedadPromedioSaldos = new SqlParameter("@AntigüedadPromedioSaldos", balance.AntigüedadPromedioSaldos);
                SqlParameter monto = new SqlParameter("@Monto", balance.Monto);

                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.Add(identidicadorCliente);
                command.Parameters.Add(fechaCorte);
                command.Parameters.Add(antigüedadPromedioSaldos);
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

        public void DeleteBalance(int identificadorCliente)
        {
            try
            {
                conexion.Open();
                string query = @"Delete From Balances
                                 Where IdentificadorCliente = @IdentificadorCliente";

                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.Add(new SqlParameter("@IdentificadorCliente", identificadorCliente));

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

        public List<Balance> GetBalances(string search = null)
        {
            List<Balance> balances = new List<Balance>();

            try
            {
                conexion.Open();
                string query = @" Select IdentificadorCliente, FechaCorte, AntigüedadPromedioSaldos, Monto
                                  From Balances ";

                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(search))
                {
                    query += "Where IdentificadorCliente Like @search Or FechaCorte Like @search Or AntigüedadPromedioSaldos Like @search Or Monto Like @search ";

                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }

                command.CommandText = query;
                command.Connection = conexion;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    balances.Add(new Balance
                    {
                        IdentificadorCliente = int.Parse(reader["IdentificadorCliente"].ToString()),
                        FechaCorte = (DateTime)reader["FechaCorte"],
                        AntigüedadPromedioSaldos = reader["AntigüedadPromedioSaldos"].ToString(),
                        Monto = reader["Monto"].ToString()
                    });
                }

            }
            catch (Exception)
            {
                //throw;
            }
            finally 
            {
                conexion.Close();
            }
            return balances;
        }
    }
}
