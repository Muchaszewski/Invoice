using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Faktury.Items;

namespace Faktury.Utils
{
    public class Description : Attribute
    {

        public string Text;

        public Description(string text)
        {
            Text = text;
        }

        public static string GetDescription(Enum en)
        {

            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {

                object[] attrs = memInfo[0].GetCustomAttributes(typeof(Description),
                                                                false);

                if (attrs != null && attrs.Length > 0)

                    return ((Description)attrs[0]).Text;

            }

            return en.ToString();

        }

    }

    public static class Utils
    {
        public static string ConvertToPriceCostum(decimal price, ECurrencyItem currency)
        {
            return string.Format("{0:0.00}", price) + DrawCurrency(currency);
        }
        public static string ConvertToPriceDefault(decimal price, ECurrencyItem currency)
        {
            return string.Format("{0:0.00}", price) + DrawCurrency(currency);
        }
        public static string ConvertToDigitsCostum(decimal price)
        {
            return string.Format("{0:0.00}", price);
        }

        public static string DrawCurrency(ECurrencyItem currency)
        {
            switch (currency)
            {
                case ECurrencyItem.EUR: return "€";
                case ECurrencyItem.PLN: return "zł";
            }
            return "NIEZNANY BŁĄD W WALUCIE";

        }

        public static string ConvertToTax(int tax)
        {
            return tax.ToString() + "%";
        }

        public static string CalculateTaxValue(decimal price, int tax)
        {
                decimal value = (price * ((decimal)tax / 100m));
                return ConvertToDigitsCostum(value);
        }

        public static string CalculateTaxValuePrice(decimal price, int tax)
        {
            decimal value = (price * ((decimal)tax / 100m)) + price;
            return ConvertToDigitsCostum(value);
        }


        public static string CalculateTaxQuantityValuePrice(decimal price, int tax, decimal quantity)
        {
            decimal value = (price * ((decimal)tax / 100m));
            value *= quantity;
            return ConvertToDigitsCostum(value);
        }

        public static string CalculateTaxQuantityValue(decimal price, int tax, decimal quantity)
        {
            decimal value = (price * ((decimal)tax / 100m)) + price;
            value *= quantity;
            return ConvertToDigitsCostum(value);
        }
        public static string CalculateQuantityValue(decimal price, int tax, decimal quantity)
        {
            decimal value = price;
            value *= quantity;
            return ConvertToDigitsCostum(value);
        }

        public static string CalculateFrac(decimal price)
        {
            price = Convert.ToDecimal(string.Format("{0:0.00}", price));
            decimal value = decimal.Truncate(Convert.ToDecimal(string.Format("{0:0.00}", (price - decimal.Truncate(price))))* 100);
            if(value == 100)
            {
                return "00";
            }
            else if(value == 0)
            {
                return "00";
            }
            else 
            {
                if (value < 10)
                {
                    return value.ToString() + "0";
                }
                else
                {
                    return value.ToString();
                }
            }
        }

    }
}
