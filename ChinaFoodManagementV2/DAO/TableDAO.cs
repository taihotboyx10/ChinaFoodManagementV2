using ChinaFoodManagementV2.Entity;
using ChinaFoodManagementV2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinaFoodManagementV2.DAO
{
    public class TableDAO
    {
        public List<Table> GetAllTable()
        {
            List<Table> listTable = new List<Table>();
            using (var context = new ChinaFoodDBContext())
            {
                listTable = context.Tables.ToList();
            }

            return listTable;
        }

        public int UpdateTableStatus(int tableId)
        {
            try
            {
                Table table = new Table();
                using (var context = new ChinaFoodDBContext())
                {
                    table = context.Tables.Where(t => t.Id == tableId).FirstOrDefault();
                    if(table.TableStatus == 0)
                    {
                        table.TableStatus = 1;
                    }
                    else
                    {
                        table.TableStatus = 0;
                    }
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowMessage("ERR_9999", MessageBoxButtons.OK, ex.Message);
                return 0;
            }
        }

        public Table GetTableByTableId(int tableId)
        {
            Table table = new Table();
            using (var context = new ChinaFoodDBContext())
            {
                table = context.Tables.Where(t => t.Id == tableId).FirstOrDefault();
            }
            return table;
        }

        public List<Table> GetAllTableFull()
        {
            List<Table> tables = new List<Table>();
            using (var context = new ChinaFoodDBContext())
            {
                tables = context.Tables.Where(t => t.TableStatus == 1).ToList();
            }

            return tables;
        }

        public List<Table> GetAllTableEmpty()
        {
            List<Table> tables = new List<Table>();
            using (var context = new ChinaFoodDBContext())
            {
                tables = context.Tables.Where(t => t.TableStatus == 0).ToList();
            }

            return tables;
        }
    }
}
