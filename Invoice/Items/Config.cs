using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury.Items
{
    public class Config
    {
        public int InvoiceNumer { get; set; }
        public bool isDebugOn { get; set; }
        public int DecimalSize { get; set; }

        public int DefaultPayment { get; set; }
        public ECurrencyItem NewDefaultCurrency { get; set; }
        public ECurrencyItem ConvertedCurrency { get; set; }
    }
}
