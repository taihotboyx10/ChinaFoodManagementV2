using ChinaFoodManagementV2.DAO;
using ChinaFoodManagementV2.Entity;
using ChinaFoodManagementV2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChinaFoodManagementV2.DTO;
using System.Globalization;

namespace ChinaFoodManagementV2
{
    public partial class FrmMain : Form
    {
        long cashierWG = 0;
        private string userName;
        public FrmMain(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadTable();
            LoadTableFull();
            LoadTableEmpty();

            lblUserName.Text = userName;
        }

        private void LoadTable()
        {
            pnlTable.Controls.Clear();

            TableDAO tableDAO = new TableDAO();
            List<Table> tables = tableDAO.GetAllTable();
            foreach (Table table in tables)
            {
                Button btnTable = new Button();
                btnTable.Tag = table;
                btnTable.Click += BtnTable_Click;

                btnTable.Size = new Size(100, 70);
                btnTable.BackColor = Color.DeepSkyBlue;
                btnTable.Text = table.TableName;
                if (table.TableStatus == 1)
                {
                    btnTable.BackColor = Color.LightCoral;
                    btnTable.Text = table.TableName + '\n' + "(満)";
                }
                

                pnlTable.Controls.Add(btnTable);
            }
        }

        private void LoadCategory()
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            List<Category> categories = categoryDAO.GetAllCategory();
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "CategoryName";
        }

        private void LoadFood(int categoryId)
        {
            FoodDAO foodDAO = new FoodDAO();
            List<Food> foods = foodDAO.GetFoodByCategory(categoryId);
            cboFoodName.DataSource = foods;
            cboFoodName.DisplayMember = "FoodName";
        }

        private void cboCategory_SelectedValueChanged(object sender, EventArgs e)
        {
           Category category = cboCategory.SelectedItem as Category;
            if (cboCategory.SelectedValue != null)
            {
                LoadFood(category.Id);
            }
        }

        #region Validate
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Từ chối ký tự không phải số và ký tự điều khiển (như Backspace)
            }
        }
        #endregion

        private void BtnTable_Click(object sender, EventArgs e)
        {
            Table table = (sender as Button).Tag as Table;
            lblTableName.Visible = true;
            lblTableName.Text = table.TableName;
            dgvMain.Tag = (sender as Button).Tag;
            ShowBill(table.Id);
        }

        private void ShowBill(int tableId) 
        {
            BillDAO billDAO = new BillDAO();
            Bill bill = billDAO.GetCurrentBill(tableId);

            List<BillDTO> billDTOs = new List<BillDTO>();
            if (bill != null)
            {
                billDTOs = billDAO.GetAllBillInfo(bill.Id);
            }

            dgvMain.AutoGenerateColumns = false;
            dgvMain.DataSource = billDTOs;

            long total = 0;
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                total += Convert.ToInt32(row.Cells["Total"].Value);
            }
            cashierWG = total;
            txtCashier.Text = total.ToString("C", CultureInfo.GetCultureInfo("ja"));
        }

        private void InsertBill(Table table)
        {
            Bill bill = new Bill() 
            { 
                DateCheckin = DateTime.Now,
                DateCheckout = DateTime.MinValue,
                StatusPaid = 0,
                TableId = table.Id
            };

            BillDAO billDAO = new BillDAO();
            if(table.TableStatus == 0)
            {
                if(billDAO.InsertNewBill(bill) > 0)
                {
                    TableDAO tableDAO = new TableDAO();
                    tableDAO.UpdateTableStatus(table.Id);
                    LoadTableFull();
                    LoadTableEmpty();
                    dgvMain.Tag = tableDAO.GetTableByTableId(table.Id);
                }
            }

            LoadTable();
            
        }
        private void InsertBillInfo(int tableId)
        {

            BillDAO billDAO = new BillDAO();
            Bill bill = billDAO.GetCurrentBill(tableId);

            BillInfo billInfo = new BillInfo()
            {
                FoodCount = Convert.ToInt32(nmrFoodNum.Value),
                BillId = bill.Id,
                FoodId = (cboFoodName.SelectedItem as Food).Id
            };

            List<BillDTO> billDTOs = new List<BillDTO>();
            if (bill != null)
            {
                billDTOs = billDAO.GetAllBillInfo(bill.Id);
            }

            int foodId = (cboFoodName.SelectedItem as Food).Id;

            BillInfoDAO billInfoDAO = new BillInfoDAO();
            FoodDAO foodDAO = new FoodDAO();
            if (billDTOs.Count == 0)
            {
                billInfoDAO.InsertNewBillInfo(billInfo);
            }
            else
            {
                bool isFoodIdMatch = false;

                foreach (BillDTO billDTO in billDTOs)
                {
                    if (billDTO.FoodId == foodId)
                    {
                        foodDAO.AddFoodQuantity(Convert.ToInt32(nmrFoodNum.Value), billDTO.BillInFoId);
                        isFoodIdMatch = true;
                        break;
                    }
                }
                if (!isFoodIdMatch)
                {
                    billInfoDAO.InsertNewBillInfo(billInfo);
                }
            }
        }

        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            BillDAO billDAO = new BillDAO();

            Table table = dgvMain.Tag as Table;

            // 料理追加する前にテーブル選択
            if (table == null)
            {
                MessageUtil.ShowMessage("ERR_2006", MessageBoxButtons.OK, this.Text);
                return;
            }

            // TH1: nếu bàn trống insert bill và billInfo
            // TH2: Đã có bill và thêm món mới vào bill: insert món mới vào billInFo
            InsertBill(table);
            InsertBillInfo(table.Id);

            ShowBill(table.Id);

        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Table table = dgvMain.Tag as Table; 

            if (e.ColumnIndex == dgvMain.Columns["ColDelete"].Index && e.RowIndex >= 0)
            {
                BillDTO billDTO = dgvMain.SelectedRows[0].DataBoundItem as BillDTO;

                BillInfoDAO billInfoDAO = new BillInfoDAO();
                if(billInfoDAO.DeleteBillInFo(billDTO.BillInFoId) > 0)
                {
                    ShowBill(table.Id);
                }
            }
        }

        /// <summary>
        /// 割引適用
        /// </summary>
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            int discount;
            
            if (!string.IsNullOrEmpty(txtDiscount.Text))
            {
                discount = Convert.ToInt32(txtDiscount.Text);

                if (discount > 0 && discount < 100)
                {
                    if (MessageUtil.ShowMessage("QUES_1003", MessageBoxButtons.OKCancel, this.Text) == DialogResult.OK)
                    {
                        float discountPercentage = (float)discount / 100;
                        cashierWG = Convert.ToInt32(cashierWG * (1 - discountPercentage));
                        txtCashier.Text = cashierWG.ToString("C", CultureInfo.GetCultureInfo("ja"));

                    }

                }
            }
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            Table table = dgvMain.Tag as Table;
            if(table != null && table.TableStatus == 1)
            {
                if(MessageUtil.ShowMessage("QUES_1002", MessageBoxButtons.OKCancel, this.Text) == DialogResult.OK )
                {
                    BillDAO billDAO = new BillDAO();

                    int discount = 0;
                    long cashier = 0;
                    if (!string.IsNullOrEmpty(txtDiscount.Text))
                    {
                        discount = Convert.ToInt32(txtDiscount.Text);
                    }
                    if (!string.IsNullOrEmpty(txtCashier.Text))
                    {
                        cashier = cashierWG;
                    }

                    int billId = 0;
                    Bill bill = billDAO.GetBillByTableId(table.Id);
                    if(bill != null)
                    {
                        billId = bill.Id;

                    }
                    if (billDAO.CashierBill(billId, discount, cashier) > 0) 
                    {
                        TableDAO tableDAO = new TableDAO();
                        tableDAO.UpdateTableStatus(table.Id);

                        MessageUtil.ShowMessage("INF_3001", MessageBoxButtons.OKCancel, this.Text);

                        table.TableStatus = 0;
                        LoadTable();
                        txtDiscount.Text = "";
                        LoadTableFull();
                        LoadTableEmpty();
                    }
                }
            }
        }

        private void LoadTableFull()
        {
            TableDAO tableDAO= new TableDAO();
            List<Table> tables = tableDAO.GetAllTableFull();
            cboTableBase.DataSource = tables;
            cboTableBase.DisplayMember = "TableName";
        }

        private void LoadTableEmpty()
        {
            TableDAO tableDAO = new TableDAO();
            List<Table> tables = tableDAO.GetAllTableEmpty();
            cboTableDestination.DataSource = tables;
            cboTableDestination.DisplayMember = "TableName";
        }

        //TODO
        //update status cua table
        //chuyen table_id sang tbl khac
        private void btnTableChange_Click(object sender, EventArgs e)
        {
            if(cboTableBase.Items.Count == 0)
            {
                return;
            }
            if (MessageUtil.ShowMessage("QUES_1004", MessageBoxButtons.OKCancel, this.Text) == DialogResult.OK)
            {
                Table tableBase = cboTableBase.SelectedItem as Table;
                Table tableDest = cboTableDestination.SelectedItem as Table;

                TableDAO tableDAO = new TableDAO();
                tableDAO.UpdateTableStatus(tableBase.Id);
                tableDAO.UpdateTableStatus(tableDest.Id);

                BillDAO billDAO = new BillDAO();
                Bill bill = billDAO.GetBillByTableId(tableBase.Id);

                if(billDAO.UpdateTableIdWhenChangeTable(bill.Id, tableDest.Id) > 0)
                {
                    LoadTable();
                    LoadTableFull();
                    LoadTableEmpty();
                }
            }
            
        }

        #region ToolStrip_Click
        private void ログアウトToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 管理者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminManagement frmAdminManagement = new FrmAdminManagement();
            frmAdminManagement.Show();
            //frmAdminManagement.FoodAdded += FrmAdminManagement_FoodAdded;
            frmAdminManagement.FormClosed += FrmAdminManagement_FormClosed;
            this.Hide();
        }

        private void FrmAdminManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void FrmAdminManagement_FoodAdded(object sender, EventArgs e)
        {

        }
        #endregion

        private void 個人情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
