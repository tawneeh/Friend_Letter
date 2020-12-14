using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")] // these are route decorators (lesson 12)
    public string Hello() { return "Hello friend!"; } // these methods represent routes

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender) // these link to the inputs named in Postcard.cshtml - name="sender" and name="recipient" 
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }

    [Route("/")] // root path or home page. always needed
    public ActionResult Letter() // this method must be named 'Letter()' for the View() method to find the correct content to show - Letter.cshtml. same for Postcard() and Form() etc. 
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Emma";
      myLetterVariable.Sender = "Tawnee";
      return View(myLetterVariable);
    }
  }
}