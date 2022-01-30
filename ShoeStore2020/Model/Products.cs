using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore2020.Utility;
using ShoeStore2020.GUI;
using System.Data;
using ShoeStore2020.Model;
using System.Windows.Forms;

namespace ShoeStore2020.Model
{
    public class Products : IEntity
    {
        private int productId;
        private int Psize;
        private int Pprice;
        private string Pbrand;
        private string Ptype;
        private string Pcategory;
        private string shoeColor;
        private int supplierId;
        private int amountOfProducts;
        public int ProductId
        {
            set
            {
                if (ValidationUtilites.IsDigits(value.ToString()[0]) && value > 0)
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
                if (value > 0)
                    this.amountOfProducts = value;
            }
            get
            {
                return this.amountOfProducts;
            }
        }
        public int Size
        {
            set
            {
                if (value > 0)
                    this.Psize = value;
            }
            get
            {
                return this.Psize;
            }
        }
        public int Price
        {
            set
            {
                if (value > 0)
                    this.Pprice = value;
            }
            get
            {
                return this.Pprice;
            }
        }
        public string Brand
        {
            set
            {
                
                this.Pbrand = value;
            }
            get
            {
                return this.Pbrand;
            }
        }
        public string Type
        {
            set
            {
                this.Ptype = value;
            }
            get
            {
                return this.Ptype;
            }
        }
        public string Category
        {
            set
            {
                this.Pcategory = value;
            }
            get
            {
                return this.Pcategory;
            }
        }
        public string ShoeColor
        {
            set
            {
                this.shoeColor = value;
            }
            get
            {
                return this.shoeColor;
            }
        }
        public int SupplierId
        {
            set
            {
                if(ValidationUtilites.LegalId(value.ToString()) && ValidationUtilites.IsDigits(value.ToString()[0]) && value >= 0)
                    this.supplierId = value;
            }
            get
            {
                return this.supplierId;
            }
        }
        public Products() { }
        public Products(DataRow dr)
        {
            this.ProductId = Convert.ToInt32(dr["productId"]);
            this.Psize = Convert.ToInt32(dr["Psize"]);
            this.Pprice = Convert.ToInt32(dr["Pprice"]);
            this.supplierId = Convert.ToInt32(dr["supplierId"]);
            this.Pbrand = dr["Pbrand"].ToString();
            this.Ptype = dr["Ptype"].ToString();
            this.Pcategory = dr["Pcategory"].ToString();
            this.shoeColor = dr["shoeColor"].ToString();
            this.amountOfProducts = Convert.ToInt32(dr["amountOfProducts"]);
        }
        public void Populate(DataRow dr)
        {
            dr["productId"] = productId;
            dr["Psize"] = Psize;
            dr["Pprice"] = Pprice;
            dr["Pbrand"] = Pbrand;
            dr["Ptype"] = Ptype;
            dr["Pcategory"] = Pcategory;
            dr["shoeColor"] = shoeColor;
            dr["supplierId"] = supplierId;
            dr["amountOfProducts"] = amountOfProducts; 
        }
    }
}
