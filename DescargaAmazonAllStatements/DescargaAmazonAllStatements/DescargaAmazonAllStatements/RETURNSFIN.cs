using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescargaAmazonAllStatements
{
    class RETURNSFIN
    {
        public string settlementid { get; set; }

        public string settlementstartdate { get; set; }

        public string settlementenddate { get; set; }

        public string depositdate { get; set; }

        public string totalamount { get; set; }

        public string currency { get; set; }

        public string transactiontype { get; set; }

        public string orderid { get; set; }

        public string merchantorderid { get; set; }

        public string adjustmentid { get; set; }

        public string shipmentid { get; set; }

        public string marketplacename { get; set; }

        public string amounttype { get; set; }

        public string amountdescription { get; set; }

        public string amount { get; set; }

        public string fulfillmentid { get; set; }

        public string posteddate { get; set; }

        public string posteddatetime { get; set; }

        public string orderitemcode { get; set; }

        public string merchantorderitemid { get; set; }

        public string merchantadjustmentitemid { get; set; }

        public string sku { get; set; }

        public string quantitypurchased { get; set; }

        public string promotionid { get; set; }

    }
}
