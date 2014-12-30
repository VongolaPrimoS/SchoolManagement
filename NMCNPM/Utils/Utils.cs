using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NMCNPM
{
    class Utils
    {
        // validate phone number
        public Boolean validate_PhoneNumberInput(string phone_number)
        {
            Regex regex = new Regex(@"\d{9,11}");
            Match match = regex.Match(phone_number);
            Boolean isMatch = false;
            if (match.Success)
            {
                // be sure that matched value must be equal to input value
                // remove 123123123aaaaa123
                if (match.Value == phone_number)
                {
                    isMatch = true;
                }
            }
            return isMatch;
        }

        public string generatePrimaryKey(string prefix,int rows)
        {
            int temp = rows;
            int count = 0;

            if (rows > 9999)
            {
                return "-1";
            }

            // get length of number
            while (temp > 0)
            {
                count++;
                temp /= 10;
            }
            //padding zero
            for (int i = 0; i < (4 - count); i++)
            {
                prefix += "0";
            }
            prefix += rows.ToString();
            return prefix;
        }
    }
}
