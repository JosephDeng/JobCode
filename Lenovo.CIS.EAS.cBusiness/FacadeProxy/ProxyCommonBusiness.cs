/********************************************************************************
** Company： 联想智慧医疗
** auth：    凡福群
** date：    2018-01-04 16:55:43
** desc：    公共代理类
** Ver.:     V1.0.0
*********************************************************************************/

using Lenovo.HIS.cUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Lenovo.CIS.EAS.IBusiness;
using Lenovo.HIS.Common;
using Lenovo.CIS.EAS.Entities;

namespace Lenovo.CIS.EAS.cBusiness
{
    public class ProxyCommonBusiness : ProxyEasBusiness
    {
        public string GetComTest()
        {
            return FuncWcfProxy.BaseWork(this, p => p.Channel.GetComTest());
        }

        /// <summary>
        /// 获取基础字典信息
        /// </summary>
        /// <returns></returns>
        public List<EntityBasicDictionary> GetBacsDictionary(EntityBasicDictionary entity)
        {
            var dt = FuncWcfProxy.BaseWork(this, p => p.Channel.GetBacsDictionary(entity));
            return FuncTableHelper.DataTableToListByAttr<EntityBasicDictionary>(dt);
        }

        /// <summary>
        /// 保存基础字典信息
        /// </summary>
        /// <returns></returns>
        public bool SaveBacsDictionary(EntityBasicDictionary entity)
        {
            var res = FuncWcfProxy.BaseWork(this, p => p.Channel.SaveBacsDictionary(entity));
            return res;
        }

        /// <summary>
        /// 修改基础字典信息
        /// </summary>
        /// <returns></returns>
        public bool ModityBacsDictionary(EntityBasicDictionary entity)
        {
            var res = FuncWcfProxy.BaseWork(this, p => p.Channel.ModityBacsDictionary(entity));
            return res;
        }

        /// <summary>
        /// 删除基础字典信息
        /// </summary>
        /// <returns></returns>
        public bool DelBacsDictionary(EntityBasicDictionary entity)
        {
            var res = FuncWcfProxy.BaseWork(this, p => p.Channel.DelBacsDictionary(entity));
            return res;
        }


        #region 检查地址信息操作
        /// <summary>
        /// 获取检查地址信息
        /// <param name="entity">医技检查地点实体类</param>
        /// </summary>
        /// <returns>地址数据集信息</returns>
        public List<EntityCheckPoint> GetCheckPointInfo(EntityCheckPoint entity)
        {
            List<EntityCheckPoint> result = new List<EntityCheckPoint>();
            try
            {
                var ds = FuncWcfProxy.BaseWork(this, p => p.Channel.GetCheckPointInfo(entity));
                result = FuncTableHelper.DataTableToListByAttr<EntityCheckPoint>(ds.Tables[0]);
            }
            catch (Exception err)
            {
                Log4Helper.Error(err.ToString());
            }
            return result;
        }

        /// <summary>
        /// 新增检查地址信息
        /// <param name="entity">医技检查地点实体类</param>
        /// </summary>
        /// <returns>是否成功</returns>
        public bool AddCheckPointInfo(EntityCheckPoint entity)
        {
            var flag = false;
            try
            {
                flag = FuncWcfProxy.BaseWork(this, p => p.Channel.AddCheckPointInfo(entity));
            }
            catch (Exception err)
            {
                Log4Helper.Error(err.ToString());
            }
            return flag;
        }

        /// <summary>
        /// 更新检查地址信息
        /// <param name="entity">医技检查地点实体类</param>
        /// </summary>
        /// <returns>是否成功</returns>
        public bool UpdateCheckPointInfo(EntityCheckPoint entity)
        {
            var flag = false;
            try
            {
                flag = FuncWcfProxy.BaseWork(this, p => p.Channel.UpdateCheckPointInfo(entity));
            }
            catch (Exception err)
            {
                Log4Helper.Error(err.ToString());
            }
            return flag;
        }

        /// <summary>
        /// 删除检查地址信息
        /// <param name="entity">医技检查地点实体类</param>
        /// </summary>
        /// <returns>是否成功</returns>
        public bool DeleteCheckPointInfo(EntityCheckPoint entity)
        {
            var flag = false;
            try
            {
                flag = FuncWcfProxy.BaseWork(this, p => p.Channel.DeleteCheckPointInfo(entity));
            }
            catch (Exception err)
            {
                Log4Helper.Error(err.ToString());
            }
            return flag;
        }
        #endregion

        #region 检验目录维护代理
        /// <summary>
        /// 获取检验目录表数据
        /// </summary>
        /// <returns></returns>
        public List<EntityAssayCatalog> GetAssayCatalogList()
        {
            var dt = FuncWcfProxy.BaseWork(this, p => p.Channel.GetAssayCatalogList());
            return FuncTableHelper.DataTableToListByAttr<EntityAssayCatalog>(dt);
        }

        /// <summary>
        /// 保存检验目录
        /// </summary>
        /// <param name="entity">检验目录实体</param>
        /// <returns></returns>
        public bool SaveAssayCatalog(EntityAssayCatalog entity)
        {
            var res = FuncWcfProxy.BaseWork(this, p => p.Channel.SaveAssayCatalog(entity));
            return res;
        }
        /// <summary>
        /// 删除检验目录
        /// </summary>
        /// <param name="CatalogIds"></param>
        /// <returns></returns>
        public bool DeleteAssayCatalog(string CatalogIds)
        {
            var res = FuncWcfProxy.BaseWork(this, p => p.Channel.DeleteAssayCatalog(CatalogIds));
            return res;
        }
        #endregion
    }
}
