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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public int idusuario = 0;
        private UsuarioDAO openUsuario = new UsuarioDAO();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            idusuario = openUsuario.Validar(txtUsuario.EditValue.ToString().Trim(), txtPassword.EditValue.ToString().Trim());
            if(idusuario > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos Invalidos");
                txtPassword.EditValue = "";
                txtUsuario.EditValue = "";
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (idusuario == 0)
            {
                Application.Exit();
            }
        }
    }
}