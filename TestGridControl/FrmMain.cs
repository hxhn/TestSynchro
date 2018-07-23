using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestGridControl
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        DateTime dt = DateTime.Now;
        DataTable dTable = null;
        string currentPath = null;
        string currentAlias = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            dTable = new DataTable("ResourceList");
            dTable.Columns.Add(this.ResourcePath.FieldName, System.Type.GetType("System.String"));
            dTable.Columns.Add(this.ResourceAlias.FieldName, System.Type.GetType("System.String"));
            dTable.Columns.Add(this.ResourceYear.FieldName, System.Type.GetType("System.String"));
            dTable.Columns.Add(this.IsLocalSave.FieldName, System.Type.GetType("System.String"));
            dTable.Columns.Add(this.DataType.FieldName, System.Type.GetType("System.String"));
            this.gridControl1.DataSource = dTable;


            this.SpinResourceYear.MaxValue = dt.Year;
            this.SpinResourceYear.MinValue = 2000;

            this.ComboBoxDataType.Items.Add("123");
            this.ComboBoxDataType.Items.Add("234");
            this.ComboBoxDataType.Items.Add("345");

            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            //this.gridView1.Columns[this.gridView1.Columns.Count - 2].OptionsColumn.AllowEdit = false;
            this.gridView1.InitNewRow += GridView1_InitNewRow;
            InitGridControl();
        }

        private void GridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

            this.gridView1.SetRowCellValue(e.RowHandle, this.ResourcePath.FieldName, currentPath);
            this.gridView1.SetRowCellValue(e.RowHandle, this.ResourceAlias.FieldName, currentAlias);
            this.gridView1.SetRowCellValue(e.RowHandle, this.ResourceYear.FieldName, dt.Year);
            this.gridView1.SetRowCellValue(e.RowHandle, this.IsLocalSave.FieldName, false);
            this.gridView1.SetRowCellValue(e.RowHandle, this.DataType.FieldName, "");
        }

        private void InitGridControl()
        {
            for (int i = 0;i < 2; i++)
            {
                currentPath = i.ToString();
                currentAlias = i.ToString();
                this.gridView1.AddNewRow();
            }
            this.gridView1.RefreshData();
            this.gridControl1.Refresh();
        }

        private void getvaluesRow()
        {
            DataRow row = this.gridView1.GetDataRow(1);
            string resourcePath = row.Field<string>(this.ResourcePath.FieldName);
            string resourceAlias = row.Field<string>(this.ResourceAlias.FieldName);
            int resourceYear = int.Parse(row.Field<string>(this.ResourceYear.FieldName));
            bool isLocalSave = false;
            if (row.Field<string>(this.IsLocalSave.FieldName).Equals("1"))
            {
                isLocalSave = true;
            }
            string dataType = row.Field<string>(this.DataType.FieldName);

            string msg = resourcePath + @"\n," + resourceAlias + @"\n," + resourceYear + @"\n," + isLocalSave + @"\n," + dataType;


            XtraMessageBox.Show(msg);
            
        }

        private void BtnGetValue_Click(object sender, EventArgs e)
        {
            getvaluesRow();
        }

        private void clearDatas()
        {
            /*int index = this.gridView1.RowCount;
            for (int i = index - 1;i >= 0;i--)
            {
                this.gridView1.DeleteRow(i);
            }*/
            this.gridView1.SelectAll();
            this.gridView1.DeleteSelectedRows();
        }

        private void BtnClearDatas_Click(object sender, EventArgs e)
        {
            clearDatas();
        }

        private void BtnFunction1_Click(object sender, EventArgs e)
        {
            FunctionOne fo = new FunctionOne();
            fo.Call();
        }

        private void BtnFunction2_Click(object sender, EventArgs e)
        {
            FunctionTwo ft = new FunctionTwo();
            ft.Call();
        }

        private void BtnFunction3_Click(object sender, EventArgs e)
        {
            FunctionThree ft = new FunctionThree();
            ft.Call();
        }
    }
}
