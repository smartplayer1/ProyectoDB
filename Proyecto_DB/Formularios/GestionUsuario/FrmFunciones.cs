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
    public partial class FrmFunciones : DevExpress.XtraEditors.XtraForm
    {
        private FuncionesDAO ope = new FuncionesDAO();
        public FrmFunciones()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ope.Buscar(txtCodigo.EditValue.ToString()) == null)
            {
                if (ope.Agregar(txtCodigo.EditValue.ToString(), txtDescripcion.EditValue.ToString()) == false)
                {
                    MessageBox.Show("Operacion Invalida");
                }
            }else
            {
                if(ope.Modificar(txtCodigo.EditValue.ToString(), txtDescripcion.EditValue.ToString()) == false)
                {
                    MessageBox.Show("Operacion Invalida");
                }
            }
            txtCodigo.EditValue = "";
            txtDescripcion.EditValue = "";
            txtCodigo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            FuncionDeAcceso oFuncion = ope.Buscar(txtCodigo.EditValue.ToString());
            if (oFuncion == null)
            {
                txtDescripcion.EditValue = "";
            }
            else
            {
                txtDescripcion.EditValue = oFuncion.Descripcion.Trim();
            }

        }
    }
}