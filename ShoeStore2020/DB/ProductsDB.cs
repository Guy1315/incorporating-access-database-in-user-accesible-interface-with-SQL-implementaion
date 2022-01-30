using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore2020.Model;
using ShoeStore2020.Data;
using System.Data;
using System.Windows.Forms;

namespace ShoeStore2020.DB
{
    class ProductsDB : GeneralDB
    {
        public ProductsDB() : base("Products", "ProductId") { }
        public new Products GetCurrentRow()
        {
            return new Products(base.GetCurrentRow());
        }
        public int GetKey()
        {
            int x = currentRow;
            GoToLast();
            int key = Convert.ToInt32(base.GetCurrentRow()[primaryKey]) + 1;
            currentRow = x;
            return key;
        }
        //public DataView GetDataView()
        //{
        //    DAL d = DAL.GetInstance();
        //    DataTable a = d.GetDisplayTable("products", "Select customer_ID,    first_name,last_name From customers");
        //    return new DataView(table);
        //}
        public DataColumn GetPrimaryKeyColumn()
        {
            return table.Columns[primaryKey];
        }

        public static implicit operator Button(ProductsDB v)
        {
            throw new NotImplementedException();
        }
        //////////////////////////////
    }
}
