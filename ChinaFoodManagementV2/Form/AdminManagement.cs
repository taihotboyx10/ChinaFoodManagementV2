using ChinaFoodManagementV2.DAO;
using ChinaFoodManagementV2.DTO;
using ChinaFoodManagementV2.Utils;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class FrmAdminManagement : Form
    {
        int currentPage = 1;
        int maxRecordOnPage = 14;

        public FrmAdminManagement()
        {
            InitializeComponent();
        }

        private void FrmAdminManagement_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

            cboEarningSort.SelectedIndex = 0;
        }

        /// <summary>
        /// ページ分割
        /// </summary>
        /// <param name="billMngDTOs"></param>
        private void DisplayBillOnCurrentPage(List<BillMngDTO> billMngDTOs)
        {
            //BillDAO billDAO = new BillDAO();
            int totalRecord = billMngDTOs.Count;

            int startIndex = (currentPage - 1) * maxRecordOnPage;
            int endIndex = Math.Min(startIndex + maxRecordOnPage, totalRecord);

            if (dgvEarning.Rows.Count > 0)
            {
                //dgvEarning.Rows.Clear();
            }

            for(int i = startIndex; i < endIndex; i++)
            {
                dgvEarning.Rows.Add(billMngDTOs[i]);
            }

            lblTotalCase.Text = Convert.ToString(billMngDTOs.Count);
            lblLastPage.Text = Convert.ToString(Convert.ToInt32((billMngDTOs.Count) / maxRecordOnPage) + 1);

        }

        private void DisplayTodayBill()
        {
            //int startIndex = (currentPage - 1) * maxRecordOnPage;

            BillDAO billDAO = new BillDAO();
            List<BillMngDTO> billMngDTOs = billDAO.GetBillByCondition(dtpDate.Value);
            var list = new SortableBindingList<BillMngDTO>(billMngDTOs);

            dgvEarning.AutoGenerateColumns = false;
            dgvEarning.DataSource = list;

            //DisplayBillOnCurrentPage(billMngDTOs);
        }

        private void DisplayFromToDateBill()
        {
            //int startIndex = (currentPage - 1) * maxRecordOnPage;

            BillDAO billDAO = new BillDAO();
            List<BillMngDTO> billMngDTOs = billDAO.GetBillByCondition(dtpFrom.Value, dtpFrom.Value, dtpTo.Value);
            var list = new SortableBindingList<BillMngDTO>(billMngDTOs);

            dgvEarning.AutoGenerateColumns = false;
            dgvEarning.DataSource = list;

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DisplayTodayBill();
        }


        private void btnFilterByDateToDate_Click(object sender, EventArgs e)
        {
            DisplayFromToDateBill();
        }

        private void cboEarningSort_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateSort();
        }

        private void rdDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSort();
        }

        private void UpdateSort()
        {
            int selectValue = cboEarningSort.SelectedIndex;
            ListSortDirection sortDirection = (rdDesc.Checked == true) ? ListSortDirection.Descending : ListSortDirection.Ascending;

            string colName = "";
            switch (selectValue)
            {
                case 0:
                    colName = "colId";
                    break;
                case 1:
                    colName = "colDate";
                    break;
                case 2:
                    colName = "colTotal";
                    break;
            }
            dgvEarning.Sort(dgvEarning.Columns[colName], sortDirection);

        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentPage--;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;

        }

    }
}
