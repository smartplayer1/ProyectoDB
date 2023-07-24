using DevExpress.XtraBars;
using Proyecto_DB.Formularios.GestionUsuario;
using Proyecto_DB.Formularios.Territorio;

namespace Proyecto_DB
{
    public partial class FrmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int idusuario = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDepartamento frmdep = new FrmDepartamento();
            frmdep.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, System.EventArgs e)
        {
            var ofrm = new FrmLogin();
            ofrm.ShowDialog();
            ofrm.Dispose();
           
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ofrm = new FrmFunciones();
            ofrm.ShowDialog();
            ofrm.Dispose(); 
        }

        private void btnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ofrm = new FrmUsuario();
            ofrm.ShowDialog();
            ofrm.Dispose();
        }

        private void btnPermiso_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ofrm = new FrmPermisosUsuarios();
            ofrm.ShowDialog();
            ofrm.Dispose();
        }
    }
}