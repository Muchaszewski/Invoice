using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faktury.Utils;

namespace Faktury.Items
{
    [Serializable]
    public class Contractor : IComparable<Contractor>
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }

        public EContractorType Type { get; set; }

        public string Street { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

        public string NIP { get; set; }
        public string REGON { get; set; }
        public string BankAccName { get; set; }
        public string BankAcc { get; set; }

        public int CompareTo(Contractor other)
        {
            return Name.CompareTo(other.Name);
        }

        public Contractor Clone()
        {
            return this.MemberwiseClone() as Contractor;
        }
    }

    public enum EContractorType
    {
        [Description("Sprzedawca")]
        SELLER,
        [Description("Nabywca")]
        BUYER,
        [Description("Wystawca")]
        EXHIBITOR,
        [Description("Odbiorca")]
        COSTUMER,
    }
}
