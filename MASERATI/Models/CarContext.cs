using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MASERATI.Models
{
    public class CarContext: DbContext 
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<FotoCar> fotoCars { get; set; }
    }
}