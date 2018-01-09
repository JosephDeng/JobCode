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
using Lenovo.CIS.EAS.Entities;
using DevExpress.XtraGrid;

namespace Lenovo.CIS.EAS.cUI
{
    /// <summary>
    /// 检查地点维护
    /// </summary>
    public partial class fmCheckPointMaintain : fmBase
    {

        #region Varribe
        private EntityCheckPoint g_entity = null;//已选中的检查地点记录
        #endregion

        #region Init

        public fmCheckPointMaintain()
        {
            InitializeComponent();
        }
        private void fmCheckPointMaintain_Load(object sender, EventArgs e)
        {
            RefreshGrid();

        }
        #endregion

        #region EVENT
        private void barbtn_refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Init();
            RefreshGrid();
        }

        private void barbtn_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Init();
        }

        private void barbtn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_address.Text.Trim()))
                {
                    FuncMessage.ShowErrorMsg("请输入地点名称!!!");
                    txt_address.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_scheduleAddress.Text.Trim()))
                {
                    FuncMessage.ShowErrorMsg("请输入预约地点名称!!!");
                    txt_scheduleAddress.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_examAddress.Text.Trim()))
                {
                    FuncMessage.ShowErrorMsg("请输入检查地点名称!!!");
                    txt_examAddress.Focus();
                    return;
                }
                else if (rg_status.SelectedIndex < 0)
                {
                    FuncMessage.ShowErrorMsg("请选择状态!!!");
                    rg_status.Focus();
                    return;
                }
                EntityCheckPoint entity = new EntityCheckPoint();
                entity.PointName = txt_address.Text.Trim();
                entity.CheckPoint = txt_scheduleAddress.Text.Trim();
                entity.DweingPlace = txt_scheduleAddress.Text.Trim();
                entity.State = rg_status.Properties.Items[rg_status.SelectedIndex].Value.ToString();
                entity.CreateId = PubVar.g_UserID;
                entity.CreateName = PubVar.g_UserName;
                entity.CreateTime = System.DateTime.Now;

                var persentation = new CheckPointMaintainPresentation();
                var flag = false;
                if (g_entity!=null)
                {
                    entity.PointId = g_entity.PointId;
                    flag=persentation.UpdateCheckPointMaintain(entity);

                }else
                {
                    entity.PointId = PubFuncEas.GetSquence("YJ_CHECK_POINT", "POINT_ID");
                    flag=persentation.AddCheckPointMaintain(entity);
                }
                if(flag)
                {
                    FuncMessage.ShowMsg("操作成功!!!");
                    Init();
                    RefreshGrid();
                }
                else
                {
                    FuncMessage.ShowErrorMsg("操作数据失败,请稍后再试!!!");
                }
            }
            catch (Exception err)
            {
                Log4Helper.Error(err.ToString());
            }
        }

        private void barbtn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (g_entity == null)
                {
                    FuncMessage.ShowErrorMsg("请选择待删除的检查地点!!!");
                    return;
                }
                var persentation = new CheckPointMaintainPresentation();
                var result = persentation.DeleteCheckPointMaintain(g_entity);
            }
            catch(Exception err)
            {
                Log4Helper.Error(err.ToString());
            }
        }

        private void barbtn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FuncRibbon.RemoveRibbonPage();
        }

        private void gdv_addressInfo_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name.Equals("gc_status"))//状态列
            {
                if (e.Value != null)
                {
                    e.DisplayText = e.Value.NullToEnumName(typeof(EnumDataState));
                }
            }
        }

        private void gdv_addressInfo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                g_entity = gdv_addressInfo.GetFocusedRow() as EntityCheckPoint;
                if (g_entity == null)
                    return;
                txt_address.Text = g_entity.PointName;
                txt_scheduleAddress.Text = g_entity.CheckPoint;
                txt_examAddress.Text = g_entity.DweingPlace;
                for (int index = 0; index < rg_status.Properties.Items.Count; index++)
                {
                    if (rg_status.Properties.Items[index].Value.ToString().Equals(g_entity.State))
                    {
                        rg_status.SelectedIndex = index;
                        break;
                    }
                }
            }
            catch (Exception err)
            {
                Log4Helper.Error(err.ToString());
            }
        }

        #endregion

        #region Method
        /// <summary>
        /// 设置窗体控件默认值
        /// </summary>
        private void Init()
        {
            try
            {
                g_entity = null;
                txt_address.Text = "";
                txt_scheduleAddress.Text = "";
                txt_examAddress.Text = "";
                if (rg_status.Properties.Items.Count > 0)
                    rg_status.SelectedIndex = 0;
            }catch (Exception err)
            {
                Log4Helper.Error(err.ToString());
            }
        }
        /// <summary>
        /// 刷新GRID数据
        /// </summary>
        private void RefreshGrid()
        {
            try
            {
                var persentation = new CheckPointMaintainPresentation();
                EntityCheckPoint entity = new EntityCheckPoint();
                var result = persentation.QueryCheckPointMaintain(entity);
                gdc_addressInfo.DataSource = result;
            }
            catch (Exception err)
            {
                Log4Helper.Error(err.ToString());
            }
        }
        #endregion

    }
}