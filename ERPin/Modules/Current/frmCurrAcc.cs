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
    public partial class frmCurrAcc : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        Functions.ERPinEntities db = new ERPinEntities();
        Functions.Messages messages = new Messages();
        Functions.Forms forms = new Forms();
        Functions.Numbers numbers = new Numbers();

        private bool Edit = false;
        private int CurrAccId = -1;
        private int GroupId = -1;
        #endregion

        #region Events
        /// <summary>
        /// 
        /// </summary>
        public frmCurrAcc()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCurrAcc_Load(object sender, EventArgs e)
        {
            txtCurrAccCode.Text = numbers.LastCurrAccCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit && CurrAccId > 0 && messages.Update() == DialogResult.Yes)
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
            if (Edit && CurrAccId > 0 && messages.Delete() == DialogResult.Yes)
            {
                DeleteRecord();
            }
        }

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                Functions.CurrAcc currAcc = new CurrAcc();
                currAcc.CurrAccCode = txtCurrAccCode.Text;
                currAcc.CurrAccName = txtCurrAccName.Text;
                currAcc.GroupId = int.Parse(txtGroupCode.Text);
                currAcc.TaxOffice = txtTaxOffice.Text;
                currAcc.TaxNumber = txtTaxNumber.Text;
                currAcc.Country = txtCountry.Text;
                currAcc.City = txtCity.Text;
                currAcc.District = txtDistrict.Text;
                currAcc.Phone1 = txtPhone1.Text;
                currAcc.Phone2 = txtPhone2.Text;
                currAcc.Fax1 = txtFax1.Text;
                currAcc.Fax2 = txtFax2.Text;
                currAcc.Address = txtAddress.Text;
                currAcc.Web = txtWeb.Text;
                currAcc.EMail = txtEmail.Text;
                currAcc.Contact = txtContact.Text;
                currAcc.ContactEmail = txtContactMail.Text;
                // Audit trail
                currAcc.CreatedUserId = MainForm.UserId;
                currAcc.CreatedDate = DateTime.Now;
                currAcc.UpdatedUserId = MainForm.UserId;
                currAcc.UpdatedDate = DateTime.Now;
                db.CurrAcc.Add(currAcc);
                db.SaveChanges();
                messages.Save("Created");
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
        void UpdateRecord()
        {
            try
            {
                Functions.CurrAcc currAcc = db.CurrAcc.Find(CurrAccId);
                currAcc.CurrAccCode = txtCurrAccCode.Text;
                currAcc.CurrAccName = txtCurrAccName.Text;
                currAcc.GroupId = int.Parse(txtGroupCode.Text);
                currAcc.TaxOffice = txtTaxOffice.Text;
                currAcc.TaxNumber = txtTaxNumber.Text;
                currAcc.Country = txtCountry.Text;
                currAcc.City = txtCity.Text;
                currAcc.District = txtDistrict.Text;
                currAcc.Phone1 = txtPhone1.Text;
                currAcc.Phone2 = txtPhone2.Text;
                currAcc.Fax1 = txtFax1.Text;
                currAcc.Fax2 = txtFax2.Text;
                currAcc.Address = txtAddress.Text;
                currAcc.Web = txtWeb.Text;
                currAcc.EMail = txtEmail.Text;
                currAcc.Contact = txtContact.Text;
                currAcc.ContactEmail = txtContactMail.Text;

                // Audit trail
                currAcc.UpdatedUserId = MainForm.UserId;
                currAcc.UpdatedDate = DateTime.Now;

                db.SaveChanges();
                messages.Update();
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
        void DeleteRecord()
        {
            try
            {
                db.CurrAcc.Remove(db.CurrAcc.Find(CurrAccId));
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

        }

        /// <summary>
        /// 
        /// </summary>
        void ClearRecord()
        {
            foreach (TextEdit textEdit in groupControlCurrAccInfo.Controls.OfType<TextEdit>())
            {
                textEdit.Text = "";
            }
            foreach (TextEdit textEdit in groupControlCurrAccSum.Controls.OfType<TextEdit>())
            {
                textEdit.Text = "";
            }
            txtCurrAccCode.Text = numbers.LastCurrAccCode();
            Edit = false;
            CurrAccId = -1;
            GroupId = -1;
            MainForm.Transfer = -1;
        }

        void OpenGroup(int id)
        {
            try
            {
                GroupId = id;
                Functions.CurrAccGroup currAccGroup = db.CurrAccGroup.Find(GroupId);
                txtGroupCode.Text = currAccGroup.GroupCode;
                txtGroupName.Text = currAccGroup.GroupName;
            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }

        public void Open(int id)
        {
            try
            {
                Edit = true;
                CurrAccId = id;
                Functions.CurrAcc currAcc = db.CurrAcc.Find(CurrAccId);
                txtCurrAccCode.Text = currAcc.CurrAccCode;
                txtCurrAccName.Text = currAcc.CurrAccName;
                OpenGroup(currAcc.GroupId.Value);//Open group
                txtTaxOffice.Text = currAcc.TaxOffice;
                txtTaxNumber.Text = currAcc.TaxNumber;
                txtCountry.Text = currAcc.Country;
                txtCity.Text = currAcc.City;
                txtDistrict.Text = currAcc.District;
                txtPhone1.Text = currAcc.Phone1;
                txtPhone2.Text = currAcc.Phone2;
                txtFax1.Text = currAcc.Fax1;
                txtFax2.Text = currAcc.Fax2;
                txtAddress.Text = currAcc.Address;
                txtWeb.Text = currAcc.Web;
                txtEmail.Text = currAcc.EMail;
                txtContact.Text = currAcc.Contact;
                txtContactMail.Text = currAcc.ContactEmail;
            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }

        #endregion

        private void txtCurrAccCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = forms.CurrAccList(true);
            if (id > 0)
            {
                Open(id);
            }
            MainForm.Transfer = -1;
        }

        private void txtGroupCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = forms.CurrAccGroup(true);
            if (id > 0 )
            {
                OpenGroup(id);
            }
            MainForm.Transfer = -1;
        }
    }
}