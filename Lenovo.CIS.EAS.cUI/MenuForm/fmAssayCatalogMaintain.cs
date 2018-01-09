using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Lenovo.HIS.cUtils;
using Lenovo.CIS.EAS.cBusiness;
using Lenovo.HIS.Entities;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using Lenovo.CIS.EAS.Entities;

namespace Lenovo.CIS.EAS.cUI
{
    /// <summary>
    /// 检验目录维护
    /// </summary>
    public partial class fmAssayCatalogMaintain : fmBase
    {
        public object EnumSequneces { get; private set; }
        #region Varribe
        #endregion
        #region Init
        public fmAssayCatalogMaintain()
        {
            InitializeComponent();
            treeAssayCatalog.LookAndFeel.UseDefaultLookAndFeel = false;
            treeAssayCatalog.LookAndFeel.UseWindowsXPTheme = true;
            treeAssayCatalog.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.Highlight;
            treeAssayCatalog.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.HighlightText;
            //treeAssayCatalog.OptionsBehavior.Editable = false;        
            //treeAssayCatalog.ViewStyle = DevExpress.XtraTreeList.TreeListViewStyle.TreeView;
        }

        private void fmAssayCatalogMaintain_Load(object sender, EventArgs e)
        {
            //默认能登录进来的都是合法可操作的
            //1:加载检验目录
            RefreshCatalogList();
            //2：加载院区列表
            //var ghostList = PubVar.g_ListHosArea;//
            //3:加载检查地点
            var _checkPointList = QueryCheckPointMaintain(new EntityCheckPoint());
            if (_checkPointList != null && _checkPointList.Count > 0)
            {
                _checkPointList.ForEach(m =>
                {
                    comboBoxCheckPoint.Properties.Items.Add(m.CheckPoint);
                });
            }

        }

        #endregion
        #region Event
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshCatalogList();
        }

        private void btnAddSameLevelNode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            comboBoxHospital.SelectedIndex = 0;
            txtParentName.Text = "";
            txtParentID.Text = "0";
            txtCatalogID.Text = "";
            txtCatalogName.Text = "";
            rbnLoadRange.SelectedIndex = 0;
            comboBoxCheckPoint.SelectedIndex = 0;
            rbnState.SelectedIndex = 0;
            txtOrderNum.Text = "";
            txtCreaterName.Text = PubVar.g_UserName;
            txtCreateDate.Text = DateTime.Now.ToString("yyyy-MM-dd");//未来要取服务器时间
        }

        private void btnAddSubLevelNode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<EntityAssayCatalog> _treeList = treeAssayCatalog.DataSource as List<EntityAssayCatalog>;
            if (_treeList != null)
            {
                //判断是否选中的是根节点
                int _index = treeAssayCatalog.FocusedNode.Id;
                var _item = _treeList[_index];
                if (_item != null)
                {
                    if (_item.ParentId == 0)
                    {
                        comboBoxHospital.SelectedIndex = 0;
                        txtParentName.Text = _item.CatalogName;
                        txtParentID.Text = _item.CatalogId.ToString();
                        txtCatalogID.Text = "";
                        txtCatalogName.Text = "";
                        rbnLoadRange.SelectedIndex = 0;
                        comboBoxCheckPoint.SelectedIndex = 0;
                        rbnState.SelectedIndex = 0;
                        txtOrderNum.Text = "";
                        txtCreaterName.Text = PubVar.g_UserName;
                        txtCreateDate.Text = DateTime.Now.ToString("yyyy-MM-dd");//未来要取服务器时间
                    }
                    else
                        FuncMessage.ShowMsg("只能在根节点下增加子节点");
                }
            }
            else
                FuncMessage.ShowMsg("请先增加根节点");

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EntityAssayCatalog _cataLogEntity = GetInputCatalogInfo();
            if (string.IsNullOrWhiteSpace(_cataLogEntity.CatalogName))
            {
                FuncMessage.ShowMsg("目录名称不能为空");
                return;
            }
            var res = FacadeProxy.CommonProxy().SaveAssayCatalog(_cataLogEntity);
            if (res)
            {
                FuncMessage.ShowMsgBottomR(PubConstEas.StrSaveSuccess);
            }
            else
            {
                FuncMessage.ShowErrorMsg(PubConstEas.StrSaveFail);
            }
            RefreshCatalogList();
        }


        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<EntityAssayCatalog> _treeList = treeAssayCatalog.DataSource as List<EntityAssayCatalog>;
            if (_treeList != null)
            {
                int _index = treeAssayCatalog.FocusedNode.Id;
                var _item = _treeList[_index];
                if (_item != null)
                {
                    bool _IsDelete = false;
                    string _catalogIds = "";
                    if (_item.ParentId != 0)
                    {
                        if (FuncMessage.ShowMsgYesNoCancel(string.Format("确定删除子节点 {0} 吗？", _item.CatalogName)) == EnumMsgResult.Yes)
                        {
                            _IsDelete = true;
                            _catalogIds = _item.CatalogId.ToString();
                        }
                    }
                    else
                    {
                        if (FuncMessage.ShowMsgYesNoCancel(string.Format("确定删除根节点 {0} 及其所有子节点吗？", _item.CatalogName)) == EnumMsgResult.Yes)
                        {
                            _IsDelete = true;
                            _catalogIds += _item.CatalogId.ToString();

                            var _subIds = string.Join(",", _treeList.Where(m => m.ParentId == _item.CatalogId).Select(n => n.CatalogId).ToArray());
                            if (!string.IsNullOrEmpty(_subIds))
                            {
                                _catalogIds += "," + _subIds;
                            }
                        }
                    }
                    if (_IsDelete)
                    {
                        var res = FacadeProxy.CommonProxy().DeleteAssayCatalog(_catalogIds);
                        if (res)
                        {
                            FuncMessage.ShowMsgBottomR(PubConstEas.StrDelSuccess);
                        }
                        else
                        {
                            FuncMessage.ShowErrorMsg(PubConstEas.StrDelFail);
                        }
                        RefreshCatalogList();
                    }
                }
            }
        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FuncRibbon.RemoveRibbonPage();
        }

        private void treeAssayCatalog_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            List<EntityAssayCatalog> _treeList = treeAssayCatalog.DataSource as List<EntityAssayCatalog>;
            if (_treeList != null)
            {
                int _index = treeAssayCatalog.FocusedNode.Id;
                var _item = _treeList[_index];
                if (_item != null)
                {
                    comboBoxHospital.Text = _item.HospitalName;
                    txtParentName.Text = _treeList.Exists(m => m.CatalogId == _item.ParentId) ?
                        _treeList.Find(m => m.CatalogId == _item.ParentId).CatalogName : "";
                    txtParentID.Text = _item.ParentId.ToString();
                    txtCatalogID.Text = _item.CatalogId.ToString();
                    txtCatalogName.Text = _item.CatalogName;
                    rbnLoadRange.SelectedIndex = _item.LoadRange;
                    comboBoxCheckPoint.SelectedIndex = 0;
                    rbnState.SelectedIndex = _item.State;
                    txtOrderNum.Text = _item.OrderNum.ToString();
                    txtCreaterName.Text = _item.CreateName;
                    txtCreateDate.Text = _item.CreateDate.ToString("yyyy-MM-dd");//未来要取服务器时间

                }
            }
        }
        #endregion
        #region Method       

        /// <summary>
        /// 从数据获取最新的检验目录列表
        /// </summary>
        /// <returns>检验目录实体集合</returns>
        private List<EntityAssayCatalog> GetAssayCatalogList()
        {
            List<EntityAssayCatalog> _listAssayCatalog = new List<EntityAssayCatalog>();
            _listAssayCatalog = FacadeProxy.CommonProxy().GetAssayCatalogList();
            return _listAssayCatalog;
        }
        /// <summary>
        /// 获取界面控件输入的信息
        /// </summary>
        /// <returns>检验目录实体</returns>
        private EntityAssayCatalog GetInputCatalogInfo()
        {
            EntityAssayCatalog _cataLogInfo = new EntityAssayCatalog();
            _cataLogInfo.CatalogId = string.IsNullOrEmpty(txtCatalogID.Text) ? PubFuncEas.GetSquence("YJ_ASSAY_CATALOG", "CATALOG_ID") : int.Parse(txtCatalogID.Text);
            _cataLogInfo.ParentId = int.Parse(txtParentID.Text);
            _cataLogInfo.CatalogName = txtCatalogName.Text;
            _cataLogInfo.CheckType = "";
            _cataLogInfo.LoadRange = rbnLoadRange.SelectedIndex;
            _cataLogInfo.CheckPoint = comboBoxCheckPoint.Text;
            _cataLogInfo.IsOnlyChoice = 0;
            _cataLogInfo.State = rbnState.SelectedIndex;
            _cataLogInfo.OrderNum = string.IsNullOrWhiteSpace(txtOrderNum.Text) ? 0 : int.Parse(txtOrderNum.Text);
            _cataLogInfo.CreateId = PubVar.g_UserID;
            _cataLogInfo.CreateName = txtCreaterName.Text;
            _cataLogInfo.CreateDate = DateTime.Now;//TODO:取服务器时间
            _cataLogInfo.HospitalCode = comboBoxHospital.SelectedIndex.ToString();//TODO:取院区代码
            _cataLogInfo.HospitalName = comboBoxHospital.Text;//TODO:取院区名称
            return _cataLogInfo;
        }
        /// <summary>
        /// 获取最新的检验目录列表并刷新treeList控件
        /// </summary>
        private void RefreshCatalogList()
        {
            var _cataLogList = GetAssayCatalogList();
            if (_cataLogList != null && _cataLogList.Count > 0)
            {
                var _ids = new List<object>();
                treeAssayCatalog.GetNodeList().FindAll(n => n.Expanded).ForEach(n => { _ids.Add(n.GetValue("CatalogId")); });//记录原来打开的节点
                this.treeAssayCatalog.DataSource = _cataLogList.OrderBy(m => m.OrderNum).ToList();
                _ids.ForEach(id => { treeAssayCatalog.FindNodeByKeyID(id).Expanded = true; });//恢复
                //显示复选框  
                //treeAssayCatalog.OptionsView.ShowCheckBoxes = true;
            }
        }

        /// <summary>
        /// 获取检查地址信息
        /// <param name="entity">医技检查地点实体类</param>
        /// </summary>
        /// <returns>地址数据集信息</returns>
        public List<EntityCheckPoint> QueryCheckPointMaintain(EntityCheckPoint entity)
        {
            var _result = new List<EntityCheckPoint>();
            using (var proxy = FacadeProxy.CommonProxy())
            {
                _result = proxy.GetCheckPointInfo(entity);
            }
            return _result;
        }

        #endregion

    }
}