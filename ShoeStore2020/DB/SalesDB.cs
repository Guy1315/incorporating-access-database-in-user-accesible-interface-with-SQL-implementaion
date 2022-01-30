using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore2020.Model;
using ShoeStore2020.Data;
using System.Data;

namespace ShoeStore2020.DB
{
  public  class SalesDB : GeneralDB
    {

        public static string DETAIL_SALE_RELATION = "DetailToSale";
        public static string DETAIL_ITEMSALE_RELATION = "ItemDetailToItemSale";

        public SalesDB() : base("sales", "saleId")
        {
            ProductsDB items = new ProductsDB();
            DAL d = DAL.GetInstance();
            d.AddTable("salesdetails");
            DataTable details = d.GetTable("salesdetails");
            DataColumn key = table.Columns[primaryKey];
            DataColumn kf = details.Columns[primaryKey];
            DataColumn primmKey = items.GetPrimaryKeyColumn();
            d.AddRelation(DETAIL_SALE_RELATION, key, kf);
            d.AddRelation(DETAIL_ITEMSALE_RELATION, primmKey, details.Columns["productId"]);
        }
        public new Sales GetCurrentRow()
        {
            return new Sales(base.GetCurrentRow());
        }

        public int GetKey()
        {
            int x = currentRow;
            GoToLast();
            int key = Convert.ToInt32(base.GetCurrentRow()[primaryKey]) + 1;
            currentRow = x;
            return key;
        }
        public string GetKeyName()
        {
            return "ID";
        }
        public int Next()
        {
            return Convert.ToInt32(table.Rows[Size() - 1]["ID"]) + 1;
        }
        //מתאים ל Ilister
        public DataView GetDataView()
        {
            return new DataView(table);
        }
        public override void Save()
        {
            DAL.GetInstance().Update();
        }
        public string GetDisplay()
        {
            return "ID";
        }
        public string[] Headers()
        {
            string[] s = { "ID", "customer_ID", "transaction_date" };
            return s;
        }

    }
}
