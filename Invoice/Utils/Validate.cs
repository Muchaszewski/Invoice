using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury.Utils
{
    public static class Validate
    {
        static public bool Regon(string RegonValidate)
        {
            byte[] weights;
            ulong regon = ulong.MinValue;
            byte[] digits;

            if (ulong.TryParse(RegonValidate, out regon).Equals(false)) return false;

            switch (RegonValidate.Length)
            {
                case 7:
                    weights = new byte[] { 2, 3, 4, 5, 6, 7 };
                    break;

                case 9:
                    weights = new byte[] { 8, 9, 2, 3, 4, 5, 6, 7 };
                    break;

                case 14:
                    weights = new byte[] { 2, 4, 8, 5, 0, 9, 7, 3, 6, 1, 2, 4, 8 };
                    break;

                default:
                    return false;
            }

            string sRegon = regon.ToString();
            digits = new byte[sRegon.Length];

            for (int i = 0; i < sRegon.Length; i++)
            {
                if (byte.TryParse(sRegon[i].ToString(), out digits[i]).Equals(false)) return false;
            }

            int checksum = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                checksum += weights[i] * digits[i];
            }

            return (checksum % 11 % 10).Equals(digits[digits.Length - 1]);

        }

        static public bool NIP(string NIPValidate)
        {
            const byte lenght = 10;

            ulong nip = ulong.MinValue;
            byte[] digits;
            byte[] weights = new byte[] { 6, 5, 7, 2, 3, 4, 5, 6, 7 };

            if (NIPValidate.Length.Equals(lenght).Equals(false)) return false;

            if (ulong.TryParse(NIPValidate, out nip).Equals(false)) return false;
            else
            {
                string sNIP = NIPValidate.ToString();
                digits = new byte[lenght];

                for (int i = 0; i < lenght; i++)
                {
                    if (byte.TryParse(sNIP[i].ToString(), out digits[i]).Equals(false)) return false;
                }

                int checksum = 0;

                for (int i = 0; i < lenght - 1; i++)
                {
                    checksum += digits[i] * weights[i];
                }

                return (checksum % 11 % 10).Equals(digits[digits.Length - 1]);
            }

        }
    }
}
