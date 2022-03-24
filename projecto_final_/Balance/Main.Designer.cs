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
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.identificadorClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCorteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridBalances
            // 
            this.GridBalances.AutoGenerateColumns = false;
            this.GridBalances.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBalances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificadorClienteDataGridViewTextBoxColumn,
            this.fechaCorteDataGridViewTextBoxColumn,
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.GridBalances.DataSource = this.balanceBindingSource;
            this.GridBalances.Location = new System.Drawing.Point(13, 95);
            this.GridBalances.Name = "GridBalances";
            this.GridBalances.Size = new System.Drawing.Size(775, 343);
            this.GridBalances.TabIndex = 0;
            this.GridBalances.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(116, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(488, 29);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(610, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(702, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar fila";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Editar";
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Width = 60;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Eliminar fila";
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
            this.identificadorClienteDataGridViewTextBoxColumn.Name = "identificadorClienteDataGridViewTextBoxColumn";
            this.identificadorClienteDataGridViewTextBoxColumn.Width = 110;
            // 
            // fechaCorteDataGridViewTextBoxColumn
            // 
            this.fechaCorteDataGridViewTextBoxColumn.DataPropertyName = "FechaCorte";
            this.fechaCorteDataGridViewTextBoxColumn.HeaderText = "FechaCorte";
            this.fechaCorteDataGridViewTextBoxColumn.Name = "fechaCorteDataGridViewTextBoxColumn";
            this.fechaCorteDataGridViewTextBoxColumn.Width = 68;
            // 
            // antigüedadPromedioSaldosDataGridViewTextBoxColumn
            // 
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn.DataPropertyName = "AntigüedadPromedioSaldos";
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn.HeaderText = "AntigüedadPromedioSaldos";
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn.Name = "antigüedadPromedioSaldosDataGridViewTextBoxColumn";
            this.antigüedadPromedioSaldosDataGridViewTextBoxColumn.Width = 145;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // balanceBindingSource
            // 
            this.balanceBindingSource.DataSource = typeof(CRUD_Balances.Balance);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridBalances);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balances";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn identificadorClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCorteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antigüedadPromedioSaldosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}

