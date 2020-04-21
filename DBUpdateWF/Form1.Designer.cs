namespace DBUpdateWF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.medStufButton = new System.Windows.Forms.Button();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.medstuftempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTD_DB_DICT_HIVEDataSet1 = new DBUpdateWF.STD_DB_DICT_HIVEDataSet1();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colold_cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnew_cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colold_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnew_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfile_n = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleditor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coledit_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchng_knd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.med_stuf_tempTableAdapter = new DBUpdateWF.STD_DB_DICT_HIVEDataSet1TableAdapters.med_stuf_tempTableAdapter();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medstuftempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTD_DB_DICT_HIVEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(322, 141);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "desktop-n6r6keu\\sqlexpress.STD_DB_DICT_HIVE.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = null;
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // medStufButton
            // 
            this.medStufButton.Location = new System.Drawing.Point(12, 12);
            this.medStufButton.Name = "medStufButton";
            this.medStufButton.Size = new System.Drawing.Size(140, 26);
            this.medStufButton.TabIndex = 1;
            this.medStufButton.Text = "Мед. оборудование";
            this.medStufButton.UseVisualStyleBackColor = true;
            this.medStufButton.Click += new System.EventHandler(this.medStufButton_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.medstuftempBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(31, 141);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(400, 200);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // medstuftempBindingSource
            // 
            this.medstuftempBindingSource.DataMember = "med_stuf_temp";
            this.medstuftempBindingSource.DataSource = this.sTD_DB_DICT_HIVEDataSet1;
            // 
            // sTD_DB_DICT_HIVEDataSet1
            // 
            this.sTD_DB_DICT_HIVEDataSet1.DataSetName = "STD_DB_DICT_HIVEDataSet1";
            this.sTD_DB_DICT_HIVEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcode,
            this.colold_cost,
            this.colnew_cost,
            this.colold_name,
            this.colnew_name,
            this.colfile_n,
            this.coleditor,
            this.coledit_date,
            this.colchng_knd,
            this.colaccept});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 34;
            // 
            // colcode
            // 
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 1;
            this.colcode.Width = 34;
            // 
            // colold_cost
            // 
            this.colold_cost.FieldName = "old_cost";
            this.colold_cost.Name = "colold_cost";
            this.colold_cost.Visible = true;
            this.colold_cost.VisibleIndex = 2;
            this.colold_cost.Width = 34;
            // 
            // colnew_cost
            // 
            this.colnew_cost.FieldName = "new_cost";
            this.colnew_cost.Name = "colnew_cost";
            this.colnew_cost.Visible = true;
            this.colnew_cost.VisibleIndex = 3;
            this.colnew_cost.Width = 34;
            // 
            // colold_name
            // 
            this.colold_name.FieldName = "old_name";
            this.colold_name.Name = "colold_name";
            this.colold_name.Visible = true;
            this.colold_name.VisibleIndex = 4;
            this.colold_name.Width = 34;
            // 
            // colnew_name
            // 
            this.colnew_name.FieldName = "new_name";
            this.colnew_name.Name = "colnew_name";
            this.colnew_name.Visible = true;
            this.colnew_name.VisibleIndex = 5;
            this.colnew_name.Width = 34;
            // 
            // colfile_n
            // 
            this.colfile_n.FieldName = "file_n";
            this.colfile_n.Name = "colfile_n";
            this.colfile_n.Visible = true;
            this.colfile_n.VisibleIndex = 6;
            this.colfile_n.Width = 34;
            // 
            // coleditor
            // 
            this.coleditor.FieldName = "editor";
            this.coleditor.Name = "coleditor";
            this.coleditor.Visible = true;
            this.coleditor.VisibleIndex = 7;
            this.coleditor.Width = 20;
            // 
            // coledit_date
            // 
            this.coledit_date.FieldName = "edit_date";
            this.coledit_date.Name = "coledit_date";
            this.coledit_date.Visible = true;
            this.coledit_date.VisibleIndex = 8;
            this.coledit_date.Width = 67;
            // 
            // colchng_knd
            // 
            this.colchng_knd.FieldName = "chng_knd";
            this.colchng_knd.Name = "colchng_knd";
            this.colchng_knd.Visible = true;
            this.colchng_knd.VisibleIndex = 9;
            this.colchng_knd.Width = 32;
            // 
            // colaccept
            // 
            this.colaccept.FieldName = "accept";
            this.colaccept.Name = "colaccept";
            this.colaccept.Visible = true;
            this.colaccept.VisibleIndex = 10;
            this.colaccept.Width = 41;
            // 
            // med_stuf_tempTableAdapter
            // 
            this.med_stuf_tempTableAdapter.ClearBeforeFill = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(657, 14);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(131, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.medStufButton);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medstuftempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTD_DB_DICT_HIVEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.Button medStufButton;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private STD_DB_DICT_HIVEDataSet1 sTD_DB_DICT_HIVEDataSet1;
        private System.Windows.Forms.BindingSource medstuftempBindingSource;
        private STD_DB_DICT_HIVEDataSet1TableAdapters.med_stuf_tempTableAdapter med_stuf_tempTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colold_cost;
        private DevExpress.XtraGrid.Columns.GridColumn colnew_cost;
        private DevExpress.XtraGrid.Columns.GridColumn colold_name;
        private DevExpress.XtraGrid.Columns.GridColumn colnew_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfile_n;
        private DevExpress.XtraGrid.Columns.GridColumn coleditor;
        private DevExpress.XtraGrid.Columns.GridColumn coledit_date;
        private DevExpress.XtraGrid.Columns.GridColumn colchng_knd;
        private DevExpress.XtraGrid.Columns.GridColumn colaccept;
        private System.Windows.Forms.Button updateButton;
    }
}

