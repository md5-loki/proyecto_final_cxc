namespace CRUD_Transacciones
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.GridTransacciones = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.identificadorTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMovimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificadorTipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificadorClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridTransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscador";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(116, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(488, 29);
            this.txtSearch.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(702, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(610, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GridTransacciones
            // 
            this.GridTransacciones.AutoGenerateColumns = false;
            this.GridTransacciones.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificadorTransaccionDataGridViewTextBoxColumn,
            this.tipoMovimientoDataGridViewTextBoxColumn,
            this.identificadorTipoDocumentoDataGridViewTextBoxColumn,
            this.numeroDocumentoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.identificadorClienteDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.GridTransacciones.DataSource = this.transaccionBindingSource;
            this.GridTransacciones.Location = new System.Drawing.Point(12, 107);
            this.GridTransacciones.Name = "GridTransacciones";
            this.GridTransacciones.Size = new System.Drawing.Size(776, 331);
            this.GridTransacciones.TabIndex = 4;
            this.GridTransacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTransacciones_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar fila";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            this.Editar.Width = 60;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar fila";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            this.Eliminar.Width = 70;
            // 
            // identificadorTransaccionDataGridViewTextBoxColumn
            // 
            this.identificadorTransaccionDataGridViewTextBoxColumn.DataPropertyName = "IdentificadorTransaccion";
            this.identificadorTransaccionDataGridViewTextBoxColumn.HeaderText = "IdentificadorTransaccion";
            this.identificadorTransaccionDataGridViewTextBoxColumn.Name = "identificadorTransaccionDataGridViewTextBoxColumn";
            this.identificadorTransaccionDataGridViewTextBoxColumn.Width = 80;
            // 
            // tipoMovimientoDataGridViewTextBoxColumn
            // 
            this.tipoMovimientoDataGridViewTextBoxColumn.DataPropertyName = "TipoMovimiento";
            this.tipoMovimientoDataGridViewTextBoxColumn.HeaderText = "TipoMovimiento";
            this.tipoMovimientoDataGridViewTextBoxColumn.Name = "tipoMovimientoDataGridViewTextBoxColumn";
            this.tipoMovimientoDataGridViewTextBoxColumn.Width = 80;
            // 
            // identificadorTipoDocumentoDataGridViewTextBoxColumn
            // 
            this.identificadorTipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "IdentificadorTipoDocumento";
            this.identificadorTipoDocumentoDataGridViewTextBoxColumn.HeaderText = "IdentificadorTipoDocumento";
            this.identificadorTipoDocumentoDataGridViewTextBoxColumn.Name = "identificadorTipoDocumentoDataGridViewTextBoxColumn";
            this.identificadorTipoDocumentoDataGridViewTextBoxColumn.Width = 80;
            // 
            // numeroDocumentoDataGridViewTextBoxColumn
            // 
            this.numeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumeroDocumento";
            this.numeroDocumentoDataGridViewTextBoxColumn.HeaderText = "NumeroDocumento";
            this.numeroDocumentoDataGridViewTextBoxColumn.Name = "numeroDocumentoDataGridViewTextBoxColumn";
            this.numeroDocumentoDataGridViewTextBoxColumn.Width = 80;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 68;
            // 
            // identificadorClienteDataGridViewTextBoxColumn
            // 
            this.identificadorClienteDataGridViewTextBoxColumn.DataPropertyName = "IdentificadorCliente";
            this.identificadorClienteDataGridViewTextBoxColumn.HeaderText = "IdentificadorCliente";
            this.identificadorClienteDataGridViewTextBoxColumn.Name = "identificadorClienteDataGridViewTextBoxColumn";
            this.identificadorClienteDataGridViewTextBoxColumn.Width = 80;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // transaccionBindingSource
            // 
            this.transaccionBindingSource.DataSource = typeof(CRUD_Transacciones.Transaccion);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridTransacciones);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transacciones";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView GridTransacciones;
        private System.Windows.Forms.BindingSource transaccionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificadorTransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMovimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificadorTipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificadorClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}

