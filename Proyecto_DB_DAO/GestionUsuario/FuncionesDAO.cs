using proyecto_Db_EDM.GestionUsuario;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DB_DAO.GestionUsuario
{
  public  class FuncionesDAO
    {
        private AccesoContainer db = new AccesoContainer();
        public FuncionDeAcceso Buscar(string pCodigo)
        {
            return db.FuncionDeAcceso.DefaultIfEmpty(null).FirstOrDefault(f => f.Codigo.Trim() == pCodigo.Trim());
        }
        public bool Agregar(string pCodigo, string pDescripcion)
        {
            FuncionDeAcceso oFuncion = new FuncionDeAcceso();
            oFuncion.Codigo = pCodigo.Trim();
            oFuncion.Descripcion = pDescripcion.Trim();
            db.FuncionDeAcceso.Add(oFuncion);

            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(string pCodigo, string pDescripcion)
        {
            FuncionDeAcceso oFuncion = Buscar(pCodigo);
            oFuncion.Descripcion = pDescripcion.Trim();
            db.Entry(oFuncion).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Eliminar(string pCodigo, string pDescripcion)
        {
            FuncionDeAcceso oFuncion = Buscar(pCodigo);
            if(oFuncion == null)
            {
                return false;
            }
            db.FuncionDeAcceso.Remove(oFuncion);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public List<FuncionDeAcceso> Listar()
        {
            return db.FuncionDeAcceso.ToList();
        }

    }
}
