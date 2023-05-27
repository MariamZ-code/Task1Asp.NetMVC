using Microsoft.AspNetCore.Mvc;
using Task1Asp.NetMVC.Models;

namespace Task1Asp.NetMVC.Controllers
{
    public class PartyController : Controller
    {
        ITICotext db;
        public PartyController()
        {
            db = new ITICotext();
        }
        public IActionResult PartyPage()
        {
            return View("Home");
        }
        public IActionResult GuestForm()
        {
            return View("GuestForm");
        }

        //Party/GuestForm
        public IActionResult addData(Guest _guest, string _attend)
        {

            if (_attend == "attend")
            {
                _guest.Attend = true;
            }
            db.Add(_guest);
            db.SaveChanges();

            if (_guest.Attend)
            {
                return RedirectToAction("Thanks");
            }
            else
            {
                return RedirectToAction("PartyPage");

            }
        }


        public IActionResult GuestList()
        {

            List<Guest> guests= db.guests.ToList();
            return View("GuestList", guests);

        }

        public IActionResult Thanks()
        {
            return View("Thanks");

        }

        public IActionResult GuestMsg()
        {
            List<Guest> guests = db.guests.ToList();
           
            return View("Message", guests);
        }
    }
}
