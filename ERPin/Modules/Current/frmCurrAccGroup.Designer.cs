namespace ERPin.Modules.Current
{
    partial class frmCurrAccGroup
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
            this.gcCurrAccInfo = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGroupName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtGroupCode = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcListe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcCurrAccInfo)).BeginInit();
            this.gcCurrAccInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcCurrAccInfo
            // 
            this.gcCurrAccInfo.Controls.Add(this.labelControl2);
            this.gcCurrAccInfo.Controls.Add(this.txtGroupName);
            this.gcCurrAccInfo.Controls.Add(this.labelControl1);
            this.gcCurrAccInfo.Controls.Add(this.txtGroupCode);
            this.gcCurrAccInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCurrAccInfo.Location = new System.Drawing.Point(0, 0);
            this.gcCurrAccInfo.Name = "gcCurrAccInfo";
            this.gcCurrAccInfo.Size = new System.Drawing.Size(260, 92);
            this.gcCurrAccInfo.TabIndex = 2;
            this.gcCurrAccInfo.Text = "Current Account Info";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Current Name :";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(90, 62);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(160, 20);
            this.txtGroupName.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Current Code :";
            // 
            // txtGroupCode
            // 
            this.txtGroupCode.Location = new System.Drawing.Point(90, 36);
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.Size = new System.Drawing.Size(160, 20);
            this.txtGroupCode.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcListe);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 92);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(260, 231);
            this.groupControl2.TabIndex = 3;
            // 
            // gcListe
            // 
            this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcListe.Location = new System.Drawing.Point(2, 20);
            this.gcListe.MainView = this.gridView1;
            this.gcListe.Name = "gcListe";
            this.gcListe.Size = new System.Drawing.Size(256, 209);
            this.gcListe.TabIndex = 0;
            this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.GroupCode,
            this.GroupName});
            this.gridView1.GridControl = this.gcListe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // GroupCode
            // 
            this.GroupCode.Caption = "Group Code";
            this.GroupCode.FieldName = "GroupCode";
            this.GroupCode.Name = "GroupCode";
            this.GroupCode.OptionsColumn.AllowEdit = false;
            this.GroupCode.OptionsColumn.AllowFocus = false;
            this.GroupCode.OptionsColumn.FixedWidth = true;
            this.GroupCode.Visible = true;
            this.GroupCode.VisibleIndex = 0;
            this.GroupCode.Width = 50;
            // 
            // GroupName
            // 
            this.GroupName.Caption = "Group Name";
            this.GroupName.FieldName = "GroupName";
            this.GroupName.Name = "GroupName";
            this.GroupName.OptionsColumn.AllowEdit = false;
            this.GroupName.OptionsColumn.AllowFocus = false;
            this.GroupName.OptionsColumn.FixedWidth = true;
            this.GroupName.Visible = true;
            this.GroupName.VisibleIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = global::ERPin.Properties.Resources.Close24x24;
            this.btnClose.ImageOptions.ImageUri.Uri = "Close";
            this.btnClose.Location = new System.Drawing.Point(173, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(92, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 50);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageOptions.ImageUri.Uri = "Save";
            this.btnSave.Location = new System.Drawing.Point(11, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnClose);
            this.groupControl3.Controls.Add(this.btnDelete);
            this.groupControl3.Controls.Add(this.btnSave);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 323);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(260, 86);
            this.groupControl3.TabIndex = 4;
            // 
            // frmCurrAccGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 409);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gcCurrAccInfo);
            this.Controls.Add(this.groupControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCurrAccGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrAccGroup";
            this.Load += new System.EventHandler(this.frmCurrAccGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCurrAccInfo)).EndInit();
            this.gcCurrAccInfo.ResumeLayout(false);
            this.gcCurrAccInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcCurrAccInfo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGroupName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtGroupCode;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn GroupCode;
        private DevExpress.XtraGrid.Columns.GridColumn GroupName;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}