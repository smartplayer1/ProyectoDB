using proyecto_Db_EDM;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Proyecto_DB_DAO.Territorio
{
    public class DepartamentoDAO
    {
        ModelDBContainer db = new ModelDBContainer();
        public bool Agregar(Departamento oDepartamento)
        {
            db.Departamento.Add(oDepartamento);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(Departamento ODepartameno)
        {
            db.Entry(ODepartameno).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Eliminar(Departamento ODepartamento)
        {
            db.Departamento.Remove(ODepartamento);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Departamento Buscar(string Codigo)
        {
            Departamento ODepartamento;
            ODepartamento = db.Departamento.DefaultIfEmpty(null).FirstOrDefault(D => D.Codigo.Trim() == Codigo.Trim());
            return (ODepartamento);
        }

        public List<Departamento_Result> GetDepartamentos(int id)
        {
            return db.sp_sel_Departamento(id).ToList();

        }
    }
}
