using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {
        public static bool CheckVIN(string vin)
        {
            Regex regex = new Regex("^[ABCDEFGHJKLMNPRSTUVWXYZ|0-9]{17}$");
            bool a = regex.IsMatch(vin);
            if (!a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string GetVINCountry(string vin)
        {
            if (vin[0] == 'A' || vin[1] == 'H' || vin[0] == 'H' || vin[1] == 'A')
            {
                return "Кения";
            }
            else if (vin[0] == 'J' || vin[1] == 'R' || vin[1] == 'J' || vin[0] == 'R')
            {
                return "Ази";
            }
            else if (vin[0] == 'S' || vin[1] == 'Z' || vin[1] == 'S' || vin[0] == 'Z')
            {
                return "Европа";
            }
            else if (vin[0] == '1' || vin[1] == '5' || vin[0] == '5' || vin[1] == '1')
            {
                return "Северная Америка";
            }
            else if (vin[0] == '6' || vin[1] == '7' || vin[0] == '7' || vin[1] == '6')
            {
                return "Океания";
            }
            else if (vin[0] == '8' || vin[1] == '9' || vin[0] == '9' || vin[1] == '8')
            {
                return "Южная Америка";
            }
            else
            {
                return "";
            }
        }
    }

}
