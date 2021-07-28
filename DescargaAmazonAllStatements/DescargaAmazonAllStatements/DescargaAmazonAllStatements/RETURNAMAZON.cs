using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescargaAmazonAllStatements
{
    class RETURNAMAZON
    {

        public string OrderID { get; set; }

        public DateTime Orderdate { get; set; }

        public DateTime Returnrequestdate { get; set; }

        public string Returnrequeststatus { get; set; }

        public string AmazonRMAID { get; set; }

        public string SellerRMAID { get; set; }

        public string Labeltype { get; set; }

        public float Labelcost { get; set; }

        public string Currencycode { get; set; }

        public string Returncarrier { get; set; }

        public string TrackingID { get; set; }

        public string Labeltobepaidby { get; set; }

        public string Atozclaim { get; set; }

        public string Isprime { get; set; }

        public string ASIN { get; set; }

        public string MerchantSKU { get; set; }

        public string ItemName { get; set; }

        public float Returnquantity { get; set; }

        public string Returnreason { get; set; }

        public string Inpolicy { get; set; }

        public string Returntype { get; set; }

        public string Resolution { get; set; }

        public string Invoicenumber { get; set; }

        public string Returndeliverydate { get; set; }

        public float OrderAmount { get; set; }

        public float Orderquantity { get; set; }

        public string SafeTActionreason { get; set; }

        public string SafeTclaimid { get; set; }

        public string SafeTclaimstate { get; set; }

        public string SafeTclaimcreationtime { get; set; }

        public string SafeTclaimreimbursementamount { get; set; }

        public string RefundedAmount { get; set; }
    }
}
