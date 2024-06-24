using Lab1.Models;
using Lab1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class SportsController : Controller
    {
        // GET: Sports

        [Route("sp/pl")]
        public ActionResult Player()
        {

            List<Player> playerlist = new List<Player>
            {

                new Player {Id=1, Name="Siam", Salary =100000},
                new Player {Id=2, Name="Farhan", Salary =100000},
                new Player {Id=3, Name="Sadik", Salary =100000}
            };
            return View(playerlist);
        }

        public ActionResult Staff()
        {
            List<Staff> stafflist = new List<Staff>
            {

                new Staff {Id=1, Name="Siam", Position ="Groundsman"},
                new Staff {Id=2, Name="Farhan", Position ="Net Bowler"},
                new Staff {Id=3, Name="Sadik", Position ="Security Guard"}
            };
            ViewBag.Staff = stafflist;
            return View();
        }

        public ActionResult Stadium()
        {

            List<Stadium> stadiumlist = new List<Stadium>
            {

                new Stadium {Location="Mirpur, Dhaka", Capacity=25000},
                new Stadium {Location="Chatt, Bangladesh", Capacity=25000},
                new Stadium {Location="Shylet, Bangladesh", Capacity=25000}
            };
            ViewBag.Stadium = stadiumlist;
            return View();
        }

    }
}