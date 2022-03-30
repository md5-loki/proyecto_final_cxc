
namespace CRUD_Balances
{
    partial class FormReporteBalances
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetBalance = new CRUD_Balances.DataSetBalance();
            this.Mostrar_Balance_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Mostrar_Balance_ClienteTableAdapter = new CRUD_Balances.DataSetBalanceTableAdapters.Mostrar_Balance_ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Balance_ClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Mostrar_Balance_ClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD_Balances.BalanceReportes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(844, 499);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetBalance
            // 
            this.DataSetBalance.DataSetName = "DataSetBalance";
            this.DataSetBalance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Mostrar_Balance_ClienteBindingSource
            // 
            this.Mostrar_Balance_ClienteBindingSource.DataMember = "Mostrar_Balance_Cliente";
            this.Mostrar_Balance_ClienteBindingSource.DataSource = this.DataSetBalance;
            // 
            // Mostrar_Balance_ClienteTableAdapter
            // 
            this.Mostrar_Balance_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 499);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteBalances";
            this.Text = "Reporte Balances";
            this.Load += new System.EventHandler(this.FormReporteBalances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Balance_ClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Mostrar_Balance_ClienteBindingSource;
        private DataSetBalance DataSetBalance;
        private DataSetBalanceTableAdapters.Mostrar_Balance_ClienteTableAdapter Mostrar_Balance_ClienteTableAdapter;
    }
}