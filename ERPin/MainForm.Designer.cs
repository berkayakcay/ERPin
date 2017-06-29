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
            this.barBtnMoneyTransfer = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankList = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBanking = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankingTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCashAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCashList = new DevExpress.XtraBars.BarButtonItem();
            this.barBCashTransfer = new DevExpress.XtraBars.BarButtonItem();
            this.barBCashDeposit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.rpInventory = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpCurrent = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpBank = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpCash = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpInvoice = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barBtnNebimV3Connection = new DevExpress.XtraBars.BarButtonItem();
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
            this.barBtnMoneyTransfer,
            this.barBtnBankList,
            this.barBtnBanking,
            this.barBtnBankingTransaction,
            this.barBtnCashAccount,
            this.barBtnCashList,
            this.barBCashTransfer,
            this.barBCashDeposit,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barBtnNebimV3Connection});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 34;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpInventory,
            this.rpCurrent,
            this.rpBank,
            this.rpCash,
            this.rpInvoice});
            this.ribbon.QuickToolbarItemLinks.Add(this.barBtnNebimV3Connection);
            this.ribbon.Size = new System.Drawing.Size(788, 162);
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
            // barBtnMoneyTransfer
            // 
            this.barBtnMoneyTransfer.Caption = "Money Transfer";
            this.barBtnMoneyTransfer.Id = 10;
            this.barBtnMoneyTransfer.ImageOptions.LargeImage = global::ERPin.Properties.Resources.BankTransferMoney32x32;
            this.barBtnMoneyTransfer.LargeWidth = 100;
            this.barBtnMoneyTransfer.Name = "barBtnMoneyTransfer";
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
            // barBtnCashAccount
            // 
            this.barBtnCashAccount.Caption = "Cash Account";
            this.barBtnCashAccount.Id = 14;
            this.barBtnCashAccount.ImageOptions.LargeImage = global::ERPin.Properties.Resources.CashAccount32x32;
            this.barBtnCashAccount.LargeWidth = 100;
            this.barBtnCashAccount.Name = "barBtnCashAccount";
            this.barBtnCashAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCashAccount_ItemClick);
            // 
            // barBtnCashList
            // 
            this.barBtnCashList.Caption = "Cash List";
            this.barBtnCashList.Id = 15;
            this.barBtnCashList.ImageOptions.LargeImage = global::ERPin.Properties.Resources.CashList32x32;
            this.barBtnCashList.LargeWidth = 100;
            this.barBtnCashList.Name = "barBtnCashList";
            this.barBtnCashList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCashList_ItemClick);
            // 
            // barBCashTransfer
            // 
            this.barBCashTransfer.Caption = "Cash Transfer";
            this.barBCashTransfer.Id = 16;
            this.barBCashTransfer.ImageOptions.LargeImage = global::ERPin.Properties.Resources.CashTransfer32x32;
            this.barBCashTransfer.LargeWidth = 100;
            this.barBCashTransfer.Name = "barBCashTransfer";
            this.barBCashTransfer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBCashTransfer_ItemClick);
            // 
            // barBCashDeposit
            // 
            this.barBCashDeposit.Caption = "Cash Deposit";
            this.barBCashDeposit.Id = 17;
            this.barBCashDeposit.ImageOptions.LargeImage = global::ERPin.Properties.Resources.CashDeposit32x32;
            this.barBCashDeposit.LargeWidth = 100;
            this.barBCashDeposit.Name = "barBCashDeposit";
            this.barBCashDeposit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBCashDeposit_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Sale Invoice";
            this.barButtonItem1.Id = 18;
            this.barButtonItem1.ImageOptions.LargeImage = global::ERPin.Properties.Resources.InvoiceSale32x32;
            this.barButtonItem1.LargeWidth = 100;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sale Return Invoice";
            this.barButtonItem2.Id = 19;
            this.barButtonItem2.ImageOptions.LargeImage = global::ERPin.Properties.Resources.InvoiceSaleReturn32x32;
            this.barButtonItem2.LargeWidth = 100;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Purcase Invoice";
            this.barButtonItem3.Id = 20;
            this.barButtonItem3.ImageOptions.LargeImage = global::ERPin.Properties.Resources.InvoicePurchase32x32;
            this.barButtonItem3.LargeWidth = 100;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Purchase Return Invoice";
            this.barButtonItem4.Id = 21;
            this.barButtonItem4.ImageOptions.LargeImage = global::ERPin.Properties.Resources.InvoicePurchaseReturn32x32;
            this.barButtonItem4.LargeWidth = 100;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Sale Shipment";
            this.barButtonItem5.Id = 23;
            this.barButtonItem5.ImageOptions.LargeImage = global::ERPin.Properties.Resources.InvoiceSaleReturn32x32;
            this.barButtonItem5.LargeWidth = 100;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Purchase Shipment";
            this.barButtonItem6.Id = 24;
            this.barButtonItem6.ImageOptions.LargeImage = global::ERPin.Properties.Resources.InvoicePurchaseReturn32x32;
            this.barButtonItem6.LargeWidth = 100;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "ERPin Open Source evermore";
            this.barStaticItem1.Id = 31;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem2.Caption = "01.01.2017";
            this.barStaticItem2.Id = 32;
            this.barStaticItem2.Name = "barStaticItem2";
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
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnMoneyTransfer);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnBankList);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnBanking);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnBankingTransaction);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Bank Operations";
            // 
            // rpCash
            // 
            this.rpCash.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rpCash.Image = global::ERPin.Properties.Resources.Case32x32;
            this.rpCash.Name = "rpCash";
            this.rpCash.Text = "Cash";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnCashAccount);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnCashList);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBCashTransfer);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBCashDeposit);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Cash Transactions";
            // 
            // rpInvoice
            // 
            this.rpInvoice.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.rpInvoice.Image = global::ERPin.Properties.Resources.Invoice32x32;
            this.rpInvoice.Name = "rpInvoice";
            this.rpInvoice.Text = "Invoice";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Invoice Operations";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Shipment Operations";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 604);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(788, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barBtnNebimV3Connection
            // 
            this.barBtnNebimV3Connection.Caption = "NebimV3 Connection";
            this.barBtnNebimV3Connection.Id = 33;
            this.barBtnNebimV3Connection.Name = "barBtnNebimV3Connection";
            this.barBtnNebimV3Connection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNebimV3Connection_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 635);
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
        private DevExpress.XtraBars.BarButtonItem barBtnMoneyTransfer;
        private DevExpress.XtraBars.BarButtonItem barBtnBankList;
        private DevExpress.XtraBars.BarButtonItem barBtnBanking;
        private DevExpress.XtraBars.BarButtonItem barBtnBankingTransaction;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCash;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barBtnCashAccount;
        private DevExpress.XtraBars.BarButtonItem barBtnCashList;
        private DevExpress.XtraBars.BarButtonItem barBCashTransfer;
        private DevExpress.XtraBars.BarButtonItem barBCashDeposit;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpInvoice;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarButtonItem barBtnNebimV3Connection;
    }
}