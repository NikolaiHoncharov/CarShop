using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MASERATI.Models
{
    public class FotoCar
    {
        [Key]
        public int FotoCarId { get; set; }

        [Required(ErrorMessage ="Поле должно быть установлено")]
        [Display(Name ="Путь картинки")]
        public string path { get; set; }


        [Required(ErrorMessage = "Поле должно быть установлено")]
        public int CarId { get; set; }

        public Car car { get; set; }
    }
}