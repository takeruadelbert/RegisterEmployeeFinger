using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterEmployeeFinger.src.Class.Helper
{
    class TKHelper
    {
        private const int max_template_length = 2200;

        public string GetCurrentDatetime()
        {
            return DateTime.Now.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("id-ID")) + " " + DateTime.Now.ToString("HH:mm:ss");
        }

        public string CalculatePercentageTemplateFingerprint(int template_length)
        {
            if (template_length > 0)
            {
                double result = (template_length * 1.00 / max_template_length * 1.00) * 100;
                return Convert.ToInt32(result) + "%";
            }
            else
            {
                return "-";
            }
        }
    }
}
