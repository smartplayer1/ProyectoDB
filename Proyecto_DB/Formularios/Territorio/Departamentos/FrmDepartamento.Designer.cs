
namespace Proyecto_DB.Formularios.Territorio
{
    partial class FrmDepartamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartamento));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.iGrid = new DevExpress.XtraGrid.GridControl();
            this.iView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.iGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iGrid
            // 
            this.iGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iGrid.Location = new System.Drawing.Point(0, 25);
            this.iGrid.MainView = this.iView;
            this.iGrid.Name = "iGrid";
            this.iGrid.Size = new System.Drawing.Size(468, 376);
            this.iGrid.TabIndex = 0;
            this.iGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.iView});
            // 
            // iView
            // 
            this.iView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.Descripcion});
            this.iView.GridControl = this.iGrid;
            this.iView.Name = "iView";
            this.iView.OptionsView.ShowGroupPanel = false;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.AllowEdit = false;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            this.Codigo.Width = 88;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.OptionsColumn.AllowEdit = false;
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 1;
            this.Descripcion.Width = 340;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.iGrid);
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions2.Image")));
            buttonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions3.Image")));
            buttonImageOptions3.SvgImageSize = new System.Drawing.Size(8, 8);
            this.groupControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Eliminar", false, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Editar", false, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Agregar", false, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.groupControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(468, 401);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl1_CustomButtonClick);
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // FrmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 401);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "FrmDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.FrmDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl iGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView iView;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}