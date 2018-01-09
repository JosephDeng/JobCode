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
    /// 检验申请
    /// </summary>
    public partial class fmAssayApply : DevExpress.XtraEditors.XtraForm
    {
        public fmAssayApply()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}