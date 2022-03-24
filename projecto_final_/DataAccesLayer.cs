using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto_final_
{
    class DataAccesLayer
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cxc;Data Source=DESKTOP-VDTAR1V");
    
        public void insertCliente(Cliente cliente)
        {
            try
            {
                conn.Open();

                string query = @" insert into Clientes_ (nombres, cedula, limite_credito, estado) 
                                values (@nombres, @cedula, @limite_credito, @estado)";

                SqlParameter nombres = new SqlParameter("@nombres", cliente.nombres);
                SqlParameter cedula = new SqlParameter("@cedula", cliente.cedula);
                SqlParameter limite_credito = new SqlParameter("@limite_credito", cliente.limite_credito);
                SqlParameter estado = new SqlParameter("@estado", cliente.estado);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(nombres);
                command.Parameters.Add(cedula);
                command.Parameters.Add(limite_credito);
                command.Parameters.Add(estado);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Cliente> getClientes(string busqueda = null)
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                conn.Open();
                string query = @"select * from Clientes_";
                SqlCommand command = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(busqueda))
                {
                    query += " where nombres LIKE @busqueda OR cedula LIKE @busqueda OR limite_credito LIKE @busqueda OR estado LIKE @busqueda";
                    command.Parameters.Add(new SqlParameter("@busqueda", $"%{busqueda}%"));
                }

                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientes.Add(new Cliente 
                    {
                        id = Convert.ToInt32(reader["id"].ToString()),
                        nombres = reader["nombres"].ToString(),
                        cedula = reader["cedula"].ToString(),
                        limite_credito = Convert.ToInt32(reader["limite_credito"].ToString()),
                        estado = reader["estado"].ToString()
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return clientes;
        }

        public void editCliente(Cliente cliente)
        {
            try
            {
                conn.Open();
                string query = @"update Clientes_ set nombres = @nombres, cedula = @cedula, limite_credito = @limite_credito, estado = @estado where id = @id";

                SqlParameter id = new SqlParameter("@id", cliente.id);
                SqlParameter nombres = new SqlParameter("@nombres", cliente.nombres);
                SqlParameter cedula = new SqlParameter("@cedula", cliente.cedula);
                SqlParameter limite_credito = new SqlParameter("@limite_credito", cliente.limite_credito);
                SqlParameter estado = new SqlParameter("@estado", cliente.estado);

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(id);
                command.Parameters.Add(nombres);
                command.Parameters.Add(cedula);
                command.Parameters.Add(limite_credito);
                command.Parameters.Add(estado);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void delCliente(int id)
        {
            try
            {
                conn.Open();
                string query = @"delete from Clientes_ where id = @id";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(new SqlParameter("@id", id));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
