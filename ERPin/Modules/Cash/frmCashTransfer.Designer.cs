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
            this.textEdit2 = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.groupControlCashTransactionInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.textEdit9 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.groupControlCashAccountInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCashTransactionInfo)).BeginInit();
            this.groupControlCashTransactionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCashAccountInfo)).BeginInit();
            this.groupControlCashAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.ImageUri.Uri = "Save";
            this.btnSave.Location = new System.Drawing.Point(297, 95);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(136, 49);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.textEdit2.Size = new System.Drawing.Size(156, 20);
            this.textEdit2.TabIndex = 1;
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
            this.labelControl8.Location = new System.Drawing.Point(248, 26);
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
            this.btnDelete.Location = new System.Drawing.Point(298, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            // 
            // textEdit8
            // 
            this.textEdit8.Location = new System.Drawing.Point(298, 23);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Properties.Mask.EditMask = "c";
            this.textEdit8.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit8.Size = new System.Drawing.Size(75, 20);
            this.textEdit8.TabIndex = 1;
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
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(136, 75);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(156, 20);
            this.textEdit3.TabIndex = 1;
            // 
            // groupControlCashTransactionInfo
            // 
            this.groupControlCashTransactionInfo.Controls.Add(this.radioButton2);
            this.groupControlCashTransactionInfo.Controls.Add(this.radioButton1);
            this.groupControlCashTransactionInfo.Controls.Add(this.labelControl9);
            this.groupControlCashTransactionInfo.Controls.Add(this.labelControl8);
            this.groupControlCashTransactionInfo.Controls.Add(this.labelControl7);
            this.groupControlCashTransactionInfo.Controls.Add(this.labelControl6);
            this.groupControlCashTransactionInfo.Controls.Add(this.textEdit8);
            this.groupControlCashTransactionInfo.Controls.Add(this.txtDate);
            this.groupControlCashTransactionInfo.Controls.Add(this.textEdit9);
            this.groupControlCashTransactionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlCashTransactionInfo.Location = new System.Drawing.Point(0, 136);
            this.groupControlCashTransactionInfo.Name = "groupControlCashTransactionInfo";
            this.groupControlCashTransactionInfo.Size = new System.Drawing.Size(380, 207);
            this.groupControlCashTransactionInfo.TabIndex = 3;
            this.groupControlCashTransactionInfo.Text = "Cash Transaction Info";
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
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 1;
            // 
            // textEdit9
            // 
            this.textEdit9.Location = new System.Drawing.Point(136, 75);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Size = new System.Drawing.Size(236, 74);
            this.textEdit9.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Document Number :";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(136, 23);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(156, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // groupControlCashAccountInfo
            // 
            this.groupControlCashAccountInfo.Controls.Add(this.btnClose);
            this.groupControlCashAccountInfo.Controls.Add(this.btnDelete);
            this.groupControlCashAccountInfo.Controls.Add(this.btnSave);
            this.groupControlCashAccountInfo.Controls.Add(this.labelControl3);
            this.groupControlCashAccountInfo.Controls.Add(this.labelControl2);
            this.groupControlCashAccountInfo.Controls.Add(this.labelControl1);
            this.groupControlCashAccountInfo.Controls.Add(this.textEdit3);
            this.groupControlCashAccountInfo.Controls.Add(this.textEdit1);
            this.groupControlCashAccountInfo.Controls.Add(this.textEdit2);
            this.groupControlCashAccountInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlCashAccountInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlCashAccountInfo.Name = "groupControlCashAccountInfo";
            this.groupControlCashAccountInfo.Size = new System.Drawing.Size(380, 136);
            this.groupControlCashAccountInfo.TabIndex = 2;
            this.groupControlCashAccountInfo.Text = "Cash Account Info";
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::ERPin.Properties.Resources.Close24x24;
            this.btnClose.ImageOptions.ImageUri.Uri = "Close";
            this.btnClose.Location = new System.Drawing.Point(297, 59);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(136, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Inflow Cash";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(224, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Outflow Cash";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // frmCashTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 343);
            this.Controls.Add(this.groupControlCashTransactionInfo);
            this.Controls.Add(this.groupControlCashAccountInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCashTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cash Transfer";
            this.Load += new System.EventHandler(this.frmCashTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCashTransactionInfo)).EndInit();
            this.groupControlCashTransactionInfo.ResumeLayout(false);
            this.groupControlCashTransactionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCashAccountInfo)).EndInit();
            this.groupControlCashAccountInfo.ResumeLayout(false);
            this.groupControlCashAccountInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.ButtonEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.GroupControl groupControlCashTransactionInfo;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private DevExpress.XtraEditors.MemoEdit textEdit9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.GroupControl groupControlCashAccountInfo;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}