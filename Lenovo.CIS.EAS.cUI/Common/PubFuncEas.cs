using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using Lenovo.HIS.cUtils;
using Lenovo.HIS.Entities;

namespace Lenovo.CIS.EAS.cUI
{
    /// <summary>
    /// 公共方法
    /// </summary>
    public class PubFuncEas
    {
        /// <summary>
        /// 转换枚举列表中枚举值定义转换为List集合
        /// </summary>
        /// <param name="enumType">typeof(枚举类)</param>
        /// <returns>返回枚举值、描述集合</returns>
        public static List<EntityEnum> ConvertEnumToEntityList(Type enumType)
        {
            return (from object item in Enum.GetValues(enumType) select new EntityEnum() { Value = Convert.ToInt32(item), Description = item.ToString() }).ToList();
        }


        /// <summary>
        /// check GridView删除选择行
        /// </summary>
        /// <param name="gv"></param>
        /// <returns></returns>
        public static bool GridCheckDelFocusedRow<T>(GridView gv) where T:class
        {
            var fousedItem = gv.GetFocusedRow() as T;
            if (fousedItem == null)
            {
                FuncMessage.ShowErrorMsg(PubConstEas.StrSelectedLineInvalid);
                return false;
            }
            if (!FuncMessage.ShowMsgYesNo(PubConstEas.StrAskDelSelctedLine))
                return false;
            return true;
        }

        public static bool GetChekcSelectedLine(GridView gv)
        {
            var fousedItem = gv.GetFocusedRow();
            if (fousedItem == null)
            {
                FuncMessage.ShowErrorMsg(PubConstEas.StrSelectedLineInvalid);
                return false;
            }
            return true;
        }
        /// <summary>
        /// 获取种子
        /// </summary>
        /// <param name="tabName">种子表名</param>
        /// <param name="colName">种子列名</param>
        /// <param name="sqlCount">获取种子总数 默认=0</param>
        /// <param name="EnumSeq">种子类型默认申请类型</param>
        /// <returns></returns>
        public static int GetSquence(string tabName, string colName, int sqlCount = 0, EnumSequencecs EnumSeq = EnumSequencecs.Apply)
        {   
            var seq = FuncSquence.GetSquence(EnumSeq, "电子申请", "电子申请种子", tabName, colName);
            return seq;
        }
    }


    /// <summary>
    /// 枚举描述公共类
    /// </summary>
    public class EntityEnum
    {
        /// <summary>
        /// 枚举值
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// 枚举描述名称
        /// </summary>
        public string Description { get; set; }
    }
}
