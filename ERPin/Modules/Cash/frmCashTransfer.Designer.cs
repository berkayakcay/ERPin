namespace ERPin.Modules.Cash
{
    partial class FrmCashTransfer
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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtCashAccCode = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCashAccName = new DevExpress.XtraEditors.TextEdit();
            this.groupControlCashTransactionInfo = new DevExpress.XtraEditors.GroupControl();
            this.rBtnOutflowCash = new System.Windows.Forms.RadioButton();
            this.rBtnInflowCash = new System.Windows.Forms.RadioButton();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlCashAccountInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtDocumentNumber = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashAccCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashAccName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCashTransactionInfo)).BeginInit();
            this.groupControlCashTransactionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCashAccountInfo)).BeginInit();
            this.groupControlCashAccountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.ImageUri.Uri = "Save";
            this.btnSave.Location = new System.Drawing.Point(276, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCashAccCode
            // 
            this.txtCashAccCode.Location = new System.Drawing.Point(136, 49);
            this.txtCashAccCode.Name = "txtCashAccCode";
            this.txtCashAccCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCashAccCode.Size = new System.Drawing.Size(134, 20);
            this.txtCashAccCode.TabIndex = 1;
            this.txtCashAccCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCashAccCode_ButtonClick);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 78);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Description :";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(228, 26);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Amount :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 52);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Transaction Type :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Date :";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(276, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 33);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(278, 23);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Mask.EditMask = "c";
            this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmount.Size = new System.Drawing.Size(72, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Cash Account Name :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Cash Account Code :";
            // 
            // txtCashAccName
            // 
            this.txtCashAccName.Location = new System.Drawing.Point(136, 75);
            this.txtCashAccName.Name = "txtCashAccName";
            this.txtCashAccName.Size = new System.Drawing.Size(134, 20);
            this.txtCashAccName.TabIndex = 1;
            // 
            // groupControlCashTransactionInfo
            // 
            this.groupControlCashTransactionInfo.Controls.Add(this.rBtnOutflowCash);
            this.groupControlCashTransactionInfo.Controls.Add(this.rBtnInflowCash);
            this.groupControlCashTransactionInfo.Controls.Add(this.labelControl9);
            this.groupControlCashTransactionInfo.Controls.Add(this.labelControl8);
            this.groupControlCashTransactionInfo.Controls.Add(this.labelControl7);
            this.groupControlCashTransactionInfo.Controls.Add(this.labelControl6);
            this.groupControlCashTransactionInfo.Controls.Add(this.txtAmount);
            this.groupControlCashTransactionInfo.Controls.Add(this.txtDate);
            this.groupControlCashTransactionInfo.Controls.Add(this.txtDescription);
            this.groupControlCashTransactionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlCashTransactionInfo.Location = new System.Drawing.Point(0, 147);
            this.groupControlCashTransactionInfo.Name = "groupControlCashTransactionInfo";
            this.groupControlCashTransactionInfo.Size = new System.Drawing.Size(358, 156);
            this.groupControlCashTransactionInfo.TabIndex = 3;
            this.groupControlCashTransactionInfo.Text = "Cash Transaction Info";
            // 
            // rBtnOutflowCash
            // 
            this.rBtnOutflowCash.AutoSize = true;
            this.rBtnOutflowCash.Location = new System.Drawing.Point(228, 50);
            this.rBtnOutflowCash.Name = "rBtnOutflowCash";
            this.rBtnOutflowCash.Size = new System.Drawing.Size(90, 17);
            this.rBtnOutflowCash.TabIndex = 2;
            this.rBtnOutflowCash.TabStop = true;
            this.rBtnOutflowCash.Text = "Outflow Cash";
            this.rBtnOutflowCash.UseVisualStyleBackColor = true;
            // 
            // rBtnInflowCash
            // 
            this.rBtnInflowCash.AutoSize = true;
            this.rBtnInflowCash.Location = new System.Drawing.Point(140, 50);
            this.rBtnInflowCash.Name = "rBtnInflowCash";
            this.rBtnInflowCash.Size = new System.Drawing.Size(82, 17);
            this.rBtnInflowCash.TabIndex = 2;
            this.rBtnInflowCash.TabStop = true;
            this.rBtnInflowCash.Text = "Inflow Cash";
            this.rBtnInflowCash.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            this.txtDate.EditValue = null;
            this.txtDate.Location = new System.Drawing.Point(136, 23);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.DisplayFormat.FormatString = "";
            this.txtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDate.Properties.EditFormat.FormatString = "";
            this.txtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDate.Properties.Mask.EditMask = "";
            this.txtDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDate.Size = new System.Drawing.Size(86, 20);
            this.txtDate.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(136, 75);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(214, 72);
            this.txtDescription.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Document Number :";
            // 
            // groupControlCashAccountInfo
            // 
            this.groupControlCashAccountInfo.Controls.Add(this.btnClose);
            this.groupControlCashAccountInfo.Controls.Add(this.btnDelete);
            this.groupControlCashAccountInfo.Controls.Add(this.btnSave);
            this.groupControlCashAccountInfo.Controls.Add(this.labelControl3);
            this.groupControlCashAccountInfo.Controls.Add(this.labelControl2);
            this.groupControlCashAccountInfo.Controls.Add(this.labelControl1);
            this.groupControlCashAccountInfo.Controls.Add(this.txtCashAccName);
            this.groupControlCashAccountInfo.Controls.Add(this.txtCashAccCode);
            this.groupControlCashAccountInfo.Controls.Add(this.txtDocumentNumber);
            this.groupControlCashAccountInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlCashAccountInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlCashAccountInfo.Name = "groupControlCashAccountInfo";
            this.groupControlCashAccountInfo.Size = new System.Drawing.Size(358, 147);
            this.groupControlCashAccountInfo.TabIndex = 2;
            this.groupControlCashAccountInfo.Text = "Cash Account Info";
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::ERPin.Properties.Resources.Close24x24;
            this.btnClose.ImageOptions.ImageUri.Uri = "Close";
            this.btnClose.Location = new System.Drawing.Point(275, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 33);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Location = new System.Drawing.Point(136, 23);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDocumentNumber.Size = new System.Drawing.Size(134, 20);
            this.txtDocumentNumber.TabIndex = 1;
            this.txtDocumentNumber.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtDocumentNumber_ButtonClick);
            // 
            // FrmCashTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 303);
            this.Controls.Add(this.groupControlCashTransactionInfo);
            this.Controls.Add(this.groupControlCashAccountInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCashTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cash Transfer";
            this.Load += new System.EventHandler(this.frmCashTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCashAccCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashAccName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCashTransactionInfo)).EndInit();
            this.groupControlCashTransactionInfo.ResumeLayout(false);
            this.groupControlCashTransactionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCashAccountInfo)).EndInit();
            this.groupControlCashAccountInfo.ResumeLayout(false);
            this.groupControlCashAccountInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNumber.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.ButtonEdit txtCashAccCode;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCashAccName;
        private DevExpress.XtraEditors.GroupControl groupControlCashTransactionInfo;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControlCashAccountInfo;
        private System.Windows.Forms.RadioButton rBtnOutflowCash;
        private System.Windows.Forms.RadioButton rBtnInflowCash;
        private DevExpress.XtraEditors.ButtonEdit txtDocumentNumber;
    }
}