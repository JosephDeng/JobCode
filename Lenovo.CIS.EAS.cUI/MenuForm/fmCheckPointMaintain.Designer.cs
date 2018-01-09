namespace Lenovo.CIS.EAS.cUI
{
    partial class fmCheckPointMaintain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCheckPointMaintain));
            this.barManager = new DevExpress.XtraBars.BarManager();
            this.bar_mainMenu = new DevExpress.XtraBars.Bar();
            this.barbtn_refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_add = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_save = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_delete = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rg_status = new DevExpress.XtraEditors.RadioGroup();
            this.txt_address = new DevExpress.XtraEditors.MemoEdit();
            this.txt_scheduleAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txt_examAddress = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lc_addressItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lc_scheduleAddressItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.lc_examAddressItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.lc_StatusItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.gdc_addressInfo = new DevExpress.XtraGrid.GridControl();
            this.gdv_addressInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_scheduleAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_ExamAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_operateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_operator = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rg_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scheduleAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_examAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_addressItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_scheduleAddressItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_examAddressItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_StatusItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdc_addressInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_addressInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar_mainMenu});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtn_refresh,
            this.barbtn_add,
            this.barbtn_save,
            this.barbtn_delete,
            this.barbtn_exit});
            this.barManager.MainMenu = this.bar_mainMenu;
            this.barManager.MaxItemId = 5;
            // 
            // bar_mainMenu
            // 
            this.bar_mainMenu.BarName = "Main menu";
            this.bar_mainMenu.DockCol = 0;
            this.bar_mainMenu.DockRow = 0;
            this.bar_mainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar_mainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtn_refresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtn_add, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtn_save, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtn_delete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtn_exit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar_mainMenu.OptionsBar.MultiLine = true;
            this.bar_mainMenu.OptionsBar.UseWholeRow = true;
            this.bar_mainMenu.Text = "Main menu";
            // 
            // barbtn_refresh
            // 
            this.barbtn_refresh.Caption = "刷新";
            this.barbtn_refresh.Id = 0;
            this.barbtn_refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtn_refresh.ImageOptions.Image")));
            this.barbtn_refresh.ImageOptions.LargeImageIndex = 22;
            this.barbtn_refresh.Name = "barbtn_refresh";
            this.barbtn_refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_refresh_ItemClick);
            // 
            // barbtn_add
            // 
            this.barbtn_add.Caption = "新增";
            this.barbtn_add.Id = 1;
            this.barbtn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtn_add.ImageOptions.Image")));
            this.barbtn_add.ImageOptions.LargeImageIndex = 190;
            this.barbtn_add.Name = "barbtn_add";
            this.barbtn_add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_add_ItemClick);
            // 
            // barbtn_save
            // 
            this.barbtn_save.Caption = "保存";
            this.barbtn_save.Id = 2;
            this.barbtn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtn_save.ImageOptions.Image")));
            this.barbtn_save.ImageOptions.LargeImageIndex = 1;
            this.barbtn_save.Name = "barbtn_save";
            this.barbtn_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_save_ItemClick);
            // 
            // barbtn_delete
            // 
            this.barbtn_delete.Caption = "删除";
            this.barbtn_delete.Id = 3;
            this.barbtn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtn_delete.ImageOptions.Image")));
            this.barbtn_delete.ImageOptions.LargeImageIndex = 18;
            this.barbtn_delete.Name = "barbtn_delete";
            this.barbtn_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_delete_ItemClick);
            // 
            // barbtn_exit
            // 
            this.barbtn_exit.Caption = "退出";
            this.barbtn_exit.Id = 4;
            this.barbtn_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtn_exit.ImageOptions.Image")));
            this.barbtn_exit.ImageOptions.LargeImageIndex = 27;
            this.barbtn_exit.Name = "barbtn_exit";
            this.barbtn_exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_exit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1157, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 496);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1157, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 456);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1157, 40);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 456);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 40);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gdc_addressInfo);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1157, 456);
            this.splitContainerControl1.SplitterPosition = 354;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.rg_status);
            this.layoutControl1.Controls.Add(this.txt_address);
            this.layoutControl1.Controls.Add(this.txt_scheduleAddress);
            this.layoutControl1.Controls.Add(this.txt_examAddress);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup;
            this.layoutControl1.Size = new System.Drawing.Size(354, 456);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rg_status
            // 
            this.rg_status.Location = new System.Drawing.Point(75, 181);
            this.rg_status.MenuManager = this.barManager;
            this.rg_status.Name = "rg_status";
            this.rg_status.Properties.Columns = 2;
            this.rg_status.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "启用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0", "停用")});
            this.rg_status.Size = new System.Drawing.Size(267, 25);
            this.rg_status.StyleController = this.layoutControl1;
            this.rg_status.TabIndex = 7;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(75, 12);
            this.txt_address.MenuManager = this.barManager;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(267, 36);
            this.txt_address.StyleController = this.layoutControl1;
            this.txt_address.TabIndex = 4;
            // 
            // txt_scheduleAddress
            // 
            this.txt_scheduleAddress.Location = new System.Drawing.Point(75, 52);
            this.txt_scheduleAddress.MenuManager = this.barManager;
            this.txt_scheduleAddress.Name = "txt_scheduleAddress";
            this.txt_scheduleAddress.Size = new System.Drawing.Size(267, 61);
            this.txt_scheduleAddress.StyleController = this.layoutControl1;
            this.txt_scheduleAddress.TabIndex = 5;
            // 
            // txt_examAddress
            // 
            this.txt_examAddress.Location = new System.Drawing.Point(75, 117);
            this.txt_examAddress.MenuManager = this.barManager;
            this.txt_examAddress.Name = "txt_examAddress";
            this.txt_examAddress.Size = new System.Drawing.Size(267, 60);
            this.txt_examAddress.StyleController = this.layoutControl1;
            this.txt_examAddress.TabIndex = 6;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lc_addressItem,
            this.emptySpaceItem1,
            this.lc_scheduleAddressItem,
            this.lc_examAddressItem,
            this.lc_StatusItem});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(354, 456);
            this.layoutControlGroup.TextVisible = false;
            // 
            // lc_addressItem
            // 
            this.lc_addressItem.Control = this.txt_address;
            this.lc_addressItem.Location = new System.Drawing.Point(0, 0);
            this.lc_addressItem.MaxSize = new System.Drawing.Size(334, 40);
            this.lc_addressItem.MinSize = new System.Drawing.Size(334, 40);
            this.lc_addressItem.Name = "lc_addressItem";
            this.lc_addressItem.Size = new System.Drawing.Size(334, 40);
            this.lc_addressItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lc_addressItem.Text = "地点名称：";
            this.lc_addressItem.TextSize = new System.Drawing.Size(60, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 198);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(334, 238);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lc_scheduleAddressItem
            // 
            this.lc_scheduleAddressItem.Control = this.txt_scheduleAddress;
            this.lc_scheduleAddressItem.Location = new System.Drawing.Point(0, 40);
            this.lc_scheduleAddressItem.MaxSize = new System.Drawing.Size(334, 65);
            this.lc_scheduleAddressItem.MinSize = new System.Drawing.Size(334, 65);
            this.lc_scheduleAddressItem.Name = "lc_scheduleAddressItem";
            this.lc_scheduleAddressItem.Size = new System.Drawing.Size(334, 65);
            this.lc_scheduleAddressItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lc_scheduleAddressItem.Text = "预约地点：";
            this.lc_scheduleAddressItem.TextSize = new System.Drawing.Size(60, 14);
            // 
            // lc_examAddressItem
            // 
            this.lc_examAddressItem.Control = this.txt_examAddress;
            this.lc_examAddressItem.Location = new System.Drawing.Point(0, 105);
            this.lc_examAddressItem.MaxSize = new System.Drawing.Size(334, 64);
            this.lc_examAddressItem.MinSize = new System.Drawing.Size(334, 64);
            this.lc_examAddressItem.Name = "lc_examAddressItem";
            this.lc_examAddressItem.Size = new System.Drawing.Size(334, 64);
            this.lc_examAddressItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lc_examAddressItem.Text = "检查地点：";
            this.lc_examAddressItem.TextSize = new System.Drawing.Size(60, 14);
            // 
            // lc_StatusItem
            // 
            this.lc_StatusItem.Control = this.rg_status;
            this.lc_StatusItem.Location = new System.Drawing.Point(0, 169);
            this.lc_StatusItem.MaxSize = new System.Drawing.Size(0, 29);
            this.lc_StatusItem.MinSize = new System.Drawing.Size(117, 29);
            this.lc_StatusItem.Name = "lc_StatusItem";
            this.lc_StatusItem.Size = new System.Drawing.Size(334, 29);
            this.lc_StatusItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lc_StatusItem.Text = "状态：";
            this.lc_StatusItem.TextSize = new System.Drawing.Size(60, 14);
            // 
            // gdc_addressInfo
            // 
            this.gdc_addressInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdc_addressInfo.Location = new System.Drawing.Point(0, 0);
            this.gdc_addressInfo.MainView = this.gdv_addressInfo;
            this.gdc_addressInfo.MenuManager = this.barManager;
            this.gdc_addressInfo.Name = "gdc_addressInfo";
            this.gdc_addressInfo.Size = new System.Drawing.Size(798, 456);
            this.gdc_addressInfo.TabIndex = 0;
            this.gdc_addressInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdv_addressInfo});
            // 
            // gdv_addressInfo
            // 
            this.gdv_addressInfo.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gdv_addressInfo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gdv_addressInfo.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gdv_addressInfo.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gdv_addressInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_address,
            this.gc_scheduleAddress,
            this.gc_ExamAddress,
            this.gc_status,
            this.gc_operateDate,
            this.gc_operator});
            this.gdv_addressInfo.GridControl = this.gdc_addressInfo;
            this.gdv_addressInfo.Name = "gdv_addressInfo";
            this.gdv_addressInfo.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gdv_addressInfo.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gdv_addressInfo.OptionsBehavior.Editable = false;
            this.gdv_addressInfo.OptionsCustomization.AllowColumnMoving = false;
            this.gdv_addressInfo.OptionsCustomization.AllowFilter = false;
            this.gdv_addressInfo.OptionsCustomization.AllowSort = false;
            this.gdv_addressInfo.OptionsView.ColumnAutoWidth = false;
            this.gdv_addressInfo.OptionsView.ShowGroupPanel = false;
            this.gdv_addressInfo.OptionsView.ShowIndicator = false;
            this.gdv_addressInfo.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gdv_addressInfo_CustomColumnDisplayText);
            this.gdv_addressInfo.DoubleClick += new System.EventHandler(this.gdv_addressInfo_DoubleClick);
            // 
            // gc_address
            // 
            this.gc_address.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_address.Caption = "地点名称";
            this.gc_address.FieldName = "PointName";
            this.gc_address.Name = "gc_address";
            this.gc_address.Visible = true;
            this.gc_address.VisibleIndex = 0;
            this.gc_address.Width = 156;
            // 
            // gc_scheduleAddress
            // 
            this.gc_scheduleAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_scheduleAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_scheduleAddress.Caption = "预约地点";
            this.gc_scheduleAddress.FieldName = "DweingPlace";
            this.gc_scheduleAddress.Name = "gc_scheduleAddress";
            this.gc_scheduleAddress.Visible = true;
            this.gc_scheduleAddress.VisibleIndex = 1;
            this.gc_scheduleAddress.Width = 150;
            // 
            // gc_ExamAddress
            // 
            this.gc_ExamAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_ExamAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_ExamAddress.Caption = "检查地点";
            this.gc_ExamAddress.FieldName = "CheckPoint";
            this.gc_ExamAddress.Name = "gc_ExamAddress";
            this.gc_ExamAddress.Visible = true;
            this.gc_ExamAddress.VisibleIndex = 2;
            this.gc_ExamAddress.Width = 162;
            // 
            // gc_status
            // 
            this.gc_status.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_status.Caption = "状态";
            this.gc_status.FieldName = "State";
            this.gc_status.Name = "gc_status";
            this.gc_status.Visible = true;
            this.gc_status.VisibleIndex = 3;
            this.gc_status.Width = 103;
            // 
            // gc_operateDate
            // 
            this.gc_operateDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_operateDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_operateDate.Caption = "操作日期";
            this.gc_operateDate.FieldName = "CreateTime";
            this.gc_operateDate.Name = "gc_operateDate";
            this.gc_operateDate.Visible = true;
            this.gc_operateDate.VisibleIndex = 4;
            this.gc_operateDate.Width = 103;
            // 
            // gc_operator
            // 
            this.gc_operator.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_operator.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_operator.Caption = "操作人";
            this.gc_operator.FieldName = "CreateName";
            this.gc_operator.Name = "gc_operator";
            this.gc_operator.Visible = true;
            this.gc_operator.VisibleIndex = 5;
            this.gc_operator.Width = 123;
            // 
            // fmCheckPointMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 496);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "fmCheckPointMaintain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检查地点维护";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmCheckPointMaintain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rg_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scheduleAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_examAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_addressItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_scheduleAddressItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_examAddressItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_StatusItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdc_addressInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_addressInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar_mainMenu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barbtn_refresh;
        private DevExpress.XtraBars.BarButtonItem barbtn_add;
        private DevExpress.XtraBars.BarButtonItem barbtn_save;
        private DevExpress.XtraBars.BarButtonItem barbtn_delete;
        private DevExpress.XtraBars.BarButtonItem barbtn_exit;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.RadioGroup rg_status;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem lc_addressItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lc_scheduleAddressItem;
        private DevExpress.XtraLayout.LayoutControlItem lc_examAddressItem;
        private DevExpress.XtraLayout.LayoutControlItem lc_StatusItem;
        private DevExpress.XtraGrid.GridControl gdc_addressInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gdv_addressInfo;
        private DevExpress.XtraGrid.Columns.GridColumn gc_address;
        private DevExpress.XtraGrid.Columns.GridColumn gc_scheduleAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gc_ExamAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gc_status;
        private DevExpress.XtraGrid.Columns.GridColumn gc_operateDate;
        private DevExpress.XtraGrid.Columns.GridColumn gc_operator;
        private DevExpress.XtraEditors.MemoEdit txt_address;
        private DevExpress.XtraEditors.MemoEdit txt_scheduleAddress;
        private DevExpress.XtraEditors.MemoEdit txt_examAddress;
    }
}