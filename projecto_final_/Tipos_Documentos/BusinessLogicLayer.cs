using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipos_Documentos
{
    class BusinessLogicLayer
    {

        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }

        #region CRUD Metodos

        public Tipo_Documento GuardarTD (Tipo_Documento tipo_Documento)
        {
            if(tipo_Documento.ID == 0)
            {
                _dataAccessLayer.InsertarTD(tipo_Documento);
            }
            else
            {
                MessageBox.Show("Registro que intenta agregar ya existe");
            }
            return tipo_Documento;
        }

        public Tipo_Documento ModificarTD(Tipo_Documento tipo_Documento)
        {
            _dataAccessLayer.ModificarTD(tipo_Documento);
            return tipo_Documento;
        }


        public Tipo_Documento BorrarTD(Tipo_Documento tipo_Documento)
        {
            _dataAccessLayer.BorrarTD(tipo_Documento);
            return tipo_Documento;
        }

        #endregion

        #region Cargar Datos En DataGridView
        public List<Tipo_Documento> GetTipo_Documento(string searchText = null)
        {
            return _dataAccessLayer.GetTipo_Documento(searchText);
        }

        #endregion
    }
}
