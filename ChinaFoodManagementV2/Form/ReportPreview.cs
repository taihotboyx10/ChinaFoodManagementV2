using ChinaFoodManagementV2.DAO;
using ChinaFoodManagementV2.DTO;
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

namespace ChinaFoodManagementV2
{
    public partial class ReportPreview : Form
    {
        public ReportPreview()
        {
            InitializeComponent();
        }

        private void ReportPreview_Load(object sender, EventArgs e)
        {
            FillDataToReport();
            this.UriageRv.RefreshReport();
        }

        private void FillDataToReport()
        {
            BillDAO billDAO = new BillDAO();
            List<BillMngDTO> billMngDTOs = billDAO.GetAllBill();

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);

            foreach (var property in typeof(BillMngDTO).GetProperties())
            {
                Type columnType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                dt.Columns.Add(property.Name, columnType);
            }

            foreach (BillMngDTO billMngDTO in billMngDTOs)
            {
                DataRow row = dt.NewRow();

                // Đổ dữ liệu từ BillMngDTO vào DataRow
                foreach (var property in typeof(BillMngDTO).GetProperties())
                {
                    row[property.Name] = property.GetValue(billMngDTO);
                }

                dt.Rows.Add(row);
            }

            UriageRv.LocalReport.ReportEmbeddedResource = "ChinaFoodManagementV2.BillReport.rdlc";
            // Kết nối DataSet với ReportDataSource
            ReportDataSource reportDataSource = new ReportDataSource("aaa", ds.Tables[0]);

            // Gán ReportDataSource vào ReportViewer
            UriageRv.LocalReport.DataSources.Clear();
            UriageRv.LocalReport.DataSources.Add(reportDataSource);
            //UriageRv.Dock = DockStyle.Fill;
        }
    }
}
