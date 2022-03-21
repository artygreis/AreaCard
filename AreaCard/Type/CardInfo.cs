using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCard.Type
{
    public class CardInfo
    {
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Дата выдачи")]
        public DateTime? Out { get; set; }
        [Display(Name = "Дата сдачи")]
        public DateTime? In { get; set; }
    }
}
