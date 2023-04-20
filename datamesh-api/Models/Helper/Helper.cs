using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datamesh.Models.Helpers
{
    public class Helper
    {
        public static string CapitalizeFirstChar(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            return $"{input[0].ToString().ToUpper()}{input.Substring(1)}";
        }
    }
}
