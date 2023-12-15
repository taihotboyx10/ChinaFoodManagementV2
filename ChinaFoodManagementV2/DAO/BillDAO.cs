using ChinaFoodManagementV2.Entity;
using ChinaFoodManagementV2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChinaFoodManagementV2.DTO;
using System.Web.Management;
using System.Diagnostics.Eventing.Reader;
using System.Data.Entity;
using System.Linq.Dynamic.Core;

namespace ChinaFoodManagementV2.DAO
{
    public class BillDAO
    {
        public int InsertNewBill(Bill bill)
        {
            int result = 0;
            try
            {
                using (var context = new ChinaFoodDBContext())
                {
                    context.Bills.Add(bill);
                    result = context.SaveChanges();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowMessage("ERR_9999", MessageBoxButtons.OK, ex.Message);
                return result;
            }
        }

        public Bill GetBillByTableId(int tableId)
        {
            Bill bill = new Bill();
            using ( var context = new ChinaFoodDBContext())
            {
                bill = context.Bills.Where(b => b.TableId == tableId && b.StatusPaid == 0).SingleOrDefault();
            }
            return bill;
        }

        public Bill GetCurrentBill(int tableId)
        {
            Bill bill = new Bill();
            using (var context = new ChinaFoodDBContext())
            {
                bill = context.Bills.Where(b => b.TableId == tableId && b.StatusPaid == 0).FirstOrDefault();
            }

            return bill;
        }

        public List<BillDTO> GetAllBillInfo(int billId)
        {
            List<BillDTO> billList = new List<BillDTO>();
            using(var context = new ChinaFoodDBContext())
            {
                billList = (from b in context.BillInfos
                            join f in context.Foods on b.FoodId equals f.Id
                            where b.BillId == billId
                            select new BillDTO
                            {
                                BillInFoId = b.Id,
                                FoodName = f.FoodName,
                                Price = f.Price,
                                FoodCount = b.FoodCount,
                                Total = f.Price * b.FoodCount,
                                FoodId = b.FoodId,
                            }).ToList();
            }
            return billList;
        }

        public int CashierBill(int billId, int discount, long total)
        {
            try
            {
                using (var context = new ChinaFoodDBContext())
                {
                    Bill bill = context.Bills.Where(b => b.Id == billId).SingleOrDefault();
                    bill.DateCheckout = DateTime.Now;
                    bill.Discount = discount;
                    bill.StatusPaid = 1;
                    bill.TotalPrice = total;
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowMessage("ERR_9999", MessageBoxButtons.OK, ex.Message);
                return 0;
            }
        }

        public int UpdateTableIdWhenChangeTable(int billId, int tableDestId)
        {
            Bill bill = new Bill();
            try
            {
                using (var context = new ChinaFoodDBContext())
                {
                    bill = context.Bills.Where(b => b.Id == billId).SingleOrDefault();
                    //bill.TableId = tableDestId; 
                    bill.TableId = tableDestId;
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowMessage("ERR_9999", MessageBoxButtons.OK, ex.Message);
                return 0;
            }
        }

        public List<BillMngDTO> GetBillByCondition(DateTime currentDate, DateTime? startDate = null, DateTime? endDate = null)
        {
            List<BillMngDTO> billMngDTOs = new List<BillMngDTO>();

            using (var context = new ChinaFoodDBContext())
            {
                var query = from b in context.Bills
                            join t in context.Tables on b.TableId equals t.Id
                            where (startDate == null && endDate == null && b.DateCheckout.Date == currentDate.Date) ||
                                  (startDate != null && endDate != null && b.DateCheckout >= startDate.Value.AddDays(-1) && b.DateCheckout <= endDate)
                                  && b.StatusPaid == 1
                            select new BillMngDTO
                            {
                                BillId = b.Id,
                                TableName = t.TableName,
                                CheckoutDate = b.DateCheckout,
                                Discount = b.Discount,
                                Total = b.TotalPrice
                            };

                billMngDTOs = query.ToList();
            }

            return billMngDTOs;
        }

        public int GetAllBill()
        {
            using(var context =  new ChinaFoodDBContext())
            {
                return context.Bills.Count(b => b.StatusPaid == 1);
            }
        }

        public List<BillMngDTO> GetBillByPage(int startIndex, int maxRecords)
        {
            using (var context = new ChinaFoodDBContext())
            {
                var query = from b in context.Bills
                            join t in context.Tables on b.TableId equals t.Id
                            select new BillMngDTO
                            {
                                BillId = b.Id,
                                TableName = t.TableName,
                                CheckoutDate = b.DateCheckout,
                                Discount = b.Discount,
                                Total = b.TotalPrice
                            };

                return query.Skip(startIndex).Take(maxRecords).ToList();
            }
        }


    }
}
