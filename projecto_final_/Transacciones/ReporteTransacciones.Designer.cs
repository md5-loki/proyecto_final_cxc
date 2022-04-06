namespace CRUD_Transacciones
{
    partial class ReporteTransacciones
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
            this.ReporteTransaccionesViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetGeneral = new CRUD_Transacciones.DataSetGeneral();
            this.dataSetGeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MostrarTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarTransaccionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarTransaccionTableAdapter = new CRUD_Transacciones.DataSetGeneralTableAdapters.MostrarTransaccionTableAdapter();
            this.mostrarTransaccionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarTransaccionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarTransaccionBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteTransaccionesViewer
            // 
            this.ReporteTransaccionesViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mostrarTransaccionBindingSource2;
            this.ReporteTransaccionesViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ReporteTransaccionesViewer.LocalReport.ReportEmbeddedResource = "CRUD_Transacciones.ImprimirTransacciones.rdlc";
            this.ReporteTransaccionesViewer.Location = new System.Drawing.Point(0, 0);
            this.ReporteTransaccionesViewer.Name = "ReporteTransaccionesViewer";
            this.ReporteTransaccionesViewer.ServerReport.BearerToken = null;
            this.ReporteTransaccionesViewer.Size = new System.Drawing.Size(1026, 748);
            this.ReporteTransaccionesViewer.TabIndex = 0;
            // 
            // dataSetGeneral
            // 
            this.dataSetGeneral.DataSetName = "DataSetGeneral";
            this.dataSetGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetGeneralBindingSource
            // 
            this.dataSetGeneralBindingSource.DataSource = this.dataSetGeneral;
            this.dataSetGeneralBindingSource.Position = 0;
            // 
            // MostrarTransaccionBindingSource
            // 
            this.MostrarTransaccionBindingSource.DataMember = "MostrarTransaccion";
            this.MostrarTransaccionBindingSource.DataSource = this.dataSetGeneral;
            // 
            // mostrarTransaccionBindingSource1
            // 
            this.mostrarTransaccionBindingSource1.DataMember = "MostrarTransaccion";
            this.mostrarTransaccionBindingSource1.DataSource = this.dataSetGeneralBindingSource;
            // 
            // mostrarTransaccionTableAdapter
            // 
            this.mostrarTransaccionTableAdapter.ClearBeforeFill = true;
            // 
            // mostrarTransaccionBindingSource2
            // 
            this.mostrarTransaccionBindingSource2.DataMember = "MostrarTransaccion";
            this.mostrarTransaccionBindingSource2.DataSource = this.dataSetGeneralBindingSource;
            // 
            // ReporteTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 748);
            this.Controls.Add(this.ReporteTransaccionesViewer);
            this.Name = "ReporteTransacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte transacciones";
            this.Load += new System.EventHandler(this.ReporteTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarTransaccionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarTransaccionBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteTransaccionesViewer;
        private System.Windows.Forms.BindingSource dataSetGeneralBindingSource;
        private DataSetGeneral dataSetGeneral;
        private System.Windows.Forms.BindingSource MostrarTransaccionBindingSource;
        private System.Windows.Forms.BindingSource mostrarTransaccionBindingSource1;
        private DataSetGeneralTableAdapters.MostrarTransaccionTableAdapter mostrarTransaccionTableAdapter;
        private System.Windows.Forms.BindingSource mostrarTransaccionBindingSource2;
    }
}