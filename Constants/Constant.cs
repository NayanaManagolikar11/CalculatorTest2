using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorTest2.Constants
{
    public static class Constant
    {
        public static string RestUrl
        {
            get
            {
                var defaultUrl = "https://localhost:44374/api/";
                return defaultUrl;
            }
        }
    }
}