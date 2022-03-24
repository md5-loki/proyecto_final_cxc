
namespace Tipos_Documentos
{
    partial class Form_Tipos_Documentos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblIdTD = new System.Windows.Forms.Label();
            this.lblDescTD = new System.Windows.Forms.Label();
            this.lblCcTD = new System.Windows.Forms.Label();
            this.lblEstTD = new System.Windows.Forms.Label();
            this.txtIdTD = new System.Windows.Forms.TextBox();
            this.txtDescTD = new System.Windows.Forms.TextBox();
            this.txtCcTD = new System.Windows.Forms.TextBox();
            this.dgvTD = new System.Windows.Forms.DataGridView();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.PBotones = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaContableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.PHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTD)).BeginInit();
            this.PBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PHeader
            // 
            this.PHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PHeader.Controls.Add(this.btnSalir);
            this.PHeader.Controls.Add(this.lblHeader);
            this.PHeader.Location = new System.Drawing.Point(0, 0);
            this.PHeader.Name = "PHeader";
            this.PHeader.Size = new System.Drawing.Size(1029, 125);
            this.PHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(319, 35);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(360, 38);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tipos De Documentos";
            // 
            // lblIdTD
            // 
            this.lblIdTD.AutoSize = true;
            this.lblIdTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTD.Location = new System.Drawing.Point(12, 205);
            this.lblIdTD.Name = "lblIdTD";
            this.lblIdTD.Size = new System.Drawing.Size(38, 29);
            this.lblIdTD.TabIndex = 1;
            this.lblIdTD.Text = "ID";
            // 
            // lblDescTD
            // 
            this.lblDescTD.AutoSize = true;
            this.lblDescTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescTD.Location = new System.Drawing.Point(12, 268);
            this.lblDescTD.Name = "lblDescTD";
            this.lblDescTD.Size = new System.Drawing.Size(152, 29);
            this.lblDescTD.TabIndex = 2;
            this.lblDescTD.Text = "Descripción";
            // 
            // lblCcTD
            // 
            this.lblCcTD.AutoSize = true;
            this.lblCcTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCcTD.Location = new System.Drawing.Point(442, 205);
            this.lblCcTD.Name = "lblCcTD";
            this.lblCcTD.Size = new System.Drawing.Size(207, 29);
            this.lblCcTD.TabIndex = 3;
            this.lblCcTD.Text = "Cuenta Contable";
            // 
            // lblEstTD
            // 
            this.lblEstTD.AutoSize = true;
            this.lblEstTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstTD.Location = new System.Drawing.Point(442, 268);
            this.lblEstTD.Name = "lblEstTD";
            this.lblEstTD.Size = new System.Drawing.Size(94, 29);
            this.lblEstTD.TabIndex = 4;
            this.lblEstTD.Text = "Estado";
            // 
            // txtIdTD
            // 
            this.txtIdTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTD.Location = new System.Drawing.Point(203, 205);
            this.txtIdTD.Name = "txtIdTD";
            this.txtIdTD.ReadOnly = true;
            this.txtIdTD.Size = new System.Drawing.Size(179, 30);
            this.txtIdTD.TabIndex = 0;
            // 
            // txtDescTD
            // 
            this.txtDescTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescTD.Location = new System.Drawing.Point(203, 275);
            this.txtDescTD.Name = "txtDescTD";
            this.txtDescTD.Size = new System.Drawing.Size(179, 30);
            this.txtDescTD.TabIndex = 1;
            // 
            // txtCcTD
            // 
            this.txtCcTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCcTD.Location = new System.Drawing.Point(677, 205);
            this.txtCcTD.Name = "txtCcTD";
            this.txtCcTD.Size = new System.Drawing.Size(186, 30);
            this.txtCcTD.TabIndex = 2;
            // 
            // dgvTD
            // 
            this.dgvTD.AutoGenerateColumns = false;
            this.dgvTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cuentaContableDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvTD.DataSource = this.tipoDocumentoBindingSource;
            this.dgvTD.Location = new System.Drawing.Point(17, 343);
            this.dgvTD.Name = "dgvTD";
            this.dgvTD.ReadOnly = true;
            this.dgvTD.RowHeadersWidth = 51;
            this.dgvTD.RowTemplate.Height = 24;
            this.dgvTD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTD.Size = new System.Drawing.Size(662, 175);
            this.dgvTD.TabIndex = 9;
            this.dgvTD.SelectionChanged += new System.EventHandler(this.dgvTD_SelectionChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(677, 273);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(186, 33);
            this.cbEstado.TabIndex = 3;
            // 
            // PBotones
            // 
            this.PBotones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PBotones.Controls.Add(this.btnBorrar);
            this.PBotones.Controls.Add(this.btnModificar);
            this.PBotones.Controls.Add(this.btnNuevo);
            this.PBotones.Location = new System.Drawing.Point(695, 342);
            this.PBotones.Name = "PBotones";
            this.PBotones.Size = new System.Drawing.Size(168, 176);
            this.PBotones.TabIndex = 11;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(18, 124);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(132, 38);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(18, 74);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 38);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(18, 18);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 38);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(887, 480);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 38);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(12, 141);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(93, 29);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(111, 141);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(752, 30);
            this.txtBuscar.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(887, 139);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 38);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // cuentaContableDataGridViewTextBoxColumn
            // 
            this.cuentaContableDataGridViewTextBoxColumn.DataPropertyName = "Cuenta_Contable";
            this.cuentaContableDataGridViewTextBoxColumn.HeaderText = "Cuenta_Contable";
            this.cuentaContableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cuentaContableDataGridViewTextBoxColumn.Name = "cuentaContableDataGridViewTextBoxColumn";
            this.cuentaContableDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuentaContableDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataSource = typeof(Tipos_Documentos.Tipo_Documento);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(887, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 38);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form_Tipos_Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1033, 530);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.PBotones);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.dgvTD);
            this.Controls.Add(this.txtCcTD);
            this.Controls.Add(this.txtDescTD);
            this.Controls.Add(this.txtIdTD);
            this.Controls.Add(this.lblEstTD);
            this.Controls.Add(this.lblCcTD);
            this.Controls.Add(this.lblDescTD);
            this.Controls.Add(this.lblIdTD);
            this.Controls.Add(this.PHeader);
            this.Name = "Form_Tipos_Documentos";
            this.Text = "Tipos De Documentos";
            this.Load += new System.EventHandler(this.Form_Tipos_Documentos_Load);
            this.PHeader.ResumeLayout(false);
            this.PHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTD)).EndInit();
            this.PBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblIdTD;
        private System.Windows.Forms.Label lblDescTD;
        private System.Windows.Forms.Label lblCcTD;
        private System.Windows.Forms.Label lblEstTD;
        private System.Windows.Forms.TextBox txtIdTD;
        private System.Windows.Forms.TextBox txtDescTD;
        private System.Windows.Forms.TextBox txtCcTD;
        private System.Windows.Forms.DataGridView dgvTD;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Panel PBotones;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaContableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
    }
}

