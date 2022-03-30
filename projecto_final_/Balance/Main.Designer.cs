namespace CRUD_Balances
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
            this.GridBalances = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.identificadorClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCorteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.balanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnreporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridBalances
            // 
            this.GridBalances.AutoGenerateColumns = false;
            this.GridBalances.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBalances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.identificadorClienteDataGridViewTextBoxColumn,
            this.fechaCorteDataGridViewTextBoxColumn,
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.GridBalances.DataSource = this.balanceBindingSource2;
            this.GridBalances.Location = new System.Drawing.Point(13, 110);
            this.GridBalances.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridBalances.Name = "GridBalances";
            this.GridBalances.RowHeadersWidth = 51;
            this.GridBalances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBalances.Size = new System.Drawing.Size(1033, 355);
            this.GridBalances.TabIndex = 0;
            this.GridBalances.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(155, 46);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(649, 34);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(813, 46);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(936, 46);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Identificador";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar fila";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Editar";
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Width = 60;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Eliminar fila";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Eliminar";
            this.Delete.UseColumnTextForLinkValue = true;
            this.Delete.Width = 70;
            // 
            // identificadorClienteDataGridViewTextBoxColumn
            // 
            this.identificadorClienteDataGridViewTextBoxColumn.DataPropertyName = "IdentificadorCliente";
            this.identificadorClienteDataGridViewTextBoxColumn.HeaderText = "IdentificadorCliente";
            this.identificadorClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.identificadorClienteDataGridViewTextBoxColumn.Name = "identificadorClienteDataGridViewTextBoxColumn";
            this.identificadorClienteDataGridViewTextBoxColumn.Width = 110;
            // 
            // fechaCorteDataGridViewTextBoxColumn
            // 
            this.fechaCorteDataGridViewTextBoxColumn.DataPropertyName = "FechaCorte";
            this.fechaCorteDataGridViewTextBoxColumn.HeaderText = "FechaCorte";
            this.fechaCorteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaCorteDataGridViewTextBoxColumn.Name = "fechaCorteDataGridViewTextBoxColumn";
            this.fechaCorteDataGridViewTextBoxColumn.Width = 68;
            // 
            // antigüedadPromedioSaldosDataGridViewTextBoxColumn
            // 
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn.DataPropertyName = "AntigüedadPromedioSaldos";
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn.HeaderText = "AntigüedadPromedioSaldos";
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn.Name = "antigüedadPromedioSaldosDataGridViewTextBoxColumn";
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn.Width = 145;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.Width = 125;
            // 
            // balanceBindingSource2
            // 
            this.balanceBindingSource2.DataSource = typeof(CRUD_Balances.Balance);
            // 
            // balanceBindingSource
            // 
            this.balanceBindingSource.DataSource = typeof(CRUD_Balances.Balance);
            // 
            // balanceBindingSource1
            // 
            this.balanceBindingSource1.DataSource = typeof(CRUD_Balances.Balance);
            // 
            // btnreporte
            // 
            this.btnreporte.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporte.Location = new System.Drawing.Point(470, 494);
            this.btnreporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(115, 36);
            this.btnreporte.TabIndex = 5;
            this.btnreporte.Text = "Reporte";
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridBalances);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balances";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridBalances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource balanceBindingSource;
        private System.Windows.Forms.BindingSource balanceBindingSource1;
        private System.Windows.Forms.BindingSource balanceBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificadorClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCorteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antigüedadPromedioSaldosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Button btnreporte;
    }
}

