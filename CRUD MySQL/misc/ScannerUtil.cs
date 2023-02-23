using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CRUD_MySQL.misc
{
    public static class ScannerUtil
    {

        static public string validateLettersOnly(string input)
        {
            string pattern = @"\d|\W";

            Regex miRegex = new Regex(pattern);

            MatchCollection matches = miRegex.Matches(input);

            if(matches.Count > 0 )
            {
                return "";
            }
            else
            {
                return input;
            }


        } 

    }
}
