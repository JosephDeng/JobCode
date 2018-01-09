/********************************************************************************
** Company： 联想智慧医疗
** auth：    凡福群
** date：    2018-01-04 16:55:43
** desc：    代理类
** Ver.:     V1.0.0
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lenovo.HIS.cUtils;
using Lenovo.CIS.EAS.IBusiness;

namespace Lenovo.CIS.EAS.cBusiness
{
    public class ProxyEasBusiness : ProxyBase<IEasBusiness>
    {
        public ProxyEasBusiness() : base(PubVar.g_WcfEndPoint.Find(p => p.Key == EasPubConst.g_EndPointName).Value) { }
    }
}
