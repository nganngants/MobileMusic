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

namespace MobileMusic
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void fReport_Load(object sender, EventArgs e)
        {
            LoadData();
            this.reportViewer1.RefreshReport();
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(int));
            dt.Columns.Add("Note", typeof(string));
            dt.Columns.Add("Num", typeof(int));

            dt.Rows.Add(1, "Dầu ăn", 100, "Note 1", 10);
            dt.Rows.Add(2, "Sữa", 200, "Note 2", 20);
            dt.Rows.Add(3, "Sữa Tắm", 300, "Note 3", 30);
            dt.Rows.Add(4, "Dầu gội", 400, "Note 4", 40);
            dt.Rows.Add(5, "Bánh", 500, "Note 5", 50);

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "D:\\UIT\\CS511\\MobileMusic\\MobileMusic\\Report1.rdlc";

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "DataSet1";
            dts.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);
        }
    }
}
