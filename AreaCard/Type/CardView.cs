using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AreaCard.Type
{
    public class CardView : IComparable<CardView>
    {
        [Display(Name = "Номер участка")]
        public string Number { get; set; }
        [Display(Name = "Дата последней обработки")]
        public DateTime? LastDate { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Дата выдачи")]
        public DateTime? Out { get; set; }
        [Display(Name = "Дата сдачи")]
        public DateTime? In { get; set; }

        public int CompareTo(CardView other)
        {
            var regCheckNumber = new Regex(@"^\d$");
            var regNumber = new Regex(@"[\d]");
            var regSymbol = new Regex(@"[\D]");

            int first;
            int second;

            if (regCheckNumber.IsMatch(Number) && regCheckNumber.IsMatch(other.Number))
            {
                int.TryParse(Number, out first);
                int.TryParse(other.Number, out second);

            }
            else
            {
                if (Convert.ToInt32(regSymbol.Replace(Number, "")) ==
                    Convert.ToInt32(regSymbol.Replace(other.Number, "")))
                {
                    return
                        regNumber.Replace(Number, "").CompareTo(regNumber.Replace(other.Number, ""));
                }
                else
                {
                    int.TryParse(regSymbol.Replace(Number, ""), out first);
                    int.TryParse(regSymbol.Replace(other.Number, ""), out second);
                }
            }

            return first.CompareTo(second);
        }
    }
}
