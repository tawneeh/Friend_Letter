using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")] // these are route decorators (lesson 12)
    public string Hello() { return "Hello friend!"; } // these methods represent routes

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")] // rooth path or home page. always needed
    public ActionResult Letter() { return View(); } // this method must be named 'Letter()' for the View() method to find the correct content to show - Letter.cshtml 

  }
}