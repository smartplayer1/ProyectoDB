
namespace Proyecto_DB.Formularios.GestionUsuario
{
    partial class FrmPermisosUsuarios
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
            this.cbUsuario = new DevExpress.XtraEditors.LookUpEdit();
            this.cbPermiso = new DevExpress.XtraEditors.LookUpEdit();
            this.dtpFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPermiso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUsuario
            // 
            this.cbUsuario.Location = new System.Drawing.Point(146, 90);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsuario.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreDeUsuario", "")});
            this.cbUsuario.Properties.DisplayMember = "NombreDeUsuario";
            this.cbUsuario.Properties.ValueMember = "Id";
            this.cbUsuario.Size = new System.Drawing.Size(151, 20);
            this.cbUsuario.TabIndex = 0;
            // 
            // cbPermiso
            // 
            this.cbPermiso.Location = new System.Drawing.Point(146, 127);
            this.cbPermiso.Name = "cbPermiso";
            this.cbPermiso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPermiso.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "")});
            this.cbPermiso.Properties.DisplayMember = "Descripcion";
            this.cbPermiso.Properties.ValueMember = "Id";
            this.cbPermiso.Size = new System.Drawing.Size(151, 20);
            this.cbPermiso.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.EditValue = null;
            this.dtpFecha.Location = new System.Drawing.Point(146, 163);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFecha.Size = new System.Drawing.Size(151, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(68, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Usuario:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(68, 134);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Permiso:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 170);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Fecha Vencimieno:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(32, 215);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(222, 215);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(43, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(225, 24);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Asignacion de permisos";
            // 
            // FrmPermisosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 267);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbPermiso);
            this.Controls.Add(this.cbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Name = "FrmPermisosUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos Usuarios";
            this.Load += new System.EventHandler(this.FrmPermisosUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPermiso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cbUsuario;
        private DevExpress.XtraEditors.LookUpEdit cbPermiso;
        private DevExpress.XtraEditors.DateEdit dtpFecha;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}