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
    public class Orders : IEntity
    {
        private int orderId;
        private int supplierId;
        private DateTime orderDate;
        private DateTime arrivalDate;
        public int OrderId
        {
            set
            {
                if (ValidationUtilites.IsDigits(value.ToString()[0]) && value > 0)
                    this.orderId = value;
            }
            get
            {
                return this.orderId;
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
        public DateTime OrderDate
        {
            set
            {
                    this.orderDate = value;
            }
            get
            {
                return this.orderDate;
            }
        }
        public DateTime ArrivalDate
        {
            set
            {
                this.arrivalDate = value;
            }
            get
            {
                return this.arrivalDate;
            }
        }

        public Orders(int key) { this.orderId = key; }
        public Orders() { }
        public Orders(DataRow dr)
        {
            this.orderId = Convert.ToInt32(dr["orderId"]);
            this.supplierId = Convert.ToInt32(dr["supplierId"]);
            this.orderDate = Convert.ToDateTime(dr["orderDate"]);
            this.arrivalDate = Convert.ToDateTime(dr["arrivalDate"]);
        }
        public void Populate(DataRow dr)
        {
            dr["orderId"] = orderId;
            dr["supplierId"] = supplierId;
            dr["orderDate"] = orderDate;
            dr["arrivalDate"] = arrivalDate;
        }
    }
}
