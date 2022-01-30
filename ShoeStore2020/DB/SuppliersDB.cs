using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore2020.Model;
using ShoeStore2020.Data;

namespace ShoeStore2020.DB
{
    class SuppliersDB : GeneralDB
    {
        public SuppliersDB() : base("Suppliers", "supplierId") { }
        public new Suppliers GetCurrentRow()
        {
            return new Suppliers(base.GetCurrentRow());
        }
        public int GetKey()
        {
            int x = currentRow;
            GoToLast();
            int key = Convert.ToInt32(base.GetCurrentRow()[primaryKey]) + 1;
            currentRow = x;
            return key;
        }
    }
}
