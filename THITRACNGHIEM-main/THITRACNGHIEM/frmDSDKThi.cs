using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITRACNGHIEM
{
    public partial class frmDSDKThi : Form
    {
        public frmDSDKThi()
        {
            InitializeComponent();
        }

        private string FormatDate(string date)
        {
            string[] t = date.Split('/');
            return t[1] + "/" + t[0] + "/" + t[2];
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            rptDSDKThi rpt = new rptDSDKThi(dptNgay1.Text.Trim(), dptNgay2.Text.Trim());
            rpt.lblCoSo.Text = ((DataRowView)Program.bds_dspm[Program.mCoso])["TEN_COSO"].ToString();
            rpt.lblNgay.Text = "TỪ NGÀY " + FormatDate(dptNgay1.Text.Trim()) + " ĐẾN NGÀY " + FormatDate(dptNgay2.Text.Trim());

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
