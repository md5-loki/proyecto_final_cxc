using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_Documentos
{
    class DataAccessLayer
    {
        private SqlConnection cnn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cxc;Data Source=DESKTOP-VDTAR1V");


        #region CRUD

        #region Insertar

            public void InsertarTD(Tipo_Documento tipo_Documento)
             {
                try
                {
                    cnn.Open();
                    string query = @"
                                Insert into TB_Tipos_Documentos (Descripcion, Cuenta_Contable, Estado)
                                Values(@Descripcion, @CuentaContable, @Estado)";

                    SqlParameter Descripcion = new SqlParameter("@Descripcion", tipo_Documento.Descripcion);
                    SqlParameter Cuenta_Contable = new SqlParameter("@CuentaContable", tipo_Documento.Cuenta_Contable);
                    SqlParameter Estado = new SqlParameter("@Estado", tipo_Documento.Estado);

                    SqlCommand command = new SqlCommand(query, cnn);
                    command.Parameters.Add(Descripcion);
                    command.Parameters.Add(Cuenta_Contable);
                    command.Parameters.Add(Estado);

                    command.ExecuteNonQuery();

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    cnn.Close();
                }
             }

        #endregion

        #region Modificar
        public void ModificarTD(Tipo_Documento tipo_Documento)
        {
            try
            {
                cnn.Open();
                string query = @"
                                Update TB_Tipos_Documentos set Descripcion = @Descripcion, Cuenta_Contable = @CuentaContable, Estado = @Estado
                                    where ID = @IDTemp";

                SqlParameter IDTemp = new SqlParameter("@IDTemp", tipo_Documento.IDTemp);
                SqlParameter Descripcion = new SqlParameter("@Descripcion", tipo_Documento.Descripcion);
                SqlParameter Cuenta_Contable = new SqlParameter("@CuentaContable", tipo_Documento.Cuenta_Contable);
                SqlParameter Estado = new SqlParameter("@Estado", tipo_Documento.Estado);

                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.Add(IDTemp);
                command.Parameters.Add(Descripcion);
                command.Parameters.Add(Cuenta_Contable);
                command.Parameters.Add(Estado);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnn.Close();
            }
        }
        #endregion

        #region Borrar
        public void BorrarTD(Tipo_Documento tipo_Documento)
        {
            try
            {
                cnn.Open();
                string query = @"
                                Delete TB_Tipos_Documentos where ID = @IDTemp";

                SqlParameter IDTemp = new SqlParameter("@IDTemp", tipo_Documento.IDTemp);

                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.Add(IDTemp);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnn.Close();
            }
        }
        #endregion

        #endregion

        #region Llenar DataGridView 
        public List<Tipo_Documento> GetTipo_Documento(string search = null)
        {
            List<Tipo_Documento> tipo_Documentos = new List<Tipo_Documento>();
            try
            {

           
                cnn.Open();
                string query = @"
                              Select ID,Descripcion,Cuenta_Contable,Estado
                                From TB_Tipos_Documentos ";

                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(search))
                {
                    query += @"Where Descripcion Like @Search Or Cuenta_Contable Like @Search Or Estado Like @Search ";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%")); 
                }

                command.CommandText = query;
                command.Connection = cnn;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tipo_Documentos.Add(new Tipo_Documento
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        Descripcion = reader["Descripcion"].ToString(),
                        Cuenta_Contable = reader["Cuenta_Contable"].ToString(),
                        Estado = reader["Estado"].ToString(),
                    });
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cnn.Close();
            }
            return tipo_Documentos;


        }

        #endregion

       

    }
}
