using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AreaCard.Type
{
    public class Card
    {
        [Display(Name = "Номер участка")]
        public string Number { get; set; }
        [Display(Name = "Дата последней обработки")]
        public DateTime? LastDate { get; set; }
        public List<CardInfo> CardInfos { get; set; }
    }
}
