/********************************************************************************
** Company： 联想智慧医疗
** auth：    凡福群
** date：    2018-01-08 11:03:02
** desc：    说明
** Ver.:     V1.0.0
*********************************************************************************/
using Lenovo.CIS.EAS.cBusiness;
using Lenovo.CIS.EAS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lenovo.CIS.EAS.cBusiness
{
    public class CheckPointMaintainPresentation
    {
        #region Method
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
        /// <summary>
        /// 新增检查地址信息
        /// <param name="entity">医技检查地点实体类</param>
        /// </summary>
        /// <returns>是否成功</returns>
        public bool AddCheckPointMaintain(EntityCheckPoint entity)
        {
            var _result =false;
            using (var proxy = FacadeProxy.CommonProxy())
            {
                _result = proxy.AddCheckPointInfo(entity);
            }
            return _result;
        }
        /// <summary>
        /// 更新检查地址信息
        /// <param name="entity">医技检查地点实体类</param>
        /// </summary>
        /// <returns>是否成功</returns>
        public bool UpdateCheckPointMaintain(EntityCheckPoint entity)
        {
            var _result = false;
            using (var proxy = FacadeProxy.CommonProxy())
            {
                _result = proxy.UpdateCheckPointInfo(entity);
            }
            return _result;
        }
        /// <summary>
        /// 删除检查地址信息
        /// <param name="entity">医技检查地点实体类</param>
        /// </summary>
        /// <returns>是否成功</returns>
        public bool DeleteCheckPointMaintain(EntityCheckPoint entity)
        {
            var _result = false;
            using (var proxy = FacadeProxy.CommonProxy())
            {
                _result = proxy.DeleteCheckPointInfo(entity);
            }
            return _result; 
        }
        #endregion
    }
}
