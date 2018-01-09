/********************************************************************************
** Company： 联想智慧医疗
** auth：    凡福群
** date：    2018-01-04 12:40:13
** desc：    视图基接口
** Ver.:     V1.0.0
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lenovo.CIS.EAS.cBusiness
{
    public interface IView<T> where T : class
    {
        T Model { get; set; }
    }
}
