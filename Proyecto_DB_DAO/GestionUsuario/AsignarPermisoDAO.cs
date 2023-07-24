using proyecto_Db_EDM.GestionUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DB_DAO.GestionUsuario
{
   public class AsignarPermisoDAO
    {
        private AccesoContainer db = new AccesoContainer();
        public List<FuncionDeAcceso> ListarPermiso()
        {
            return db.FuncionDeAcceso.ToList();
        }
        public List<Usuario> ListarUsuario()
        {
            return db.Usuario.ToList();
        }
        public bool Agregar(FuncionAsignada funcionAsignada)
        {
            db.FuncionAsignada.Add(funcionAsignada);
            return (db.SaveChanges() > 0 ? true : false);
        }
    }
}
