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
    /// 医嘱项目对应收费项目维护
    /// </summary>
    public partial class fmProjectMappingCharge : DevExpress.XtraEditors.XtraForm
    {
        public fmProjectMappingCharge()
        {
            InitializeComponent();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}