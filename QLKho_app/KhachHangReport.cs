using BUS;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho_app
{
    public partial class KhachHangReport : Form
    {
        BUS_Customer busCustomers;
        public KhachHangReport()
        {
            InitializeComponent();
            busCustomers = new BUS_Customer();
        }

        private void KhachHangReport_Load(object sender, EventArgs e)
        {
            var dsCustomers = busCustomers.getThanhVien();
            


            this.reportViewerKhachHang.LocalReport.DataSources.Clear();
            ReportDataSource ds = new ReportDataSource("DataSet1", dsCustomers);
            this.reportViewerKhachHang.LocalReport.ReportEmbeddedResource = "QLKho_app.ReportDefinitions.rpKhachHang.rdlc";
            this.reportViewerKhachHang.LocalReport.DataSources.Add(ds);

            reportViewerKhachHang.RefreshReport();
        }
    }
}
