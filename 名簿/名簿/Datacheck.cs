using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
#pragma execution_character_set("utf-8")


namespace 名簿
{
    public class Datacheck
    {
        public string Classcheck(string classtex)
        {
            if (classtex.Length == 2)
            {
                if (Int32.TryParse(classtex, out int classnumber))
                {
                    return classtex;
                }
            }

            else if (classtex.Length == 3)
            {
                if (char.IsNumber(classtex, 0) && char.IsNumber(classtex, 1))
                {
                    if (classtex.Contains("番"))
                    {
                        string classnum = classtex.Substring(0, 2);
                        return classnum;
                    }
                }
            }

            return "";
        }

        public string fnamecheck(string fnametex)
        {
            //if (!Int32.TryParse(fnametex, out int fnamenumber))
            if(Regex.IsMatch(fnametex, "[^!#\$%&'\(\)\*+-.,/:;<=>?@[\]^_`{|}~]+") == true)
            {
                return fnametex;
            }

            return "";
        }

        public string namecheck(string nametex)
        {
            if (!Int32.TryParse(nametex, out int namenumber))
            {
                return nametex;
            }

            return "";
        }

        public string yearcheck(string yeartex)
        {
            if (yeartex.Length == 4)
            {
                if (Int32.TryParse(yeartex, out int yearnumber))
                {
                    return yeartex;
                }
            }
            return null;
        }

        public string monthcheck(string monthtex)
        {
            if (monthtex.Length == 2)
            {
                if (Int32.TryParse(monthtex, out int monthnumber))
                {
                    return monthtex;
                }
            }
            return "";
        }

        public string daycheck(string daytex)
        {
            if (daytex.Length == 2)
            {
                if (Int32.TryParse(daytex, out int daynumber))
                {
                    return daytex;
                }
            }
            return "";
        }

        public string birthdaycheck(string birthtex)
        {
            if (birthtex.Length == 8)
            {
                if (Int32.TryParse(birthtex, out int birthdaynumber))
                {
                    return birthtex;
                }
            }
            return "";
        }

        public string gendercheck(string gendertex)
        {
            if(gendertex != null)
            {
                return gendertex;
            }

            return "";
        }
    }
}