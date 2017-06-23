namespace ERPin.Modules.Cash
{
    partial class frmCashAccount
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
            this.Balance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControlBankList = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlBankInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtAccountNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankName = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBankList)).BeginInit();
            this.groupControlBankList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBankInfo)).BeginInit();
            this.groupControlBankInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Balance
            // 
            this.Balance.Caption = "Balance";
            this.Balance.FieldName = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.OptionsColumn.AllowEdit = false;
            this.Balance.OptionsColumn.AllowFocus = false;
            this.Balance.OptionsColumn.FixedWidth = true;
            this.Balance.Visible = true;
            this.Balance.VisibleIndex = 2;
            // 
            // BankName
            // 
            this.BankName.Caption = "BankName";
            this.BankName.FieldName = "BankName";
            this.BankName.Name = "BankName";
            this.BankName.OptionsColumn.AllowEdit = false;
            this.BankName.OptionsColumn.AllowFocus = false;
            this.BankName.OptionsColumn.FixedWidth = true;
            this.BankName.Visible = true;
            this.BankName.VisibleIndex = 0;
            this.BankName.Width = 263;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.BankName,
            this.AccountType,
            this.Balance});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // AccountType
            // 
            this.AccountType.Caption = "AccountType";
            this.AccountType.FieldName = "AccountType";
            this.AccountType.Name = "AccountType";
            this.AccountType.OptionsColumn.AllowEdit = false;
            this.AccountType.OptionsColumn.AllowFocus = false;
            this.AccountType.OptionsColumn.FixedWidth = true;
            this.AccountType.Visible = true;
            this.AccountType.VisibleIndex = 1;
            this.AccountType.Width = 137;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(408, 215);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControlBankList
            // 
            this.groupControlBankList.Controls.Add(this.gridControl1);
            this.groupControlBankList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlBankList.Location = new System.Drawing.Point(0, 172);
            this.groupControlBankList.Name = "groupControlBankList";
            this.groupControlBankList.Size = new System.Drawing.Size(412, 237);
            this.groupControlBankList.TabIndex = 10;
            this.groupControlBankList.Text = "Cash Account List";
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::ERPin.Properties.Resources.Close24x24;
            this.btnClose.ImageOptions.ImageUri.Uri = "Close";
            this.btnClose.Location = new System.Drawing.Point(329, 117);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(329, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.ImageUri.Uri = "Save";
            this.btnSave.Location = new System.Drawing.Point(329, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 78);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Description :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 102);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Description :";
            // 
            // groupControlBankInfo
            // 
            this.groupControlBankInfo.Controls.Add(this.btnClose);
            this.groupControlBankInfo.Controls.Add(this.btnDelete);
            this.groupControlBankInfo.Controls.Add(this.btnSave);
            this.groupControlBankInfo.Controls.Add(this.labelControl8);
            this.groupControlBankInfo.Controls.Add(this.txtAccountNumber);
            this.groupControlBankInfo.Controls.Add(this.labelControl5);
            this.groupControlBankInfo.Controls.Add(this.labelControl2);
            this.groupControlBankInfo.Controls.Add(this.txtAccountType);
            this.groupControlBankInfo.Controls.Add(this.labelControl1);
            this.groupControlBankInfo.Controls.Add(this.txtBankName);
            this.groupControlBankInfo.Controls.Add(this.txtDescription);
            this.groupControlBankInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlBankInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlBankInfo.Name = "groupControlBankInfo";
            this.groupControlBankInfo.Size = new System.Drawing.Size(412, 172);
            this.groupControlBankInfo.TabIndex = 9;
            this.groupControlBankInfo.Text = "Cash Account Info";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(124, 75);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(199, 20);
            this.txtAccountNumber.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Cash Account Name :";
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(124, 49);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(199, 20);
            this.txtAccountType.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cash Account Code :";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(124, 23);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(199, 20);
            this.txtBankName.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(124, 101);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(199, 56);
            this.txtDescription.TabIndex = 8;
            // 
            // frmCashAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 409);
            this.Controls.Add(this.groupControlBankList);
            this.Controls.Add(this.groupControlBankInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCashAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Account";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBankList)).EndInit();
            this.groupControlBankList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBankInfo)).EndInit();
            this.groupControlBankInfo.ResumeLayout(false);
            this.groupControlBankInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Balance;
        private DevExpress.XtraGrid.Columns.GridColumn BankName;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn AccountType;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControlBankList;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControlBankInfo;
        private DevExpress.XtraEditors.TextEdit txtAccountNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAccountType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
    }
}