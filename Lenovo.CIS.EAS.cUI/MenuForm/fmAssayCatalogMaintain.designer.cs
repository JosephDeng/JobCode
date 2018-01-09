namespace Lenovo.CIS.EAS.cUI
{
    partial class fmAssayCatalogMaintain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAssayCatalogMaintain));
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("急诊血液检验");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("急诊尿液检验");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("急诊其他检验项目");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("急诊项目", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("门诊常用检验项目");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("住院常用检验项目");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("通用生化检验项目");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("通用免疫检验项目");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("临床常用检验项目", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("术前常规项目（住院）");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("术前常规检验（门诊）");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("术前常规检验项目", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("凝血检查项目");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("凝血与骨髓检验", new System.Windows.Forms.TreeNode[] {
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("甲状腺激素测定");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("性腺激素测定");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("激素测定", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33});
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.treeAssayCatalog = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtOrderNum = new DevExpress.XtraEditors.TextEdit();
            this.txtCatalogID = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxCheckPoint = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtCreateDate = new DevExpress.XtraEditors.TextEdit();
            this.txtCreaterName = new DevExpress.XtraEditors.TextEdit();
            this.rbnLoadRange = new DevExpress.XtraEditors.RadioGroup();
            this.rbnState = new DevExpress.XtraEditors.RadioGroup();
            this.txtCatalogName = new DevExpress.XtraEditors.TextEdit();
            this.txtParentName = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxHospital = new DevExpress.XtraEditors.ComboBoxEdit();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddSameLevelNode = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddSubLevelNode = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.txtParentID = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
            this.radioGroup3 = new DevExpress.XtraEditors.RadioGroup();
            this.radioGroup4 = new DevExpress.XtraEditors.RadioGroup();
            this.textEdit11 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit12 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeAssayCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatalogID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCheckPoint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreaterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbnLoadRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbnState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatalogName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxHospital.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 50);
            this.splitContainerControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.layoutControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(873, 585);
            this.splitContainerControl2.SplitterPosition = 284;
            this.splitContainerControl2.TabIndex = 10;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.treeAssayCatalog);
            this.groupControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("刷新目录节点", null)});
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(284, 585);
            this.groupControl1.TabIndex = 0;
            // 
            // treeAssayCatalog
            // 
            this.treeAssayCatalog.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeAssayCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeAssayCatalog.KeyFieldName = "CatalogId";
            this.treeAssayCatalog.Location = new System.Drawing.Point(2, 35);
            this.treeAssayCatalog.Name = "treeAssayCatalog";
            this.treeAssayCatalog.ParentFieldName = "ParentId";
            this.treeAssayCatalog.Size = new System.Drawing.Size(280, 548);
            this.treeAssayCatalog.TabIndex = 8;
            this.treeAssayCatalog.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeAssayCatalog_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn1.Caption = "检验医嘱目录";
            this.treeListColumn1.FieldName = "CatalogName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.OptionsColumn.AllowSort = false;
            this.treeListColumn1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtOrderNum);
            this.layoutControl1.Controls.Add(this.txtCatalogID);
            this.layoutControl1.Controls.Add(this.comboBoxCheckPoint);
            this.layoutControl1.Controls.Add(this.txtCreateDate);
            this.layoutControl1.Controls.Add(this.txtCreaterName);
            this.layoutControl1.Controls.Add(this.rbnLoadRange);
            this.layoutControl1.Controls.Add(this.rbnState);
            this.layoutControl1.Controls.Add(this.txtCatalogName);
            this.layoutControl1.Controls.Add(this.txtParentName);
            this.layoutControl1.Controls.Add(this.comboBoxHospital);
            this.layoutControl1.Controls.Add(this.txtParentID);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(772, 157, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(583, 585);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(151, 246);
            this.txtOrderNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(359, 24);
            this.txtOrderNum.StyleController = this.layoutControl1;
            this.txtOrderNum.TabIndex = 15;
            // 
            // txtCatalogID
            // 
            this.txtCatalogID.Location = new System.Drawing.Point(151, 84);
            this.txtCatalogID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCatalogID.Name = "txtCatalogID";
            this.txtCatalogID.Properties.ReadOnly = true;
            this.txtCatalogID.Size = new System.Drawing.Size(359, 24);
            this.txtCatalogID.StyleController = this.layoutControl1;
            this.txtCatalogID.TabIndex = 14;
            // 
            // comboBoxCheckPoint
            // 
            this.comboBoxCheckPoint.Location = new System.Drawing.Point(151, 182);
            this.comboBoxCheckPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCheckPoint.Name = "comboBoxCheckPoint";
            this.comboBoxCheckPoint.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxCheckPoint.Properties.Items.AddRange(new object[] {
            "一楼CT室",
            "一楼放射科",
            "住院一部放射科"});
            this.comboBoxCheckPoint.Size = new System.Drawing.Size(359, 24);
            this.comboBoxCheckPoint.StyleController = this.layoutControl1;
            this.comboBoxCheckPoint.TabIndex = 12;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(151, 314);
            this.txtCreateDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Properties.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(359, 24);
            this.txtCreateDate.StyleController = this.layoutControl1;
            this.txtCreateDate.TabIndex = 11;
            // 
            // txtCreaterName
            // 
            this.txtCreaterName.Location = new System.Drawing.Point(151, 280);
            this.txtCreaterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreaterName.Name = "txtCreaterName";
            this.txtCreaterName.Properties.ReadOnly = true;
            this.txtCreaterName.Size = new System.Drawing.Size(359, 24);
            this.txtCreaterName.StyleController = this.layoutControl1;
            this.txtCreaterName.TabIndex = 10;
            // 
            // rbnLoadRange
            // 
            this.rbnLoadRange.Location = new System.Drawing.Point(151, 152);
            this.rbnLoadRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbnLoadRange.Name = "rbnLoadRange";
            this.rbnLoadRange.Properties.Columns = 4;
            this.rbnLoadRange.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "全院"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "门诊"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "住院")});
            this.rbnLoadRange.Size = new System.Drawing.Size(359, 24);
            this.rbnLoadRange.StyleController = this.layoutControl1;
            this.rbnLoadRange.TabIndex = 9;
            // 
            // rbnState
            // 
            this.rbnState.Location = new System.Drawing.Point(151, 216);
            this.rbnState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbnState.Name = "rbnState";
            this.rbnState.Properties.Columns = 2;
            this.rbnState.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "启用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "停用")});
            this.rbnState.Size = new System.Drawing.Size(359, 24);
            this.rbnState.StyleController = this.layoutControl1;
            this.rbnState.TabIndex = 8;
            // 
            // txtCatalogName
            // 
            this.txtCatalogName.Location = new System.Drawing.Point(151, 118);
            this.txtCatalogName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCatalogName.Name = "txtCatalogName";
            this.txtCatalogName.Size = new System.Drawing.Size(359, 24);
            this.txtCatalogName.StyleController = this.layoutControl1;
            this.txtCatalogName.TabIndex = 5;
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(151, 50);
            this.txtParentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Properties.ReadOnly = true;
            this.txtParentName.Size = new System.Drawing.Size(359, 24);
            this.txtParentName.StyleController = this.layoutControl1;
            this.txtParentName.TabIndex = 4;
            // 
            // comboBoxHospital
            // 
            this.comboBoxHospital.Location = new System.Drawing.Point(151, 16);
            this.comboBoxHospital.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxHospital.MenuManager = this.barManager2;
            this.comboBoxHospital.Name = "comboBoxHospital";
            this.comboBoxHospital.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxHospital.Properties.Items.AddRange(new object[] {
            "一楼CT室",
            "一楼放射科",
            "住院一部放射科"});
            this.comboBoxHospital.Size = new System.Drawing.Size(359, 24);
            this.comboBoxHospital.StyleController = this.layoutControl1;
            this.comboBoxHospital.TabIndex = 12;
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnRefresh,
            this.barButtonItem14,
            this.btnSave,
            this.btnDelete,
            this.btnQuit,
            this.btnAddSubLevelNode,
            this.btnAddSameLevelNode});
            this.barManager2.MainMenu = this.bar3;
            this.barManager2.MaxItemId = 7;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAddSameLevelNode, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAddSubLevelNode, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQuit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "刷新";
            this.btnRefresh.Id = 0;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImageIndex = 22;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnAddSameLevelNode
            // 
            this.btnAddSameLevelNode.Caption = "新增同级节点";
            this.btnAddSameLevelNode.Id = 6;
            this.btnAddSameLevelNode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSameLevelNode.ImageOptions.Image")));
            this.btnAddSameLevelNode.ImageOptions.LargeImageIndex = 190;
            this.btnAddSameLevelNode.Name = "btnAddSameLevelNode";
            this.btnAddSameLevelNode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddSameLevelNode_ItemClick);
            // 
            // btnAddSubLevelNode
            // 
            this.btnAddSubLevelNode.Caption = "新增子级节点";
            this.btnAddSubLevelNode.Id = 5;
            this.btnAddSubLevelNode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSubLevelNode.ImageOptions.Image")));
            this.btnAddSubLevelNode.ImageOptions.LargeImageIndex = 96;
            this.btnAddSubLevelNode.Name = "btnAddSubLevelNode";
            this.btnAddSubLevelNode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddSubLevelNode_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "保存";
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImageIndex = 1;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "删除";
            this.btnDelete.Id = 3;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImageIndex = 18;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnQuit
            // 
            this.btnQuit.Caption = "退出";
            this.btnQuit.Id = 4;
            this.btnQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.ImageOptions.Image")));
            this.btnQuit.ImageOptions.LargeImageIndex = 27;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuit_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl1.Size = new System.Drawing.Size(873, 50);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 635);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl2.Size = new System.Drawing.Size(873, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 50);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl3.Size = new System.Drawing.Size(0, 585);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(873, 50);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl4.Size = new System.Drawing.Size(0, 585);
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.ActAsDropDown = true;
            this.barButtonItem14.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem14.Caption = "新增同级节点";
            this.barButtonItem14.Id = 1;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // txtParentID
            // 
            this.txtParentID.Location = new System.Drawing.Point(151, 545);
            this.txtParentID.MenuManager = this.barManager2;
            this.txtParentID.Name = "txtParentID";
            this.txtParentID.Size = new System.Drawing.Size(416, 24);
            this.txtParentID.StyleController = this.layoutControl1;
            this.txtParentID.TabIndex = 17;
            this.txtParentID.Visible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem19,
            this.layoutControlItem20});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(583, 585);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtParentName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(500, 34);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(185, 34);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(557, 34);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "上级目录名称：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(132, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 332);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(557, 197);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtCatalogName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(500, 34);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(185, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(557, 34);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "目录名称：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(132, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.rbnLoadRange;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 136);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(500, 34);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(165, 29);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(557, 30);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "加载范围：";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(132, 18);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtCreaterName;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 264);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(500, 34);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(185, 34);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(557, 34);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "操作者：";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(132, 18);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtCreateDate;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 298);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(500, 34);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(185, 34);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(557, 34);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "操作时间：";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(132, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.comboBoxCheckPoint;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 166);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(500, 34);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(185, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(557, 34);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "检查地点：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(132, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.rbnState;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 200);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(500, 34);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(141, 29);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(557, 30);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "状态：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(132, 18);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtCatalogID;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(500, 34);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(185, 34);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(557, 34);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "目录ID:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(132, 18);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtOrderNum;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 230);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(500, 34);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(185, 34);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(557, 34);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "排序号：";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(132, 18);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.comboBoxHospital;
            this.layoutControlItem19.CustomizationFormText = "检查地点：";
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem19.MaxSize = new System.Drawing.Size(500, 34);
            this.layoutControlItem19.MinSize = new System.Drawing.Size(185, 34);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(557, 34);
            this.layoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem19.Text = "加载院区：";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(132, 18);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.txtParentID;
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 529);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(557, 30);
            this.layoutControlItem20.TextSize = new System.Drawing.Size(132, 18);
            this.layoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 40);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(764, 454);
            this.splitContainerControl1.SplitterPosition = 281;
            this.splitContainerControl1.TabIndex = 10;
            this.splitContainerControl1.Text = "splitContainerControl2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.treeView2);
            this.groupControl2.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("刷新目录节点", null)});
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(281, 454);
            this.groupControl2.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.LineColor = System.Drawing.Color.Empty;
            this.treeView2.Location = new System.Drawing.Point(2, 35);
            this.treeView2.Name = "treeView2";
            treeNode18.Name = "节点5";
            treeNode18.Text = "急诊血液检验";
            treeNode19.Name = "节点6";
            treeNode19.Text = "急诊尿液检验";
            treeNode20.Name = "节点7";
            treeNode20.Text = "急诊其他检验项目";
            treeNode21.Name = "节点0";
            treeNode21.Text = "急诊项目";
            treeNode22.Name = "节点9";
            treeNode22.Text = "门诊常用检验项目";
            treeNode23.Name = "节点10";
            treeNode23.Text = "住院常用检验项目";
            treeNode24.Name = "节点13";
            treeNode24.Text = "通用生化检验项目";
            treeNode25.Name = "节点14";
            treeNode25.Text = "通用免疫检验项目";
            treeNode26.Name = "节点1";
            treeNode26.Text = "临床常用检验项目";
            treeNode27.Name = "节点11";
            treeNode27.Text = "术前常规项目（住院）";
            treeNode28.Name = "节点12";
            treeNode28.Text = "术前常规检验（门诊）";
            treeNode29.Name = "节点2";
            treeNode29.Text = "术前常规检验项目";
            treeNode30.Name = "节点15";
            treeNode30.Text = "凝血检查项目";
            treeNode31.Name = "节点3";
            treeNode31.Text = "凝血与骨髓检验";
            treeNode32.Name = "节点17";
            treeNode32.Text = "甲状腺激素测定";
            treeNode33.Name = "节点18";
            treeNode33.Text = "性腺激素测定";
            treeNode34.Name = "节点4";
            treeNode34.Text = "激素测定";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode26,
            treeNode29,
            treeNode31,
            treeNode34});
            this.treeView2.Size = new System.Drawing.Size(277, 417);
            this.treeView2.TabIndex = 7;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.textEdit4);
            this.layoutControl2.Controls.Add(this.textEdit8);
            this.layoutControl2.Controls.Add(this.textEdit9);
            this.layoutControl2.Controls.Add(this.textEdit10);
            this.layoutControl2.Controls.Add(this.radioGroup3);
            this.layoutControl2.Controls.Add(this.radioGroup4);
            this.layoutControl2.Controls.Add(this.textEdit11);
            this.layoutControl2.Controls.Add(this.textEdit12);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(772, 157, 450, 400);
            this.layoutControl2.Root = this.layoutControlGroup3;
            this.layoutControl2.Size = new System.Drawing.Size(477, 454);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl1";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(124, 164);
            this.textEdit4.MenuManager = this.barManager2;
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(337, 24);
            this.textEdit4.StyleController = this.layoutControl2;
            this.textEdit4.TabIndex = 15;
            // 
            // textEdit8
            // 
            this.textEdit8.Location = new System.Drawing.Point(124, 46);
            this.textEdit8.MenuManager = this.barManager2;
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Properties.ReadOnly = true;
            this.textEdit8.Size = new System.Drawing.Size(337, 24);
            this.textEdit8.StyleController = this.layoutControl2;
            this.textEdit8.TabIndex = 14;
            // 
            // textEdit9
            // 
            this.textEdit9.Location = new System.Drawing.Point(124, 224);
            this.textEdit9.MenuManager = this.barManager2;
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Properties.ReadOnly = true;
            this.textEdit9.Size = new System.Drawing.Size(337, 24);
            this.textEdit9.StyleController = this.layoutControl2;
            this.textEdit9.TabIndex = 11;
            // 
            // textEdit10
            // 
            this.textEdit10.Location = new System.Drawing.Point(124, 194);
            this.textEdit10.MenuManager = this.barManager2;
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Properties.ReadOnly = true;
            this.textEdit10.Size = new System.Drawing.Size(337, 24);
            this.textEdit10.StyleController = this.layoutControl2;
            this.textEdit10.TabIndex = 10;
            // 
            // radioGroup3
            // 
            this.radioGroup3.Location = new System.Drawing.Point(124, 106);
            this.radioGroup3.MenuManager = this.barManager2;
            this.radioGroup3.Name = "radioGroup3";
            this.radioGroup3.Properties.Columns = 4;
            this.radioGroup3.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "全院"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "门诊"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "住院")});
            this.radioGroup3.Size = new System.Drawing.Size(337, 23);
            this.radioGroup3.StyleController = this.layoutControl2;
            this.radioGroup3.TabIndex = 9;
            // 
            // radioGroup4
            // 
            this.radioGroup4.Location = new System.Drawing.Point(124, 135);
            this.radioGroup4.MenuManager = this.barManager2;
            this.radioGroup4.Name = "radioGroup4";
            this.radioGroup4.Properties.Columns = 2;
            this.radioGroup4.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "启用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "停用")});
            this.radioGroup4.Size = new System.Drawing.Size(337, 23);
            this.radioGroup4.StyleController = this.layoutControl2;
            this.radioGroup4.TabIndex = 8;
            // 
            // textEdit11
            // 
            this.textEdit11.Location = new System.Drawing.Point(124, 76);
            this.textEdit11.MenuManager = this.barManager2;
            this.textEdit11.Name = "textEdit11";
            this.textEdit11.Size = new System.Drawing.Size(337, 24);
            this.textEdit11.StyleController = this.layoutControl2;
            this.textEdit11.TabIndex = 5;
            // 
            // textEdit12
            // 
            this.textEdit12.Location = new System.Drawing.Point(124, 16);
            this.textEdit12.MenuManager = this.barManager2;
            this.textEdit12.Name = "textEdit12";
            this.textEdit12.Properties.ReadOnly = true;
            this.textEdit12.Size = new System.Drawing.Size(337, 24);
            this.textEdit12.StyleController = this.layoutControl2;
            this.textEdit12.TabIndex = 4;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.layoutControlItem9,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem16,
            this.layoutControlItem17,
            this.layoutControlItem18});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "Root";
            this.layoutControlGroup3.Size = new System.Drawing.Size(477, 454);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit12;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem1";
            this.layoutControlItem4.Size = new System.Drawing.Size(451, 30);
            this.layoutControlItem4.Text = "上级目录名称：";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(105, 18);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 238);
            this.emptySpaceItem2.Name = "emptySpaceItem1";
            this.emptySpaceItem2.Size = new System.Drawing.Size(451, 190);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.textEdit11;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem9.Name = "layoutControlItem2";
            this.layoutControlItem9.Size = new System.Drawing.Size(451, 30);
            this.layoutControlItem9.Text = "目录名称：";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(105, 18);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.radioGroup3;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(0, 29);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(165, 29);
            this.layoutControlItem12.Name = "layoutControlItem6";
            this.layoutControlItem12.Size = new System.Drawing.Size(451, 29);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.Text = "加载范围：";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(105, 18);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.textEdit10;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 178);
            this.layoutControlItem13.Name = "layoutControlItem7";
            this.layoutControlItem13.Size = new System.Drawing.Size(451, 30);
            this.layoutControlItem13.Text = "操作者：";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(105, 18);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.textEdit9;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 208);
            this.layoutControlItem14.Name = "layoutControlItem8";
            this.layoutControlItem14.Size = new System.Drawing.Size(451, 30);
            this.layoutControlItem14.Text = "操作时间：";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(105, 18);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.radioGroup4;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem16.MaxSize = new System.Drawing.Size(0, 29);
            this.layoutControlItem16.MinSize = new System.Drawing.Size(141, 29);
            this.layoutControlItem16.Name = "layoutControlItem5";
            this.layoutControlItem16.Size = new System.Drawing.Size(451, 29);
            this.layoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem16.Text = "状态：";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(105, 18);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.textEdit8;
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem17.Name = "layoutControlItem10";
            this.layoutControlItem17.Size = new System.Drawing.Size(451, 30);
            this.layoutControlItem17.Text = "目录ID:";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(105, 18);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.textEdit4;
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 148);
            this.layoutControlItem18.Name = "layoutControlItem11";
            this.layoutControlItem18.Size = new System.Drawing.Size(451, 30);
            this.layoutControlItem18.Text = "排序号：";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(105, 18);
            // 
            // fmAssayCatalogMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 635);
            this.Controls.Add(this.splitContainerControl2);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "fmAssayCatalogMaintain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检验目录维护";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmAssayCatalogMaintain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeAssayCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatalogID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCheckPoint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreaterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbnLoadRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbnState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatalogName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxHospital.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtOrderNum;
        private DevExpress.XtraEditors.TextEdit txtCatalogID;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxCheckPoint;
        private DevExpress.XtraEditors.TextEdit txtCreateDate;
        private DevExpress.XtraEditors.TextEdit txtCreaterName;
        private DevExpress.XtraEditors.RadioGroup rbnLoadRange;
        private DevExpress.XtraEditors.RadioGroup rbnState;
        private DevExpress.XtraEditors.TextEdit txtCatalogName;
        private DevExpress.XtraEditors.TextEdit txtParentName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxHospital;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnAddSameLevelNode;
        private DevExpress.XtraBars.BarButtonItem btnAddSubLevelNode;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnQuit;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TreeView treeView2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.TextEdit textEdit10;
        private DevExpress.XtraEditors.RadioGroup radioGroup3;
        private DevExpress.XtraEditors.RadioGroup radioGroup4;
        private DevExpress.XtraEditors.TextEdit textEdit11;
        private DevExpress.XtraEditors.TextEdit textEdit12;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraTreeList.TreeList treeAssayCatalog;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.TextEdit txtParentID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
    }
}