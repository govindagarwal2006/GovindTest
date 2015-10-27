using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppliaction
{
    public class ApplicationCodeClass
    {
        public string combineArrayStringWithSpace(string[] stringArray)
        {
            string str = default(string);

            foreach (string item in stringArray)
            {
                str += item + " ";
            }

            return str.Trim();
        }

    }
}
