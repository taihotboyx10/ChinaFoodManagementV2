using ChinaFoodManagementV2.Entity;
using ChinaFoodManagementV2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ChinaFoodManagementV2.DTO;
using System.Data.Entity;
using System.Linq.Dynamic.Core;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;

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

        public (List<BillMngDTO> bills, int totalCase, int totalPage) 
        GetBillByCondition(int currentPage, DateTime startDate, DateTime endDate, int sortBy, ListSortDirection sortDirection, string filterCond, string filterText = null)
        {
            int totalCase;
            int totalPage;
            List<BillMngDTO> billMngDTOs = new List<BillMngDTO>();

            using (var context = new ChinaFoodDBContext())
            {
                var query = from b in context.Bills
                            join t in context.Tables on b.TableId equals t.Id
                            where b.DateCheckout.Date >= startDate.Date && b.DateCheckout.Date <= endDate && b.StatusPaid == 1
                                  
                            select new BillMngDTO
                            {
                                BillId = b.Id,
                                TableName = t.TableName,
                                CheckoutDate = b.DateCheckout,
                                Discount = b.Discount,
                                Total = b.TotalPrice
                            };

                if (!string.IsNullOrEmpty(filterText))
                {
                    if (filterCond == "伝票番号")
                    {
                        int filterId;
                        if (int.TryParse(filterText, out filterId))
                        {
                            query = query.Where(b => b.BillId == filterId);
                        }
                    }
                    else if (filterCond == "テーブル名")
                    {
                        query = query.Where(b => b.TableName.Contains(filterText));
                    }
                }

                if (sortBy == 0)
                {
                    query = (sortDirection == ListSortDirection.Ascending) ? query.OrderBy(b => b.BillId) : query.OrderByDescending(b => b.BillId);
                }
                else if(sortBy == 1)
                {
                    query = (sortDirection == ListSortDirection.Ascending) ? query.OrderBy(b => b.CheckoutDate) : query.OrderByDescending(b => b.CheckoutDate);
                }
                else
                {
                    query = (sortDirection == ListSortDirection.Ascending) ? query.OrderBy(b => b.Total) : query.OrderByDescending(b => b.Total);
                }

                totalCase = query.Count();
                totalPage = (int)Math.Ceiling((double)totalCase / 15);
                billMngDTOs = query.Skip((currentPage - 1) * 15).Take(15).ToList();
            }
            return (billMngDTOs, totalCase, totalPage);
        }

        public List<BillMngDTO> GetAllBill()
        {
            List<BillMngDTO> billMngDTOs = new List<BillMngDTO>();
            using (var context = new ChinaFoodDBContext())
            {
                var query = from b in context.Bills
                            join t in context.Tables on b.TableId equals t.Id
                            where b.StatusPaid == 1
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
    }
}
