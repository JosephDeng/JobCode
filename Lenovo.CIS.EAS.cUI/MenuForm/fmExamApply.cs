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

namespace Lenovo.CIS.EAS.cUI
{

    /// <summary>
    /// 检查申请
    /// </summary>
    public partial class fmExamApply : DevExpress.XtraEditors.XtraForm
    {
        public fmExamApply()
        {
         
            // this.Appearance.Font =
         

            InitializeComponent();
           // 
         
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainerControl3.Horizontal = !splitContainerControl3.Horizontal;
        }
    }
}