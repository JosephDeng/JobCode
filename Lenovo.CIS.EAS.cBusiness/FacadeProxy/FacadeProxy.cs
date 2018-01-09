/********************************************************************************
** Company： 联想智慧医疗
** auth：    凡福群
** date：    2018-01-04 16:55:43
** desc：    公共代理类
** Ver.:     V1.0.0
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lenovo.CIS.EAS.cBusiness
{

    /// <summary>
    /// 公共代理
    /// </summary>
    public class FacadeProxy
    {

        /// <summary>
        /// 公共基础代理
        /// </summary>
        /// <returns></returns>
        public static ProxyCommonBusiness CommonProxy()
        {
            return new ProxyCommonBusiness();
        }

        /// <summary>
        /// 检查相关操作代理
        /// </summary>
        /// <returns></returns>
        public static ProxyExamBusiness ExamProxy()
        {
            return new ProxyExamBusiness();
        }

        /// <summary>
        /// 检验相关操作代理
        /// </summary>
        /// <returns></returns>
        public static ProxyAssayBusiness AssayProxy()
        {
            return new ProxyAssayBusiness();
        }

        /// <summary>
        /// 手术相关操作代理
        /// </summary>
        /// <returns></returns>
        public static ProxyOperationBusiness OperationProxy()
        {
            return new ProxyOperationBusiness();
        }

        /// <summary>
        /// 检验相关操作代理
        /// </summary>
        /// <returns></returns>
        public static ProxyBloodBusiness BloodProxy()
        {
            return new ProxyBloodBusiness();
        }
    }
}
