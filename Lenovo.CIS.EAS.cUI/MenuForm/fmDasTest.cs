using System.Windows.Forms;
using Lenovo.HIS.cUtils;
using Lenovo.CIS.EAS.cBusiness;

namespace Lenovo.CIS.EAS.cUI
{
    public partial class fmDasTest : fmBase
    {
        public fmDasTest()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           var res= FacadeProxy.CommonProxy().GetComTest();
            MessageBox.Show(res);

        }
    }
}