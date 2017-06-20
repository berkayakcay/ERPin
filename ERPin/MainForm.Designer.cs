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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barBtnCurrAcc = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCurrAccGroup = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCurrAccList = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCurrAccTransaction = new DevExpress.XtraBars.BarButtonItem();
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
            this.barBtnCurrAccTransaction});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(816, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnInventoryItem
            // 
            this.barBtnInventoryItem.Caption = "Inventory Item";
            this.barBtnInventoryItem.Id = 1;
            this.barBtnInventoryItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryItem.ImageOptions.Image")));
            this.barBtnInventoryItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryItem.ImageOptions.LargeImage")));
            this.barBtnInventoryItem.Name = "barBtnInventoryItem";
            this.barBtnInventoryItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnInventoryItem_ItemClick);
            // 
            // barBtnInventoryList
            // 
            this.barBtnInventoryList.Caption = "Inventory List";
            this.barBtnInventoryList.Id = 2;
            this.barBtnInventoryList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryList.ImageOptions.Image")));
            this.barBtnInventoryList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryList.ImageOptions.LargeImage")));
            this.barBtnInventoryList.Name = "barBtnInventoryList";
            this.barBtnInventoryList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnInventoryList_ItemClick);
            // 
            // barBtnInventoryGroup
            // 
            this.barBtnInventoryGroup.Caption = "Inventory Group";
            this.barBtnInventoryGroup.Id = 3;
            this.barBtnInventoryGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryGroup.ImageOptions.Image")));
            this.barBtnInventoryGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryGroup.ImageOptions.LargeImage")));
            this.barBtnInventoryGroup.Name = "barBtnInventoryGroup";
            this.barBtnInventoryGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnInventoryGroup_ItemClick);
            // 
            // barBtnInventoryTransaction
            // 
            this.barBtnInventoryTransaction.Caption = "Inventory Transaction";
            this.barBtnInventoryTransaction.Id = 4;
            this.barBtnInventoryTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryTransaction.ImageOptions.Image")));
            this.barBtnInventoryTransaction.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnInventoryTransaction.ImageOptions.LargeImage")));
            this.barBtnInventoryTransaction.Name = "barBtnInventoryTransaction";
            this.barBtnInventoryTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnInventoryTransaction_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inventory";
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
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Current";
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
            // barBtnCurrAcc
            // 
            this.barBtnCurrAcc.Caption = "Currrent Account";
            this.barBtnCurrAcc.Id = 5;
            this.barBtnCurrAcc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAcc.ImageOptions.Image")));
            this.barBtnCurrAcc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAcc.ImageOptions.LargeImage")));
            this.barBtnCurrAcc.Name = "barBtnCurrAcc";
            this.barBtnCurrAcc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCurrAcc_ItemClick);
            // 
            // barBtnCurrAccGroup
            // 
            this.barBtnCurrAccGroup.Caption = "Current Account Group";
            this.barBtnCurrAccGroup.Id = 6;
            this.barBtnCurrAccGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAccGroup.ImageOptions.Image")));
            this.barBtnCurrAccGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAccGroup.ImageOptions.LargeImage")));
            this.barBtnCurrAccGroup.Name = "barBtnCurrAccGroup";
            this.barBtnCurrAccGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCurrAccGroup_ItemClick);
            // 
            // barBtnCurrAccList
            // 
            this.barBtnCurrAccList.Caption = "Current Account List";
            this.barBtnCurrAccList.Id = 7;
            this.barBtnCurrAccList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAccList.ImageOptions.Image")));
            this.barBtnCurrAccList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAccList.ImageOptions.LargeImage")));
            this.barBtnCurrAccList.Name = "barBtnCurrAccList";
            this.barBtnCurrAccList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCurrAccList_ItemClick);
            // 
            // barBtnCurrAccTransaction
            // 
            this.barBtnCurrAccTransaction.Caption = "Current Account Transaction";
            this.barBtnCurrAccTransaction.Id = 8;
            this.barBtnCurrAccTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAccTransaction.ImageOptions.Image")));
            this.barBtnCurrAccTransaction.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCurrAccTransaction.ImageOptions.LargeImage")));
            this.barBtnCurrAccTransaction.Name = "barBtnCurrAccTransaction";
            this.barBtnCurrAccTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCurrAccTransaction_ItemClick);
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnInventoryItem;
        private DevExpress.XtraBars.BarButtonItem barBtnInventoryList;
        private DevExpress.XtraBars.BarButtonItem barBtnInventoryGroup;
        private DevExpress.XtraBars.BarButtonItem barBtnInventoryTransaction;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtnCurrAcc;
        private DevExpress.XtraBars.BarButtonItem barBtnCurrAccGroup;
        private DevExpress.XtraBars.BarButtonItem barBtnCurrAccList;
        private DevExpress.XtraBars.BarButtonItem barBtnCurrAccTransaction;
    }
}