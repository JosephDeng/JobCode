using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Lenovo.CIS.EAS.cBusiness;
using Lenovo.CIS.EAS.Entities;
using Lenovo.HIS.cUtils;
using Lenovo.HIS.Common;

namespace Lenovo.CIS.EAS.cUI
{
    /// <summary>
    /// 基础类型数据维护
    /// </summary>
    public partial class fmBasicDataMaintain : fmBase
    {

        #region Varribe

        /// <summary>
        /// 基础集合
        /// </summary>
        private List<EntityBasicDictionary> LsBacsDic = null;

        /// <summary>
        /// 字典明细
        /// </summary>
        private List<EntityBasicDictionary> LsBacsDicDetail = null;

        #endregion

        #region Init

        public fmBasicDataMaintain()
        {
            InitializeComponent();
        }
        private void fmBasicDataMaintain_Load(object sender, EventArgs e)
        {
            InitData();
        }

        #endregion

        #region Event

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            FuncRibbon.RemoveRibbonPage();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitData();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (LsBacsDic.Exists(p => p.Action == EnumAction.新增 || p.Id < 0))
            {
                FuncMessage.ShowWarningMsg("请先保存新增数据再提交!");
                return;
            }
            var newItem = new EntityBasicDictionary()
            {
                ParentId = 0,
                Action = EnumAction.新增,
                CreateId = PubVar.g_UserID,
                CreateName = PubVar.g_UserName,
                CreateTime = DateTime.Now
            };
            LsBacsDic.Add(newItem);
            gvMain.RefreshData();
            gvMain.MoveLast();
            gvMain.OptionsBehavior.Editable = true;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var newItem = LsBacsDic.Find(p => p.Action == EnumAction.新增 && p.Id <= 0);
            gvMain.PostEditor();
            gvMain.CloseEditor();
            if (string.IsNullOrEmpty(newItem.Code) || string.IsNullOrEmpty(newItem.Name))
            {
                FuncMessage.ShowMsg("类别代码或类别名称不能未空!");
                return;
            }
            newItem.Id = PubFuncEas.GetSquence("YJ_BASIC_DICTIONARY", "ID");
            var res = FacadeProxy.CommonProxy().SaveBacsDictionary(newItem);
            if (res)
            {
                FuncMessage.ShowMsgBottomR(PubConstEas.StrSaveSuccess);
                gvMain.OptionsBehavior.Editable = false;
            }
            else
            {
                FuncMessage.ShowErrorMsg(PubConstEas.StrSaveFail);
            }
        }

        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvMain_DoubleClick(object sender, EventArgs e)
        {
            var fousedItem = gvMain.GetFocusedRow() as EntityBasicDictionary;
            if (fousedItem == null)
                return;
            LsBacsDicDetail = FacadeProxy.CommonProxy().GetBacsDictionary(fousedItem);
            gcDetail.DataSource = LsBacsDicDetail;
            gvDetail.RefreshData();
        }
        private void btnDel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!PubFuncEas.GridCheckDelFocusedRow<EntityBasicDictionary>(gvMain))
                return;
            var fousedItem = gvMain.GetFocusedRow() as EntityBasicDictionary;
            var res = fousedItem.Id <= 0 ? true : FacadeProxy.CommonProxy().DelBacsDictionary(fousedItem);
            if (res)
            {
                FuncMessage.ShowMsgBottomR(PubConstEas.StrDelSuccess);
                LsBacsDic.Remove(fousedItem);
                gvMain.RefreshData();
            }
            else
            {
                FuncMessage.ShowMsgBottomR(PubConstEas.StrSaveFail);
            }
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {

            var fousedPatItem = gvMain.GetFocusedRow() as EntityBasicDictionary;
            if (fousedPatItem == null || fousedPatItem.Id <= 0 || LsBacsDicDetail == null)
            {
                FuncMessage.ShowWarningMsg("获取左侧类别信息失败,请双击左侧大类信息!");
                return;
            }
            if (LsBacsDicDetail.Exists(p => p.Action == EnumAction.新增 || p.Id < 0))
            {
                FuncMessage.ShowWarningMsg("请先保存新增数据再提交!");
                return;
            }
            var newDetailItem = new EntityBasicDictionary()
            {
                ParentId = fousedPatItem.Id,
                Action = EnumAction.新增,
                CreateId = PubVar.g_UserID,
                CreateName = PubVar.g_UserName,
                CreateTime = DateTime.Now,
            };
            LsBacsDicDetail.Add(newDetailItem);
            gvDetail.RefreshData();
            gvDetail.MoveLast();
        }

        private void btnSaveDeatil_Click(object sender, EventArgs e)
        {
            var newDetailItem = LsBacsDicDetail.Find(p => p.Action == EnumAction.新增);
            gvMain.PostEditor();
            gvMain.CloseEditor();
            if (string.IsNullOrEmpty(newDetailItem.Code) || string.IsNullOrEmpty(newDetailItem.Name))
            {
                FuncMessage.ShowMsg("代码或名称不能未空!");
                return;
            }
            newDetailItem.Id = PubFuncEas.GetSquence("yj_basic_dictionary", "id");
            if (string.IsNullOrEmpty(newDetailItem.PinyinCode))
                newDetailItem.PinyinCode = FuncCode.GetHzPY(newDetailItem.Name);
            var res = FacadeProxy.CommonProxy().SaveBacsDictionary(newDetailItem);
            if (res)
            {
                FuncMessage.ShowMsgBottomR(PubConstEas.StrSaveSuccess);
            }
            else
            {
                FuncMessage.ShowErrorMsg(PubConstEas.StrSaveFail);
            }
        }

        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            if (!PubFuncEas.GridCheckDelFocusedRow<EntityBasicDictionary>(gvDetail))
                return;
            var fousedItem = gvDetail.GetFocusedRow() as EntityBasicDictionary;
            var res = fousedItem.Id <= 0 ? true : FacadeProxy.CommonProxy().DelBacsDictionary(fousedItem);
            if (res)
            {
                FuncMessage.ShowMsgBottomR(PubConstEas.StrDelSuccess);
                LsBacsDicDetail.Remove(fousedItem);
                gvDetail.RefreshData();
            }
            else
            {
                FuncMessage.ShowMsgBottomR(PubConstEas.StrSaveFail);
            }
        }

        #endregion

        #region Method

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            LsBacsDic = FacadeProxy.CommonProxy().GetBacsDictionary(null);
            //  LsBacsDic = listBaceDictionary.FindAll(p => p.ParentId == 0);
            gcMain.DataSource = LsBacsDic;
            gvMain.OptionsBehavior.Editable = false;
        }

        #endregion


    }
}