using DevExpress.XtraEditors;
using Proyecto_DB_DAO.GestionUsuario;
using proyecto_Db_EDM.GestionUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DB.Formularios.GestionUsuario
{
    public partial class FrmPermisosUsuarios : DevExpress.XtraEditors.XtraForm
    {
       private AsignarPermisoDAO funsionAsignadaDAO = new AsignarPermisoDAO();
        public FrmPermisosUsuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FuncionAsignada oFuncionAsignada = new FuncionAsignada();
            oFuncionAsignada.UsuarioId = (int)cbUsuario.EditValue;
            oFuncionAsignada.FuncionDeAccesoId = (int)cbPermiso.EditValue;
            oFuncionAsignada.FechaVencimiento = (DateTime)dtpFecha.EditValue;

            if(funsionAsignadaDAO.Agregar(oFuncionAsignada) == false)
            {
                MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El nuevo registro fue grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmPermisosUsuarios_Load(object sender, EventArgs e)
        {
            cbUsuario.Properties.DataSource = funsionAsignadaDAO.ListarUsuario();
            cbPermiso.Properties.DataSource = funsionAsignadaDAO.ListarPermiso();
            dtpFecha.EditValue = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}