using DevExpress.XtraEditors;
using Proyecto_DB_DAO.GestionUsuario;
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
    public partial class FrmUsuario : DevExpress.XtraEditors.XtraForm
    {
        private UsuarioDAO ope = new UsuarioDAO();
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ope.Agregar(txtUsuario.EditValue.ToString(), txtClave.EditValue.ToString())== false)
            {
                MessageBox.Show("Operacion Invalida");
            }
            txtClave.EditValue = "";
            txtUsuario.EditValue = "";
            txtUsuario.Focus();
        }

        private void FrmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 27)
            {
                this.Close();
            }
        }
    }
}