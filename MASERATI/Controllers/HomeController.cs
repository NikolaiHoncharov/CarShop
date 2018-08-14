using MASERATI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MASERATI.Controllers
{
    public class HomeController : Controller
    {
        CarContext db = new CarContext();

        [OutputCache(Duration = 60)]
        public ActionResult Index()
        {
            //db.Cars.Add(new Car { model = "ghibli", price = 950, type = "бизнес класс", description = " maserati ghibi iii - седан бизнес-класса итальянской компании masserati, которая поступила в проджу во второй половине 2013", pathlog = "/images/ghibli.jpg" });
            //db.Cars.Add(new Car { model = "quattroporte", price = 595, type = "представительский класс", description = " maserati quattroporte - спортивный полноразмерный седан класса люкс, которые изготовляются итальянской компанией masserati с 1963", pathlog = "/images/quatro.jpg" });
            //db.Cars.Add(new Car { model = "granturismo", price = 620, type = "купе", description = "maserati granturismo - автомобиль класса гран туризмо от итальянского производителя maserati. общественности был представлен в марте 2007 года на женевском автомалоне.", pathlog = "/images/grand.jpg" });
            //db.SaveChanges();

            return View(db.Cars.ToList());
        }

        [HttpPost]
        public string Index(string name, string phone, int Car)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(new Order { name = name, phone = phone, CarId = Car });
                db.SaveChanges();
                return $"Добрый день, {name}, ваш заказ принят в ближайшее время вам позвонят по указанному номеру {phone}!";
            }
            else
                return $"Ошибка ввода";
        }

       
        [OutputCache(Duration = 60)]
        public async Task<ActionResult> Cars(int id=1)
        {
            ViewBag.Car =  (from f in db.Cars
                             where f.CarId == id
                             select f.model).FirstOrDefault();

            return View(await (from f in db.fotoCars
                         where f.CarId == id
                         select f).ToListAsync());
        }

        //Partial Views

        [ChildActionOnly]
        public ActionResult CarForm()
        {
            return PartialView();
        }
    }
}