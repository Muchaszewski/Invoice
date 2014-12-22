using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Faktury.Utils;

namespace Faktury.Items
{
    [Serializable]
    public class Item : IComparable<Item>
    {
        public string Name { get; set; }
        public EUnitItem Unit { get; set; }
        public decimal Price { get; set; }
        public int Tax { get; set; }
        public string Other { get; set; }
        public int Quantity { get; set; }

        public int CompareTo(Item other)
        {
            return Name.CompareTo(other.Name);
        }

        public Item Clone()
        {
            return this.MemberwiseClone() as Item;
        }
    }

    public enum EUnitItem
    {
        [Description("szt.")]
        ITEM,
        [Description("kg.")]
        KILO,
        [Description("op.")]
        PACKAGE,

        [Description("cm2")]
        CENTYMETERCUBIC,
        [Description("m2")]
        METERCUBIC,

        [Description("litr")]
        LITER,
        [Description("m3")]
        METERSQ,

        [Description("min")]
        MINUTE,
        [Description("godz")]
        HOUR,
        [Description("mc")]
        MONTH,

        [Description("metr")]
        METER,
        [Description("km")]
        KILOMETER,



    }

    public enum ECurrencyItem
    {
        [Description("zł")]
        PLN,
        [Description("euro")]
        EUR,
    }

    public class Tax
    {
        public int TaxAmount { get; set; }
        public decimal Price { get; set; }
        public decimal PriceTax { get; set; }

        public Tax(int tax, decimal price, decimal priceTax)
        {
            TaxAmount = tax;
            Price = price;
            PriceTax = priceTax;
        }
    }

}
