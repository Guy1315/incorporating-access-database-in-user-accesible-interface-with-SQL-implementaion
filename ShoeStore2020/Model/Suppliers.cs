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
    public class Suppliers : IEntity
    {
        private int supplierId;
        private string supplierName;
        private int contactNumber;
        private string contactMail;
        private string contactName;
        public int SupplierId
        {
            set
            {
                if (ValidationUtilites.LegalId(value.ToString())&& ValidationUtilites.IsDigits(value.ToString()[0])&& value>=0)
                    this.supplierId = value;
            }
            get
            {
                return this.supplierId;
            }
        }
        public string SupplierName
        {
            set
            {
                if(ValidationUtilites.LegalName(value.ToString()))
                this.supplierName = value;
            }
            get
            {
                return this.supplierName;
            }
        }
        public int ContactNumber
        {
            set
            {
                if (ValidationUtilites.PhoneNumber(value.ToString()))
                    this.contactNumber = value;
            }
            get
            {
                return this.contactNumber;
            }
        }
        public string ContactMail
        {
            set
            {
                    this.contactMail = value;
            }
            get
            {
                return this.contactMail;
            }
        }
        public string ContactName
        {
            set
            {
                if(ValidationUtilites.LegalName(value.ToString()))
                this.contactName = value;
            }
            get
            {
                return this.contactName;
            }
        }
        public Suppliers()
        { }
        public Suppliers(DataRow dr)
        {
            this.supplierId = Convert.ToInt32(dr["supplierId"]);
            this.supplierName = dr["supplierName"].ToString();
            this.contactNumber = Convert.ToInt32(dr["contactNumber"]);
            this.contactMail = dr["contactMail"].ToString();
            this.contactName = dr["contactName"].ToString();
        }
        public void Populate(DataRow dr)
        {
            dr["supplierId"] = supplierId;
            dr["supplierName"] = supplierName;
            dr["contactNumber"] = contactNumber;
            dr["contactMail"] = contactMail;
            dr["contactName"] = contactName;
        }
    }
}

