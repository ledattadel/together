using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace THITRACNGHIEM
{
    public partial class rptDSDKThi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDSDKThi(string ngay1, string ngay2)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngay1;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngay2;
            this.sqlDataSource1.Fill();
        }

    }
}
