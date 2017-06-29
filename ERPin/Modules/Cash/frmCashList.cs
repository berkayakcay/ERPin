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

namespace ERPin.Modules.Cash
{
    public partial class FrmCashList : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private ERPinDbContext _dbContext;
        private IUnitOfWork _unitOfWork;
        private IRepository<CashAcc> _cashAccRepository;

        private readonly Messages _messages = new Messages();
        private readonly Forms _forms = new Forms();
        private readonly Numbers _numbers = new Numbers();

        public bool Selection = false;
        private bool _edit = false;
        private int _selectionId = -1;
        #endregion

        #region Events
        public FrmCashList()
        {
            InitializeComponent();

            _dbContext = new ERPinDbContext();
            _unitOfWork = new EfUnitOfWork(_dbContext);
            _cashAccRepository = _unitOfWork.GetRepository<CashAcc>();
        }

        private void frmCashList_Load(object sender, EventArgs e)
        {
            ListRecord();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListRecord();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            SelectRecord();
            if (Selection && _selectionId > 0)
            {
                MainForm.Transfer = _selectionId;
                this.Close();
            }
        }

        #endregion


        #region Methods

        void ListRecord()
        {
            var list = _cashAccRepository.GetAll().Where(x => x.CashAccCode.Contains(txtCashAccCode.Text) && x.CashAccName.Contains(txtCashAccName.Text)).ToList();
            gcList.DataSource = list;
        }

        void SelectRecord()
        {
            try
            {
                _selectionId = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            }
            catch (Exception)
            {
                _selectionId = -1;
            }
        }

        #endregion
    }
}