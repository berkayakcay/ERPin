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

namespace ERPin.Modules.Current
{
    public partial class frmCurrAccGroup : DevExpress.XtraEditors.XtraForm
    {
        #region Fields

        Functions.ERPinEntities db = new ERPinEntities();
        Functions.Messages messages = new Messages();

        public bool Selection = false;
        private bool Edit = false;
        private int SelectionId = -1;

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public frmCurrAccGroup()
        {
            InitializeComponent();
        }

        #region Events

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCurrAccGroup_Load(object sender, EventArgs e)
        {
            ListRecord();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit && SelectionId > 0 && messages.Update() == DialogResult.Yes)
            {
                UpdateRecord();
            }
            else
            {
                CreateRecord();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Edit && SelectionId > 0 && messages.Delete() == DialogResult.Yes)
            {
                DeleteRecord();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            SelectRecord();
            if (Selection && SelectionId > 0)
            {
                MainForm.Transfer = SelectionId;
                this.Close();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        void CreateRecord()
        {
            try
            {
                Functions.CurrAccGroup currAccGroup = new CurrAccGroup
                {
                    GroupCode = txtGroupCode.Text,
                    GroupName = txtGroupName.Text,
                    CreatedUserId = MainForm.UserId,
                    CreatedDate = DateTime.Now,
                    UpdatedUserId = MainForm.UserId,
                    UpdatedDate = DateTime.Now
                };
                db.CurrAccGroup.Add(currAccGroup);
                db.SaveChanges();
                messages.Save("Created");
                ListRecord();
            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void UpdateRecord()
        {
            try
            {
                Functions.CurrAccGroup currAccGroup = db.CurrAccGroup.Find(SelectionId);
                if (currAccGroup != null)
                {
                    currAccGroup.GroupCode = txtGroupCode.Text;
                    currAccGroup.GroupName = txtGroupName.Text;
                    currAccGroup.UpdatedUserId = MainForm.UserId;
                    currAccGroup.UpdatedDate = DateTime.Now;
                }
                db.SaveChanges();
                messages.Update("Updated");
                ListRecord();
            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void DeleteRecord()
        {
            try
            {
                db.CurrAccGroup.Remove(entity: db.CurrAccGroup.Find(SelectionId));
                db.SaveChanges();
                ClearRecord();
            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void ListRecord()
        {
            var list = db.CurrAccGroup.ToList();
            gcListe.DataSource = list;
        }

        /// <summary>
        /// 
        /// </summary>
        void SelectRecord()
        {
            try
            {
                Edit = true;
                SelectionId = (int)gridView1.GetFocusedRowCellValue("Id");
                txtGroupCode.Text = gridView1.GetFocusedRowCellValue("GroupCode").ToString();
                txtGroupName.Text = gridView1.GetFocusedRowCellValue("GroupName").ToString();
            }
            catch (Exception e)
            {
                messages.Error(e);
                Edit = false;
                SelectionId = -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void ClearRecord()
        {
            List<TextEdit> list = new List<TextEdit>();
            list.AddRange(gcCurrAccInfo.Controls.OfType<TextEdit>());
            Edit = false;
            SelectionId = -1;
            ListRecord();
        }

        #endregion
    }
}