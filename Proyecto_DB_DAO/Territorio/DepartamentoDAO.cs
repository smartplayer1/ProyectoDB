using proyecto_Db_EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DB_DAO.Territorio
{
    public class DepartamentoDAO
    {
        ModelDBContainer db = new ModelDBContainer();
        public bool Agregar(Departamento oDepartamento)
        {
            db.Departamento.Add()
            return true;
        }

    }
}
