/********************************************************************************
** Company： 联想智慧医疗
** auth：    凡福群
** date：    2018-01-08 12:54:44
** desc：    说明
** Ver.:     V1.0.0
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lenovo.CIS.EAS.cBusiness
{
    public class Presenter<T>:IPresenter<T> where T : class
    {
        private readonly T view;
        //这里的view作为引用，用于在presenter中获取View的实例
        protected Presenter(T view)
        {
            this.view = view;
        }
        public T View { get { return view; } }

    }
}
