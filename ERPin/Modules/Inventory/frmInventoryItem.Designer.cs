namespace ERPin.Modules.Stock
{
    partial class FrmInventoryItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventoryItem));
            this.groupControlInventory = new DevExpress.XtraEditors.GroupControl();
            this.btnAddPicture = new DevExpress.XtraEditors.SimpleButton();
            this.pbItemPicture = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtItemCode = new DevExpress.XtraEditors.ButtonEdit();
            this.txtItemName = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControlTax = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaleTax = new DevExpress.XtraEditors.TextEdit();
            this.txtPurchaseTax = new DevExpress.XtraEditors.TextEdit();
            this.groupControlPrice = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPurchasePrice = new DevExpress.XtraEditors.TextEdit();
            this.groupControlUnit = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.txtUnit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControlGroup = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGroupName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtGroupCode = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInventory)).BeginInit();
            this.groupControlInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTax)).BeginInit();
            this.groupControlTax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPrice)).BeginInit();
            this.groupControlPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUnit)).BeginInit();
            this.groupControlUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGroup)).BeginInit();
            this.groupControlGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlInventory
            // 
            this.groupControlInventory.Controls.Add(this.btnAddPicture);
            this.groupControlInventory.Controls.Add(this.pbItemPicture);
            this.groupControlInventory.Controls.Add(this.labelControl2);
            this.groupControlInventory.Controls.Add(this.labelControl1);
            this.groupControlInventory.Controls.Add(this.txtItemCode);
            this.groupControlInventory.Controls.Add(this.txtItemName);
            this.groupControlInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlInventory.Location = new System.Drawing.Point(0, 0);
            this.groupControlInventory.Name = "groupControlInventory";
            this.groupControlInventory.Size = new System.Drawing.Size(412, 114);
            this.groupControlInventory.TabIndex = 0;
            this.groupControlInventory.Text = "Inventory Info";
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(233, 85);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(67, 24);
            this.btnAddPicture.TabIndex = 7;
            this.btnAddPicture.Text = "Add Picture";
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // pbItemPicture
            // 
            this.pbItemPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbItemPicture.Location = new System.Drawing.Point(306, 20);
            this.pbItemPicture.Name = "pbItemPicture";
            this.pbItemPicture.Size = new System.Drawing.Size(104, 92);
            this.pbItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbItemPicture.TabIndex = 6;
            this.pbItemPicture.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Item Name :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Item Code :";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(82, 33);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtItemCode.Size = new System.Drawing.Size(218, 20);
            this.txtItemCode.TabIndex = 0;
            this.txtItemCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtItemCode_ButtonClick);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(82, 59);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(218, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnClose);
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 323);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(412, 94);
            this.groupControl2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = global::ERPin.Properties.Resources.Close24x24;
            this.btnClose.ImageOptions.ImageUri.Uri = "Close";
            this.btnClose.Location = new System.Drawing.Point(325, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cancel";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(244, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageOptions.ImageUri.Uri = "Save";
            this.btnSave.Location = new System.Drawing.Point(163, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupControlTax);
            this.groupControl3.Controls.Add(this.groupControlPrice);
            this.groupControl3.Controls.Add(this.groupControlUnit);
            this.groupControl3.Controls.Add(this.groupControlGroup);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 114);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(412, 209);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Inventory Item Detail";
            // 
            // groupControlTax
            // 
            this.groupControlTax.Controls.Add(this.labelControl9);
            this.groupControlTax.Controls.Add(this.labelControl10);
            this.groupControlTax.Controls.Add(this.txtSaleTax);
            this.groupControlTax.Controls.Add(this.txtPurchaseTax);
            this.groupControlTax.Location = new System.Drawing.Point(261, 109);
            this.groupControlTax.Name = "groupControlTax";
            this.groupControlTax.Size = new System.Drawing.Size(145, 80);
            this.groupControlTax.TabIndex = 2;
            this.groupControlTax.Text = "Tax Info";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 54);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(27, 13);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "Sale :";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 28);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(54, 13);
            this.labelControl10.TabIndex = 12;
            this.labelControl10.Text = "Purchase  :";
            // 
            // txtSaleTax
            // 
            this.txtSaleTax.Location = new System.Drawing.Point(82, 51);
            this.txtSaleTax.Name = "txtSaleTax";
            this.txtSaleTax.Properties.Mask.EditMask = "P0";
            this.txtSaleTax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaleTax.Size = new System.Drawing.Size(58, 20);
            this.txtSaleTax.TabIndex = 1;
            // 
            // txtPurchaseTax
            // 
            this.txtPurchaseTax.Location = new System.Drawing.Point(82, 25);
            this.txtPurchaseTax.Name = "txtPurchaseTax";
            this.txtPurchaseTax.Properties.Mask.EditMask = "P0";
            this.txtPurchaseTax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPurchaseTax.Size = new System.Drawing.Size(58, 20);
            this.txtPurchaseTax.TabIndex = 0;
            // 
            // groupControlPrice
            // 
            this.groupControlPrice.Controls.Add(this.labelControl8);
            this.groupControlPrice.Controls.Add(this.txtSalePrice);
            this.groupControlPrice.Controls.Add(this.labelControl7);
            this.groupControlPrice.Controls.Add(this.txtPurchasePrice);
            this.groupControlPrice.Location = new System.Drawing.Point(261, 23);
            this.groupControlPrice.Name = "groupControlPrice";
            this.groupControlPrice.Size = new System.Drawing.Size(145, 80);
            this.groupControlPrice.TabIndex = 1;
            this.groupControlPrice.Text = "Price Info";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 29);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Purchase :";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(82, 51);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Properties.Mask.EditMask = "c";
            this.txtSalePrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSalePrice.Size = new System.Drawing.Size(58, 20);
            this.txtSalePrice.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 55);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Sale :";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(82, 25);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Properties.Mask.EditMask = "c";
            this.txtPurchasePrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPurchasePrice.Size = new System.Drawing.Size(58, 20);
            this.txtPurchasePrice.TabIndex = 0;
            // 
            // groupControlUnit
            // 
            this.groupControlUnit.Controls.Add(this.labelControl5);
            this.groupControlUnit.Controls.Add(this.labelControl6);
            this.groupControlUnit.Controls.Add(this.txtBarcode);
            this.groupControlUnit.Controls.Add(this.txtUnit);
            this.groupControlUnit.Location = new System.Drawing.Point(5, 109);
            this.groupControlUnit.Name = "groupControlUnit";
            this.groupControlUnit.Size = new System.Drawing.Size(250, 80);
            this.groupControlUnit.TabIndex = 1;
            this.groupControlUnit.Text = "Unit Info";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 54);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Barcode :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 28);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(26, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Unit :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(82, 51);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(150, 20);
            this.txtBarcode.TabIndex = 1;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(82, 25);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUnit.Properties.Items.AddRange(new object[] {
            "N",
            "KG",
            "M"});
            this.txtUnit.Size = new System.Drawing.Size(150, 20);
            this.txtUnit.TabIndex = 0;
            // 
            // groupControlGroup
            // 
            this.groupControlGroup.Controls.Add(this.labelControl3);
            this.groupControlGroup.Controls.Add(this.txtGroupName);
            this.groupControlGroup.Controls.Add(this.labelControl4);
            this.groupControlGroup.Controls.Add(this.txtGroupCode);
            this.groupControlGroup.Location = new System.Drawing.Point(5, 23);
            this.groupControlGroup.Name = "groupControlGroup";
            this.groupControlGroup.Size = new System.Drawing.Size(250, 80);
            this.groupControlGroup.TabIndex = 0;
            this.groupControlGroup.Text = "Group Info";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Group Code :";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(82, 51);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(150, 20);
            this.txtGroupName.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Group Name :";
            // 
            // txtGroupCode
            // 
            this.txtGroupCode.Location = new System.Drawing.Point(82, 25);
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtGroupCode.Size = new System.Drawing.Size(150, 20);
            this.txtGroupCode.TabIndex = 0;
            this.txtGroupCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtGroupCode_ButtonClick);
            // 
            // frmInventoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 417);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControlInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInventoryItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Item";
            this.Load += new System.EventHandler(this.frmInventoryItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInventory)).EndInit();
            this.groupControlInventory.ResumeLayout(false);
            this.groupControlInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTax)).EndInit();
            this.groupControlTax.ResumeLayout(false);
            this.groupControlTax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPrice)).EndInit();
            this.groupControlPrice.ResumeLayout(false);
            this.groupControlPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUnit)).EndInit();
            this.groupControlUnit.ResumeLayout(false);
            this.groupControlUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGroup)).EndInit();
            this.groupControlGroup.ResumeLayout(false);
            this.groupControlGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlInventory;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnAddPicture;
        private System.Windows.Forms.PictureBox pbItemPicture;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit txtGroupCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit txtItemCode;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.TextEdit txtGroupName;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControlTax;
        private DevExpress.XtraEditors.GroupControl groupControlPrice;
        private DevExpress.XtraEditors.GroupControl groupControlUnit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.GroupControl groupControlGroup;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtSaleTax;
        private DevExpress.XtraEditors.TextEdit txtPurchaseTax;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtSalePrice;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPurchasePrice;
        private DevExpress.XtraEditors.ComboBoxEdit txtUnit;
    }
}