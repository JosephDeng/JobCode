using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lenovo.CIS.EAS.cBusiness
{
    public interface IPresenter<T> where T : class
    {
        T View { get; }
    }
}
