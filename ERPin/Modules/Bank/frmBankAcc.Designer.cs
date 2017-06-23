namespace ERPin.Modules.Bank
{
    partial class frmBankAcc
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlBankInfo = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtIban = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtRepresentativeEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtRepresentative = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtBranchPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankBranch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankName = new DevExpress.XtraEditors.TextEdit();
            this.groupControlBankList = new DevExpress.XtraEditors.GroupControl();
            this.txtAdress = new DevExpress.XtraEditors.MemoEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Balance = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBankInfo)).BeginInit();
            this.groupControlBankInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepresentativeEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepresentative.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBankList)).BeginInit();
            this.groupControlBankList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::ERPin.Properties.Resources.Close24x24;
            this.btnClose.ImageOptions.ImageUri.Uri = "Close";
            this.btnClose.Location = new System.Drawing.Point(307, 135);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(307, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 50);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.ImageUri.Uri = "Save";
            this.btnSave.Location = new System.Drawing.Point(307, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            // 
            // groupControlBankInfo
            // 
            this.groupControlBankInfo.Controls.Add(this.btnClose);
            this.groupControlBankInfo.Controls.Add(this.labelControl9);
            this.groupControlBankInfo.Controls.Add(this.btnDelete);
            this.groupControlBankInfo.Controls.Add(this.txtIban);
            this.groupControlBankInfo.Controls.Add(this.btnSave);
            this.groupControlBankInfo.Controls.Add(this.labelControl8);
            this.groupControlBankInfo.Controls.Add(this.txtAccountNumber);
            this.groupControlBankInfo.Controls.Add(this.labelControl7);
            this.groupControlBankInfo.Controls.Add(this.txtRepresentativeEmail);
            this.groupControlBankInfo.Controls.Add(this.labelControl6);
            this.groupControlBankInfo.Controls.Add(this.txtRepresentative);
            this.groupControlBankInfo.Controls.Add(this.labelControl5);
            this.groupControlBankInfo.Controls.Add(this.labelControl4);
            this.groupControlBankInfo.Controls.Add(this.txtBranchPhone);
            this.groupControlBankInfo.Controls.Add(this.labelControl3);
            this.groupControlBankInfo.Controls.Add(this.txtBankBranch);
            this.groupControlBankInfo.Controls.Add(this.labelControl2);
            this.groupControlBankInfo.Controls.Add(this.txtAccountType);
            this.groupControlBankInfo.Controls.Add(this.labelControl1);
            this.groupControlBankInfo.Controls.Add(this.txtBankName);
            this.groupControlBankInfo.Controls.Add(this.txtAdress);
            this.groupControlBankInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlBankInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlBankInfo.Name = "groupControlBankInfo";
            this.groupControlBankInfo.Size = new System.Drawing.Size(394, 306);
            this.groupControlBankInfo.TabIndex = 7;
            this.groupControlBankInfo.Text = "groupControl1";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 104);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "IBAN :";
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(102, 101);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(199, 20);
            this.txtIban.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 78);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(86, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Account Number :";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(102, 75);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(199, 20);
            this.txtAccountNumber.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 270);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Rep Email :";
            // 
            // txtRepresentativeEmail
            // 
            this.txtRepresentativeEmail.Location = new System.Drawing.Point(102, 267);
            this.txtRepresentativeEmail.Name = "txtRepresentativeEmail";
            this.txtRepresentativeEmail.Size = new System.Drawing.Size(199, 20);
            this.txtRepresentativeEmail.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 244);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Representative :";
            // 
            // txtRepresentative
            // 
            this.txtRepresentative.Location = new System.Drawing.Point(102, 241);
            this.txtRepresentative.Name = "txtRepresentative";
            this.txtRepresentative.Size = new System.Drawing.Size(199, 20);
            this.txtRepresentative.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 180);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Address :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 156);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Branch Phone :";
            // 
            // txtBranchPhone
            // 
            this.txtBranchPhone.Location = new System.Drawing.Point(102, 153);
            this.txtBranchPhone.Name = "txtBranchPhone";
            this.txtBranchPhone.Size = new System.Drawing.Size(199, 20);
            this.txtBranchPhone.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Bank Branch :";
            // 
            // txtBankBranch
            // 
            this.txtBankBranch.Location = new System.Drawing.Point(102, 127);
            this.txtBankBranch.Name = "txtBankBranch";
            this.txtBankBranch.Size = new System.Drawing.Size(199, 20);
            this.txtBankBranch.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Account Type :";
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(102, 49);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(199, 20);
            this.txtAccountType.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Bank Name :";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(102, 23);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(199, 20);
            this.txtBankName.TabIndex = 0;
            // 
            // groupControlBankList
            // 
            this.groupControlBankList.Controls.Add(this.gridControl1);
            this.groupControlBankList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlBankList.Location = new System.Drawing.Point(0, 306);
            this.groupControlBankList.Name = "groupControlBankList";
            this.groupControlBankList.Size = new System.Drawing.Size(394, 213);
            this.groupControlBankList.TabIndex = 8;
            this.groupControlBankList.Text = "Bank List";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(102, 179);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(199, 56);
            this.txtAdress.TabIndex = 8;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(390, 191);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
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
            // frmBankAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 519);
            this.Controls.Add(this.groupControlBankList);
            this.Controls.Add(this.groupControlBankInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bank Account";
            this.Load += new System.EventHandler(this.frmBankAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBankInfo)).EndInit();
            this.groupControlBankInfo.ResumeLayout(false);
            this.groupControlBankInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepresentativeEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepresentative.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBankList)).EndInit();
            this.groupControlBankList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControlBankInfo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtIban;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtAccountNumber;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtRepresentativeEmail;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtRepresentative;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtBranchPhone;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtBankBranch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAccountType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private DevExpress.XtraEditors.GroupControl groupControlBankList;
        private DevExpress.XtraEditors.MemoEdit txtAdress;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn BankName;
        private DevExpress.XtraGrid.Columns.GridColumn AccountType;
        private DevExpress.XtraGrid.Columns.GridColumn Balance;
    }
}