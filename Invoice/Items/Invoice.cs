using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faktury.Utils;

namespace Faktury.Items
{
    public class Invoice
    {
        public int InvoiceNumer { get; set; }
        public ECurrencyItem Currency { get; set; }
        public List<Item> Items { get; set; }
        public List<Contractor> Contractors { get; set; }
        public DateTime DateMakeing { get; set; }
        public DateTime DateSelling { get; set; }
        public int PaymentType { get; set; }
        public DateTime DatePaying { get; set; }
        public string PaymentInfo { get; set; }
        public DateTime DateTable { get; set; }
        public string SellingPlace { get; set; }
        public string Warning { get; set; }
        public string PriceTax { get; set; }

        public Invoice()
        {
            Items = new List<Item>();
            Contractors = new List<Contractor>(2);
            InvoiceNumer = Data.Config.InvoiceNumer;
            Currency = Data.Config.NewDefaultCurrency;
        }

        public Invoice Clone()
        {
            var clone = this.MemberwiseClone() as Invoice;

            clone.Contractors = new List<Contractor>(this.Contractors.Count);
            this.Contractors.ForEach((item) =>
            {
                clone.Contractors.Add(item.Clone());
            });

            clone.Items = new List<Item>(this.Items.Count);
            this.Items.ForEach((item) =>
            {
                clone.Items.Add(item.Clone());
            });

            return clone;
        }
    }
}
