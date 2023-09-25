using Microsoft.AspNetCore.Mvc;

namespace HotelWebApp
{
    public class BookingController : Controller
    {
        public IActionResult BookingsList()
        {
            return View("Bookings");
        }
    }
}
