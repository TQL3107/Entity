using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.B_BUS.Utilities
{
    internal class ValidateInputData
    {
        public static string CheckEmptyString(string s)
        {
            //return s.Trim().Length == 0;
            return String.IsNullOrEmpty(s.Trim()) ? "Bạn cần nhập thông tin" : "";
        }
        public static string CheckEmpty(string s)
        {
            int i;
            return int.TryParse(s, out i) ? "" : "Bạn cần nhập số";
        }
    }
}
