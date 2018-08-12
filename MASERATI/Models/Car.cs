using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MASERATI.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name ="Название")]
        public string model { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Описание")]
        public string description { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Цена")]
        public int price { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Тип машины")]
        public string type { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Путь картинки")]
        public string pathlog { get; set; }

        public List<FotoCar> foto { get; set; }
    }
}