using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MASERATI.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Имя")]
        public string name { get; set; }

        [RegularExpression(@"^\+38[0-9]{10}$", ErrorMessage = "Не верный формат номера")]
        [Display(Name = "Телефон")]
        public string phone { get; set; }

        public int CarId { get; set; }

        public Car car { get; set; }
    }
}