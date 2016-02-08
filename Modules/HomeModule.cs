using Nancy;
using Letter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/greeting_card"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables
        {
          Sender = Request.Query["sender"],
          Recipient = Request.Query["recipient"]
        };
        return View["hello.html",  myLetterVariables];
      };

      Get["/form"] = _ => {
        return View["forms.html"];
      };


    }
  }
}
