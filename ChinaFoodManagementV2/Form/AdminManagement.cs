using ChinaFoodManagementV2.DAO;
using ChinaFoodManagementV2.DTO;
using ChinaFoodManagementV2.Entity;
using ChinaFoodManagementV2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using System.Linq;
using OfficeOpenXml.Style;

namespace ChinaFoodManagementV2
{
    public partial class FrmAdminManagement : Form
    {
        int currentPage = 1;
        int totalCase;
        int totalPage;
        int foodId;

        bool IsDtpDateValueChange = false;
        bool IsDateToDateFilterClick = false;

        public event EventHandler FoodAdded;

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

            LoadFood();
            LoadCategory();
        }

        private void LoadFood()
        {
            FoodDAO foodDAO = new FoodDAO();
            List<FoodDTO> foodDTOs = foodDAO.GetAllFood();

            dgvFood.DataSource = foodDTOs;

        }
        private void LoadCategory() 
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            List<Category> categories = categoryDAO.GetAllCategory();

            cboCategoryFood.DataSource = categories;
            cboCategoryFood.DisplayMember = "CategoryName";
        }
        
        private void DisplayBills()
        {
            btnPrevious.Enabled = (currentPage != 1);

            ListSortDirection sortDirection = (rdDesc.Checked == true) ? ListSortDirection.Descending : ListSortDirection.Ascending;
            int selectValue = cboEarningSort.SelectedIndex;
            string filterCond = null;
            if (rdBillId.Checked)
            {
                filterCond = rdBillId.Text;
            }
            if (rdTableName.Checked)
            {
                filterCond = rdTableName.Text;
            }


            BillDAO billDAO = new BillDAO();
            List<BillMngDTO> billMngDTOs = new List<BillMngDTO>();

            if (IsDtpDateValueChange == true)
            {
                DateTime nowDate = dtpDate.Value;
                (billMngDTOs, totalCase, totalPage ) = billDAO.GetBillByCondition(currentPage, nowDate, nowDate, selectValue, sortDirection, filterCond, txtFilTer.Text);
            }
            if(IsDateToDateFilterClick == true)
            {
                DateTime fromDate = dtpFrom.Value;
                DateTime toDate = dtpTo.Value;
                (billMngDTOs, totalCase, totalPage) = billDAO.GetBillByCondition(currentPage, fromDate, toDate, selectValue, sortDirection, filterCond, txtFilTer.Text);
            }

            var list = new SortableBindingList<BillMngDTO>(billMngDTOs);

            dgvEarning.AutoGenerateColumns = false;
            dgvEarning.DataSource = list;
            lblTotalCase.Text = Convert.ToString(totalCase);
            lblFirstPage.Text = Convert.ToString(currentPage);
            lblLastPage.Text = Convert.ToString(totalPage);

            btnNext.Enabled = (currentPage != totalPage);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            IsDateToDateFilterClick = false;
            IsDtpDateValueChange = true;
            DisplayBills();

        }

        private void btnFilterByDateToDate_Click(object sender, EventArgs e)
        {
            IsDtpDateValueChange = false;
            IsDateToDateFilterClick = true;
            DisplayBills();
        }

        private void cboEarningSort_SelectedValueChanged(object sender, EventArgs e)
        {
            DisplayBills();
        }

        private void rdDesc_CheckedChanged(object sender, EventArgs e)
        {
            DisplayBills();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(currentPage > 1)
            {
                currentPage--;
                DisplayBills();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentPage < totalPage)
            {
                currentPage++;
                DisplayBills();
            }
        }

        private void btnFilterCondClear_Click(object sender, EventArgs e)
        {
            txtFilTer.Text = string.Empty;
            DisplayBills();
        }

        private void txtFilTer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DisplayBills();
                e.SuppressKeyPress = true;
            }
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvFood.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvRow = dgvFood.SelectedRows[0];
                txtFoodName.Text = Convert.ToString(dgvRow.Cells["colName"].Value);
                cboCategoryFood.Text = Convert.ToString(dgvRow.Cells["colCategory"].Value);
                txtFoodPrice.Text = Convert.ToString(dgvRow.Cells["colPrice"].Value);

                foodId = Convert.ToInt32(dgvRow.Cells["colFoodId"].Value);

                if (e.ColumnIndex == dgvFood.Columns["colDelete"].Index)
                {
                    FoodDAO foodDAO = new FoodDAO();
                    if (foodDAO.DeleteFood(foodId) > 0)
                    {
                        MessageBox.Show("料理削除されました。", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFood();
                    }
                }
            }
        }

        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            FoodDAO foodDAO = new FoodDAO();
            Food food = new Food() 
            {
                FoodName = txtFoodName.Text,
                CategoryId = (cboCategoryFood.SelectedItem as Category).Id,
                Price = Convert.ToInt32(txtFoodPrice.Text)

            };
            
            if(foodDAO.AddNewFood(food) > 0)
            {
                MessageBox.Show("料理追加されました。", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                FoodAdded?.Invoke(this, EventArgs.Empty);
                LoadFood();

            }
        }

        private void btnFoodUpdate_Click(object sender, EventArgs e)
        {
            FoodDAO foodDAO = new FoodDAO();
            Food food = new Food()
            {
                Id = foodId,
                FoodName = txtFoodName.Text,
                CategoryId = (cboCategoryFood.SelectedItem as Category).Id,
                Price = Convert.ToInt32(txtFoodPrice.Text)
            };

            if (foodDAO.UpdateFood(food) > 0)
            {
                MessageBox.Show("料理更新されました。", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFood();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ExportExcelSub(ExcelPackage package)
        {
            var workbook = package.Workbook;

            ExcelWorksheet existingSheet = workbook.Worksheets.FirstOrDefault(sheet => sheet.Name == "Sheet1");
            if (existingSheet != null)
            {
                // Nếu tồn tại, xóa sheet đó đi
                workbook.Worksheets.Delete(existingSheet);
            }
            var worksheet = workbook.Worksheets.Add("Sheet1");

            BillDAO billDAO = new BillDAO();
            List<BillMngDTO> billMngDTOs = billDAO.GetAllBill();

            // Tạo column 
            string[] headerColumn = { "伝票番号", "テーブル名", "会計時間", "割引率", "小計" };
            for(int i = 0; i < headerColumn.Length; i++)
            {
                worksheet.Cells[1, i + 1].Value = headerColumn[i];
            }

            // Ghi dữ liệu vào Excel
            int row = 2;
            foreach (var item in billMngDTOs)
            {
                worksheet.Cells[row, 1].Value = item.BillId;
                worksheet.Cells[row, 2].Value = item.TableName;
                worksheet.Cells[row, 3].Value = item.CheckoutDate.Value.ToString("yyyy/MM/dd");
                worksheet.Cells[row, 4].Value = item.Discount;
                worksheet.Cells[row, 5].Value = item.Total;

                row++;
            }

            // Căn lề trái cho all cell
            foreach (var cell in worksheet.Cells)
            {
                cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            }

        }

        public void ExportExcel()
        {
            // Lưu file Excel
            string date = DateTime.Now.ToString("yyyyMMdd");
            string fileName = $"Bill_{date}.xlsx" ;
            string filePath = $"C:\\export_ex\\{fileName}";

            if (File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show("File đã tồn tại. Bạn có muốn ghi đè không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    // Nếu người dùng chọn OK, ghi đè file
                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        ExportExcelSub(package);

                        // Lưu file Excel
                        package.Save();
                    }

                    MessageBox.Show("Ghi đè file thành công.", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                // Nếu file không tồn tại, tiến hành tạo file mới và lưu dữ liệu
                using (var package = new ExcelPackage(filePath))
                {
                    ExportExcelSub(package);

                    // Lưu file Excel
                    package.Save();
                }

                MessageBox.Show("File đã được tạo mới thành công.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }
    }
}
