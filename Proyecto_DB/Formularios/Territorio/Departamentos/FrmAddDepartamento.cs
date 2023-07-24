using DevExpress.XtraEditors;
using Proyecto_DB_DAO.Territorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_Db_EDM;
using System.Data.Entity;

namespace Proyecto_DB.Formularios.Territorio.Departamento
{
    public partial class FrmAddDepartamento : DevExpress.XtraEditors.XtraForm
    {
        private DepartamentoDAO ODepartamentoDAO = new DepartamentoDAO();
        private bool NuevoRegistro = false;
        public int id;
        private Departamento_Result ODepartamento = new Departamento_Result();
        public FrmAddDepartamento()
        {
            InitializeComponent();
            CargaInicial();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargaInicial()
        {
            if (id > 0)
            {
                ODepartamento = ODepartamentoDAO.GetDepartamentos(id)[0];
                txtDescripcion.Text = ODepartamento.Descripcion;
                txtCodigo.Text = ODepartamento.Codigo;
                txtCodigo.Enabled = false;
            }
        }
        private void Guardar()
        {
            if (NuevoRegistro == true && id == 0)
            {
                proyecto_Db_EDM.Departamento Departamento = new proyecto_Db_EDM.Departamento();
                Departamento.Codigo = txtCodigo.Text.Trim();
                Departamento.Descripcion = txtDescripcion.Text.Trim();

                if (ODepartamentoDAO.Agregar(Departamento) == false)
                {
                    MessageBox.Show("El nuevo registro no ha sido Grabado. ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("El nuevo Registro ha sido Grabado. ", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {

                proyecto_Db_EDM.Departamento ODepartamento = ODepartamentoDAO.Buscar(txtCodigo.Text.Trim());
                ODepartamento.Descripcion = txtDescripcion.Text.Trim();

                if (ODepartamentoDAO.Modificar(ODepartamento) == false)
                {
                    MessageBox.Show("El registro no fue modificado", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("El registro ha sido modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
        }
      
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            proyecto_Db_EDM.Departamento odepartamento;

            if (txtCodigo.Text.Trim().Length < 5)
            {
                MessageBox.Show("La longitud del codigo es de 5 caracreres ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;

            }

            odepartamento = ODepartamentoDAO.Buscar(txtCodigo.Text.Trim());

            if (odepartamento != null)
            {
                NuevoRegistro = false;
                txtDescripcion.Text = odepartamento.Descripcion.Trim();
                btnGuardar.Enabled = true;

            }
            else
            {
                NuevoRegistro = true;
                txtDescripcion.Text = "";
                btnGuardar.Enabled = true;
            }
        }

        private void FrmAddDepartamento_Load(object sender, EventArgs e)
        {

        }
    }
}