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

        public bool Selections = false;
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

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        void SaveRecord()
        {
            try
            {

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

            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void SelectRecord()
        {
            try
            {

            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }
        

        #endregion
    }
}