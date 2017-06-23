namespace ERPin
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnInventoryItem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnInventoryList = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnInventoryGroup = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnInventoryTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCurrAcc = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCurrAccGroup = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCurrAccList = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCurrAccTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankAcc = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTransferMoney = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankList = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBanking = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankingTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.rpInventory = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpCurrent = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpBank = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnInventoryItem,
            this.barBtnInventoryList,
            this.barBtnInventoryGroup,
            this.barBtnInventoryTransaction,
            this.barBtnCurrAcc,
            this.barBtnCurrAccGroup,
            this.barBtnCurrAccList,
            this.barBtnCurrAccTransaction,
            this.barBtnBankAcc,
            this.barBtnTransferMoney,
            this.barBtnBankList,
            this.barBtnBanking,
            this.barBtnBankingTransaction});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpInventory,
            this.rpCurrent,
            this.rpBank});
            this.ribbon.Size = new System.Drawing.Size(816, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnInventoryItem
            // 
            this.barBtnInventoryItem.Caption = "Inventory Item";
            this.barBtnInventoryItem.Id = 1;
            this.barBtnInventoryItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryItem.ImageOptions.Image")));
            this.barBtnInventoryItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryItem.ImageOptions.LargeImage")));
            this.barBtnInventoryItem.LargeWidth = 100;
            this.barBtnInventoryItem.Name = "barBtnInventoryItem";
            this.barBtnInventoryItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnInventoryItem_ItemClick);
            // 
            // barBtnInventoryList
            // 
            this.barBtnInventoryList.Caption = "Inventory List";
            this.barBtnInventoryList.Id = 2;
            this.barBtnInventoryList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryList.ImageOptions.Image")));
            this.barBtnInventoryList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryList.ImageOptions.LargeImage")));
            this.barBtnInventoryList.LargeWidth = 100;
            this.barBtnInventoryList.Name = "barBtnInventoryList";
            this.barBtnInventoryList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnInventoryList_ItemClick);
            // 
            // barBtnInventoryGroup
            // 
            this.barBtnInventoryGroup.Caption = "Inventory Group";
            this.barBtnInventoryGroup.Id = 3;
            this.barBtnInventoryGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryGroup.ImageOptions.Image")));
            this.barBtnInventoryGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryGroup.ImageOptions.LargeImage")));
            this.barBtnInventoryGroup.LargeWidth = 100;
            this.barBtnInventoryGroup.Name = "barBtnInventoryGroup";
            this.barBtnInventoryGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnInventoryGroup_ItemClick);
            // 
            // barBtnInventoryTransaction
            // 
            this.barBtnInventoryTransaction.Caption = "Inventory Transaction";
            this.barBtnInventoryTransaction.Id = 4;
            this.barBtnInventoryTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryTransaction.ImageOptions.Image")));
            this.barBtnInventoryTransaction.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryTransaction.ImageOptions.LargeImage")));
            this.barBtnInventoryTransaction.LargeWidth = 100;
            this.barBtnInventoryTransaction.Name = "barBtnInventoryTransaction";
            this.barBtnInventoryTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnInventoryTransaction_ItemClick);
            // 
            // barBtnCurrAcc
            // 
            this.barBtnCurrAcc.Caption = "Currrent Account";
            this.barBtnCurrAcc.Id = 5;
            this.barBtnCurrAcc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAcc.ImageOptions.Image")));
            this.barBtnCurrAcc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAcc.ImageOptions.LargeImage")));
            this.barBtnCurrAcc.LargeWidth = 100;
            this.barBtnCurrAcc.Name = "barBtnCurrAcc";
            this.barBtnCurrAcc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCurrAcc_ItemClick);
            // 
            // barBtnCurrAccGroup
            // 
            this.barBtnCurrAccGroup.Caption = "Current Account Group";
            this.barBtnCurrAccGroup.Id = 6;
            this.barBtnCurrAccGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAccGroup.ImageOptions.Image")));
            this.barBtnCurrAccGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAccGroup.ImageOptions.LargeImage")));
            this.barBtnCurrAccGroup.LargeWidth = 100;
            this.barBtnCurrAccGroup.Name = "barBtnCurrAccGroup";
            this.barBtnCurrAccGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCurrAccGroup_ItemClick);
            // 
            // barBtnCurrAccList
            // 
            this.barBtnCurrAccList.Caption = "Current Account List";
            this.barBtnCurrAccList.Id = 7;
            this.barBtnCurrAccList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAccList.ImageOptions.Image")));
            this.barBtnCurrAccList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAccList.ImageOptions.LargeImage")));
            this.barBtnCurrAccList.LargeWidth = 100;
            this.barBtnCurrAccList.Name = "barBtnCurrAccList";
            this.barBtnCurrAccList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCurrAccList_ItemClick);
            // 
            // barBtnCurrAccTransaction
            // 
            this.barBtnCurrAccTransaction.Caption = "Current Account Transaction";
            this.barBtnCurrAccTransaction.Id = 8;
            this.barBtnCurrAccTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAccTransaction.ImageOptions.Image")));
            this.barBtnCurrAccTransaction.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAccTransaction.ImageOptions.LargeImage")));
            this.barBtnCurrAccTransaction.LargeWidth = 100;
            this.barBtnCurrAccTransaction.Name = "barBtnCurrAccTransaction";
            this.barBtnCurrAccTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCurrAccTransaction_ItemClick);
            // 
            // barBtnBankAcc
            // 
            this.barBtnBankAcc.Caption = "Bank Account";
            this.barBtnBankAcc.Id = 9;
            this.barBtnBankAcc.ImageOptions.LargeImage = global::ERPin.Properties.Resources.BankAccount32x32;
            this.barBtnBankAcc.LargeWidth = 100;
            this.barBtnBankAcc.Name = "barBtnBankAcc";
            // 
            // barBtnTransferMoney
            // 
            this.barBtnTransferMoney.Caption = "Transfer Money";
            this.barBtnTransferMoney.Id = 10;
            this.barBtnTransferMoney.ImageOptions.LargeImage = global::ERPin.Properties.Resources.BankTransferMoney32x32;
            this.barBtnTransferMoney.LargeWidth = 100;
            this.barBtnTransferMoney.Name = "barBtnTransferMoney";
            // 
            // barBtnBankList
            // 
            this.barBtnBankList.Caption = "Bank List";
            this.barBtnBankList.Id = 11;
            this.barBtnBankList.ImageOptions.LargeImage = global::ERPin.Properties.Resources.BankList32x32;
            this.barBtnBankList.LargeWidth = 100;
            this.barBtnBankList.Name = "barBtnBankList";
            // 
            // barBtnBanking
            // 
            this.barBtnBanking.Caption = "Banking";
            this.barBtnBanking.Id = 12;
            this.barBtnBanking.ImageOptions.LargeImage = global::ERPin.Properties.Resources.Banking32x32;
            this.barBtnBanking.LargeWidth = 100;
            this.barBtnBanking.Name = "barBtnBanking";
            // 
            // barBtnBankingTransaction
            // 
            this.barBtnBankingTransaction.Caption = "Banking Transaction";
            this.barBtnBankingTransaction.Id = 13;
            this.barBtnBankingTransaction.ImageOptions.LargeImage = global::ERPin.Properties.Resources.BankingTransaction32x32;
            this.barBtnBankingTransaction.LargeWidth = 100;
            this.barBtnBankingTransaction.Name = "barBtnBankingTransaction";
            // 
            // rpInventory
            // 
            this.rpInventory.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpInventory.Image = ((System.Drawing.Image)(resources.GetObject("rpInventory.Image")));
            this.rpInventory.Name = "rpInventory";
            this.rpInventory.Text = "Inventory";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnInventoryItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnInventoryList);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnInventoryGroup);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnInventoryTransaction);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Intentory Operations";
            // 
            // rpCurrent
            // 
            this.rpCurrent.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rpCurrent.Image = ((System.Drawing.Image)(resources.GetObject("rpCurrent.Image")));
            this.rpCurrent.Name = "rpCurrent";
            this.rpCurrent.Text = "Current";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCurrAcc);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCurrAccGroup);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCurrAccList);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCurrAccTransaction);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Current Operations";
            // 
            // rpBank
            // 
            this.rpBank.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rpBank.Image = global::ERPin.Properties.Resources.Bank32x32;
            this.rpBank.Name = "rpBank";
            this.rpBank.Text = "Bank";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnBankAcc);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnTransferMoney);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnBankList);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnBanking);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnBankingTransaction);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Bank Operations";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 604);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(816, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 635);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ERPin";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpInventory;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnInventoryItem;
        private DevExpress.XtraBars.BarButtonItem barBtnInventoryList;
        private DevExpress.XtraBars.BarButtonItem barBtnInventoryGroup;
        private DevExpress.XtraBars.BarButtonItem barBtnInventoryTransaction;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCurrent;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtnCurrAcc;
        private DevExpress.XtraBars.BarButtonItem barBtnCurrAccGroup;
        private DevExpress.XtraBars.BarButtonItem barBtnCurrAccList;
        private DevExpress.XtraBars.BarButtonItem barBtnCurrAccTransaction;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpBank;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barBtnBankAcc;
        private DevExpress.XtraBars.BarButtonItem barBtnTransferMoney;
        private DevExpress.XtraBars.BarButtonItem barBtnBankList;
        private DevExpress.XtraBars.BarButtonItem barBtnBanking;
        private DevExpress.XtraBars.BarButtonItem barBtnBankingTransaction;
    }
}