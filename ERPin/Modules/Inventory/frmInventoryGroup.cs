using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERPin.Functions;

namespace ERPin.Modules.Stock
{
    public partial class frmInventoryGroup : DevExpress.XtraEditors.XtraForm
    {
        #region Variables

        Functions.ERPinEntities db = new ERPinEntities();
        Functions.Messages messages = new Messages();

        public bool Selection = false;
        private int SelectedId = -1;
        private bool Edit = false;

        #endregion


        public frmInventoryGroup()
        {
            InitializeComponent();
        }


        #region Events

        private void frmInventoryGroup_Load(object sender, EventArgs e)
        {
            ListRecord();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Edit && SelectedId > 0 && messages.Delete() == DialogResult.Yes)
            {
                DeleteRecord();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit && SelectedId > 0 && messages.Update() == DialogResult.Yes)
            {
                UpdateRecord();
            }
            else
            {
                CreateRecord();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            SelectRecord();
            if (Selection && SelectedId > 0)
            {
                MainForm.Transfer = SelectedId;
                this.Close();
            }
        }
        #endregion


        #region Functions

        void ListRecord()
        {
            try
            {
                List<InventoryGroup> list = db.InventoryGroup.ToList();
                gcListe.DataSource = list;
            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }

        void ClearRecord()
        {
            List<TextEdit> controls = groupControl1.Controls.OfType<TextEdit>().ToList();
            foreach (var textEdit in controls)
            {
                textEdit.Text = "";
            }
        }

        void CreateRecord()
        {
            try
            {
                Functions.InventoryGroup inventoryGroup = new InventoryGroup();
                inventoryGroup.GroupCode = txtGroupCode.Text;
                inventoryGroup.GroupName = txtGroupName.Text;
                db.InventoryGroup.Add(inventoryGroup);
                db.SaveChanges();
                messages.Save("New record has been created");
                ClearRecord();
                ListRecord();
            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }

        void UpdateRecord()
        {
            try
            {
                Functions.InventoryGroup inventoryGroup = db.InventoryGroup.Find(SelectedId);
                if (inventoryGroup != null)
                {
                    inventoryGroup.GroupCode = txtGroupCode.Text;
                    inventoryGroup.GroupName = txtGroupName.Text;
                    db.SaveChanges();
                    messages.Update(inventoryGroup.Id.ToString());
                }
                ClearRecord();
                ListRecord();
            }
            catch (Exception e)
            {
                messages.Error(e);
            }

        }

        void DeleteRecord()
        {
            try
            {
                db.InventoryGroup.Remove(db.InventoryGroup.First(x => x.Id == SelectedId));
                db.SaveChanges();
                messages.Delete();
                ClearRecord();
                ListRecord();
            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }

        void SelectRecord()
        {
            try
            {
                Edit = true;
                SelectedId = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                txtGroupCode.Text = gridView1.GetFocusedRowCellValue("GroupCode").ToString();
                txtGroupName.Text = gridView1.GetFocusedRowCellValue("GroupName").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SelectedId = -1;
            }
        }
        #endregion


    }
}
