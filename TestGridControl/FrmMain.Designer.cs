namespace TestGridControl
{
    partial class FrmMain
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ResourcePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResourceAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResourceYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SpinResourceYear = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.IsLocalSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckIsSave = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.DataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ComboBoxDataType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.BtnGetValue = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClearDatas = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinResourceYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckIsSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDataType)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.SpinResourceYear,
            this.CheckIsSave,
            this.ComboBoxDataType});
            this.gridControl1.Size = new System.Drawing.Size(690, 401);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ResourcePath,
            this.ResourceAlias,
            this.ResourceYear,
            this.IsLocalSave,
            this.DataType});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ResourcePath
            // 
            this.ResourcePath.Caption = "资源路径";
            this.ResourcePath.FieldName = "ResourcePath";
            this.ResourcePath.Name = "ResourcePath";
            this.ResourcePath.Visible = true;
            this.ResourcePath.VisibleIndex = 0;
            // 
            // ResourceAlias
            // 
            this.ResourceAlias.Caption = "资源别名";
            this.ResourceAlias.FieldName = "ResourceAlias";
            this.ResourceAlias.Name = "ResourceAlias";
            this.ResourceAlias.Visible = true;
            this.ResourceAlias.VisibleIndex = 1;
            // 
            // ResourceYear
            // 
            this.ResourceYear.Caption = "资源年份";
            this.ResourceYear.ColumnEdit = this.SpinResourceYear;
            this.ResourceYear.FieldName = "ResourceYear";
            this.ResourceYear.Name = "ResourceYear";
            this.ResourceYear.Visible = true;
            this.ResourceYear.VisibleIndex = 2;
            // 
            // SpinResourceYear
            // 
            this.SpinResourceYear.AutoHeight = false;
            this.SpinResourceYear.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpinResourceYear.Name = "SpinResourceYear";
            // 
            // IsLocalSave
            // 
            this.IsLocalSave.Caption = "本地保存";
            this.IsLocalSave.ColumnEdit = this.CheckIsSave;
            this.IsLocalSave.FieldName = "IsLocalSave";
            this.IsLocalSave.Name = "IsLocalSave";
            this.IsLocalSave.Visible = true;
            this.IsLocalSave.VisibleIndex = 3;
            // 
            // CheckIsSave
            // 
            this.CheckIsSave.AutoHeight = false;
            this.CheckIsSave.Name = "CheckIsSave";
            this.CheckIsSave.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.CheckIsSave.ValueChecked = "1";
            this.CheckIsSave.ValueUnchecked = "0";
            // 
            // DataType
            // 
            this.DataType.Caption = "数据类型";
            this.DataType.ColumnEdit = this.ComboBoxDataType;
            this.DataType.FieldName = "DataType";
            this.DataType.Name = "DataType";
            this.DataType.Visible = true;
            this.DataType.VisibleIndex = 4;
            // 
            // ComboBoxDataType
            // 
            this.ComboBoxDataType.AutoHeight = false;
            this.ComboBoxDataType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxDataType.Name = "ComboBoxDataType";
            // 
            // BtnGetValue
            // 
            this.BtnGetValue.Location = new System.Drawing.Point(18, 7);
            this.BtnGetValue.Name = "BtnGetValue";
            this.BtnGetValue.Size = new System.Drawing.Size(95, 23);
            this.BtnGetValue.TabIndex = 1;
            this.BtnGetValue.Text = "获取第一行数据";
            this.BtnGetValue.Click += new System.EventHandler(this.BtnGetValue_Click);
            // 
            // BtnClearDatas
            // 
            this.BtnClearDatas.Location = new System.Drawing.Point(139, 7);
            this.BtnClearDatas.Name = "BtnClearDatas";
            this.BtnClearDatas.Size = new System.Drawing.Size(75, 23);
            this.BtnClearDatas.TabIndex = 2;
            this.BtnClearDatas.Text = "清空数据";
            this.BtnClearDatas.Click += new System.EventHandler(this.BtnClearDatas_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 401);
            this.Controls.Add(this.BtnClearDatas);
            this.Controls.Add(this.BtnGetValue);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmMain";
            this.Text = "表格测试";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinResourceYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckIsSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDataType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ResourcePath;
        private DevExpress.XtraGrid.Columns.GridColumn ResourceAlias;
        private DevExpress.XtraGrid.Columns.GridColumn ResourceYear;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit SpinResourceYear;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckIsSave;
        private DevExpress.XtraGrid.Columns.GridColumn DataType;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox ComboBoxDataType;
        private DevExpress.XtraGrid.Columns.GridColumn IsLocalSave;
        private DevExpress.XtraEditors.SimpleButton BtnGetValue;
        private DevExpress.XtraEditors.SimpleButton BtnClearDatas;
    }
}

