using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore.App.Misc
{
    public class BooleanDropDownListOption
    {
        public bool Value { get; set; }
        public string Display { get; set; }

        public BooleanDropDownListOption(bool value, string display) 
        { 
            Value = value;
            Display = display;
        }
    }
}