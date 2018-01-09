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
    /// 检验目录对应项目维护
    /// </summary>
    public partial class fmAssayCatalogMappingItem : DevExpress.XtraEditors.XtraForm
    {
        public fmAssayCatalogMappingItem()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmAssayItemSelection winItemSelection = new fmAssayItemSelection();
            winItemSelection.ShowDialog();
        }
    }
}