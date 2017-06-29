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
using ERPin.Models;
using ERPin.Repositories;
using ERPin.UnitOfWork;

namespace ERPin.Modules.Current
{
    public partial class FrmCurrAcc : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private ERPinDbContext _dbContext;
        private IUnitOfWork _unitOfWork;
        private IRepository<CurrAcc> _currAccRepository;
        private IRepository<CurrAccGroup> _currAccGroupRepository;

        private readonly Messages _messages = new Messages();
        private readonly Forms _forms = new Forms();
        private readonly Numbers _numbers = new Numbers();

        private bool _edit = false;
        private int _currAccId = -1;
        private int _groupId = -1;
        #endregion

        #region Events
        /// <summary>
        /// 
        /// </summary>
        public FrmCurrAcc()
        {
            InitializeComponent();

            _dbContext = new ERPinDbContext();
            _unitOfWork = new EfUnitOfWork(_dbContext);
            _currAccRepository = _unitOfWork.GetRepository<CurrAcc>();
            _currAccGroupRepository = _unitOfWork.GetRepository<CurrAccGroup>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCurrAcc_Load(object sender, EventArgs e)
        {
            txtCurrAccCode.Text = _numbers.LastCurrAccCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_edit && _currAccId > 0 && _messages.Update() == DialogResult.Yes)
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
            if (_edit && _currAccId > 0 && _messages.Delete() == DialogResult.Yes)
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

        private void txtCurrAccCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = _forms.CurrAccList(true);
            if (id > 0)
            {
                Open(id);
            }
            MainForm.Transfer = -1;
        }

        private void txtGroupCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = _forms.CurrAccGroup(true);
            if (id > 0 )
            {
                OpenGroup(id);
            }
            MainForm.Transfer = -1;
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
                CurrAcc currAcc = new CurrAcc();
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

                _currAccRepository.Add(currAcc);
                _unitOfWork.SaveChanges();
                _messages.Save("Created");
                ClearRecord();
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void UpdateRecord()
        {
            try
            {
                CurrAcc currAcc = _currAccRepository.GetById(_currAccId);
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

                _unitOfWork.SaveChanges();
                _messages.Update();
                ClearRecord();
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void DeleteRecord()
        {
            try
            {
                _currAccRepository.Delete(_currAccId);
                _unitOfWork.SaveChanges();
                ClearRecord();
            }
            catch (Exception e)
            {
                _messages.Error(e);
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
            txtCurrAccCode.Text = _numbers.LastCurrAccCode();
            _edit = false;
            _currAccId = -1;
            _groupId = -1;
            MainForm.Transfer = -1;
        }

        void OpenGroup(int id)
        {
            try
            {
                _groupId = id;
                CurrAccGroup currAccGroup = _currAccGroupRepository.GetById(_groupId);
                txtGroupCode.Text = currAccGroup.GroupCode;
                txtGroupName.Text = currAccGroup.GroupName;
            }
            catch (Exception e)
            {
                _messages.Error(e);
            }
        }

        public void Open(int id)
        {
            try
            {
                _edit = true;
                _currAccId = id;
                CurrAcc currAcc = _currAccRepository.GetById(_currAccId);
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
                _messages.Error(e);
            }
        }

        #endregion
    }
}