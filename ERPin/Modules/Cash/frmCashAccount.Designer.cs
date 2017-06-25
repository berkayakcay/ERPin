namespace ERPin.Modules.Cash
{
    partial class FrmCashAccount
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
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.groupControlCashAccList = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlCashAccInfo = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCashAccName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCashAccCode = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCashAccList)).BeginInit();
            this.groupControlCashAccList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCashAccInfo)).BeginInit();
            this.groupControlCashAccInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashAccName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashAccCode.Properties)).BeginInit();
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
            this.gridView1.GridControl = this.gcList;
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
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(2, 20);
            this.gcList.MainView = this.gridView1;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(408, 227);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControlCashAccList
            // 
            this.groupControlCashAccList.Controls.Add(this.gcList);
            this.groupControlCashAccList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlCashAccList.Location = new System.Drawing.Point(0, 160);
            this.groupControlCashAccList.Name = "groupControlCashAccList";
            this.groupControlCashAccList.Size = new System.Drawing.Size(412, 249);
            this.groupControlCashAccList.TabIndex = 10;
            this.groupControlCashAccList.Text = "Cash Account List";
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::ERPin.Properties.Resources.Close24x24;
            this.btnClose.ImageOptions.ImageUri.Uri = "Close";
            this.btnClose.Location = new System.Drawing.Point(329, 111);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(329, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.ImageUri.Uri = "Save";
            this.btnSave.Location = new System.Drawing.Point(329, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 76);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Description :";
            // 
            // groupControlCashAccInfo
            // 
            this.groupControlCashAccInfo.Controls.Add(this.btnClose);
            this.groupControlCashAccInfo.Controls.Add(this.btnDelete);
            this.groupControlCashAccInfo.Controls.Add(this.btnSave);
            this.groupControlCashAccInfo.Controls.Add(this.labelControl5);
            this.groupControlCashAccInfo.Controls.Add(this.labelControl2);
            this.groupControlCashAccInfo.Controls.Add(this.txtCashAccName);
            this.groupControlCashAccInfo.Controls.Add(this.labelControl1);
            this.groupControlCashAccInfo.Controls.Add(this.txtCashAccCode);
            this.groupControlCashAccInfo.Controls.Add(this.txtDescription);
            this.groupControlCashAccInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlCashAccInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlCashAccInfo.Name = "groupControlCashAccInfo";
            this.groupControlCashAccInfo.Size = new System.Drawing.Size(412, 160);
            this.groupControlCashAccInfo.TabIndex = 9;
            this.groupControlCashAccInfo.Text = "Cash Account Info";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Cash Account Name :";
            // 
            // txtCashAccName
            // 
            this.txtCashAccName.Location = new System.Drawing.Point(124, 49);
            this.txtCashAccName.Name = "txtCashAccName";
            this.txtCashAccName.Size = new System.Drawing.Size(199, 20);
            this.txtCashAccName.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cash Account Code :";
            // 
            // txtCashAccCode
            // 
            this.txtCashAccCode.Location = new System.Drawing.Point(124, 23);
            this.txtCashAccCode.Name = "txtCashAccCode";
            this.txtCashAccCode.Size = new System.Drawing.Size(199, 20);
            this.txtCashAccCode.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(124, 75);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(199, 74);
            this.txtDescription.TabIndex = 8;
            // 
            // frmCashAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 409);
            this.Controls.Add(this.groupControlCashAccList);
            this.Controls.Add(this.groupControlCashAccInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCashAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Account";
            this.Load += new System.EventHandler(this.frmCashAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCashAccList)).EndInit();
            this.groupControlCashAccList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCashAccInfo)).EndInit();
            this.groupControlCashAccInfo.ResumeLayout(false);
            this.groupControlCashAccInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashAccName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashAccCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Balance;
        private DevExpress.XtraGrid.Columns.GridColumn BankName;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn AccountType;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraEditors.GroupControl groupControlCashAccList;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControlCashAccInfo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCashAccName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCashAccCode;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
    }
}