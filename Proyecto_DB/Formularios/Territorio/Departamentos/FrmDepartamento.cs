using Proyecto_DB.Formularios.Territorio.Departamento;
using Proyecto_DB_DAO.Territorio;
using System;
using System.Windows.Forms;

namespace Proyecto_DB.Formularios.Territorio
{

    public partial class FrmDepartamento : DevExpress.XtraEditors.XtraForm
    {
        private DepartamentoDAO ODepartamentoDAO = new DepartamentoDAO();
        public FrmDepartamento()
        {
            InitializeComponent();
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            iGrid.DataSource = ODepartamentoDAO.GetDepartamentos(0);
        }

        private void groupControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
        private void Nuevo()
        {
            FrmAddDepartamento frmdep = new FrmAddDepartamento();
            frmdep.ShowDialog();
        }
        private void Editar()
        {
                FrmAddDepartamento frmdep = new FrmAddDepartamento();
                frmdep.id = Convert.ToInt32(iView.GetFocusedRowCellValue("Id"));
                frmdep.ShowDialog();
        }
        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption) {
                case "Editar":
                    Editar();
                    Cargar();
                    break;
                case "Agregar":
                    Nuevo();
                    Cargar();
                    break;
                case "Eliminar":
                    
                    break;
            }
        }
    }
}