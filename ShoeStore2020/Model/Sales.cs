using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore2020.Utility;
using ShoeStore2020.GUI;
using System.Data;
using ShoeStore2020.Model;
using ShoeStore2020.DB;
using System.Windows.Forms;

namespace ShoeStore2020.Model
{
    public class Sales:IEntity
    {
        private int saleId;
        private DateTime dateSale;
        private List<SaleDetails> details;
        public Sales(int id)
        {
            this.saleId = id;
            details = new List<SaleDetails>(); 
        }
        public int SaleId
        {
            set
            {
                if (value <= 0)
                    throw new Exception("חייב מספר גדול מאפס");
                this.saleId = value;
            }
            get
            {
                return this.saleId;
            }
        }
        public DateTime DateSale
        {
            set
            {
                if (DateTime.Today.CompareTo(this.dateSale) > 1)
                    throw new Exception("אין הזמנות עתידיות");
                dateSale = value;
            }
            get
            {
                return dateSale;
            }
        }

        public Sales() { }
        public Sales(DataRow dr)
            : this(Convert.ToInt32(dr[0]))
        {
            this.saleId = Convert.ToInt32(dr["saleId"]);
            this.dateSale = Convert.ToDateTime(dr["DateSale"]);
            foreach (DataRow d in dr.GetChildRows(SalesDB.DETAIL_SALE_RELATION))
            {
                details.Add(new SaleDetails(d));//פריטים בהזמנה
            }
        }
        public void Populate(DataRow dr)
        {
            dr["saleId"] = saleId;
            dr["DateSale"] = dateSale;
        }
        public int HowManyDetails()
        {
            return this.details.Count;
        }

       
        public void Update(int rowNo, int amountOfProducts)
        {
            details[rowNo].AmountOfProducts = amountOfProducts;
        }
        public void RemoveProduct(int rowNo)
        {
            details.RemoveAt(rowNo);
        }
        public string[] Details(int row)
        {
            return details[row].Display();
        }
        public double GetTotal()
        {
            double sum = 0;
            foreach (SaleDetails d in details)
                sum += d.Total;
            return sum;
        }
        public void AddItem(Products productId, int qty)
        {//add item to list
            SaleDetails detail = new SaleDetails(productId,saleId, qty);
            details.Add(detail);
        }
       
        class SaleDetails
        {
            private Products productId;
            //private int saleId;
            private int amountOfProducts;
            private Products price;
            public SaleDetails(Products productId, int saleId, int amountOfProducts)
            {
                this.productId = productId;
               // this.saleId = saleId;
                this.amountOfProducts = amountOfProducts;
            }
          

            public SaleDetails() { }
            public SaleDetails(DataRow dr)
      
            {
                this.productId = new Products(dr.GetParentRow(SalesDB.DETAIL_ITEMSALE_RELATION));
                //  this.saleId = Convert.ToInt32(dr["saleId"]);
                this.amountOfProducts = Convert.ToInt32(dr["amount"]);
            }
            public void Populate(int saleId, DataRow dr)
            {
                dr["productId"] = productId;
                dr["saleId"] = saleId;
                dr["amount"] = amountOfProducts;
            }
           
            public Products DetailItem
            {
                set
                {
                    this.productId = value;
                }
                get
                {
                    return this.productId;
                }
            }
            public int AmountOfProducts
            {
                set
                {
                    if (value < 1)
                        throw new Exception("חייבים להזמין פריט אחד לפחות");
                    this.amountOfProducts = value;
                }
                get
                {
                    return this.amountOfProducts;
                }
            }
            public Products UnitPrice
            //למרות שאין שדה כזה ניתן לבנות במחלקה שדה מחושב
            {
                set
                {
                   
                    price= value;
                }
                get
                {
                    return this.price;
                }
            }
            public int Total
            {
                get
                {
                    return (Convert.ToInt32(UnitPrice)) * ((amountOfProducts));
                }
            }
            public string[] Display()
            {
                string[] arr = new string[5];
                arr[0] = productId.ProductId.ToString();
                arr[1] = productId.Category;
                arr[2] = string.Format("{0:C}", UnitPrice);
                arr[3] = amountOfProducts.ToString();
                arr[4] = string.Format("{0:C}", Total);
                return arr;
            }

        }
        

    }

}

