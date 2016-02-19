using Nancy;
using System.Collections.Generic;

namespace RepeatCounterNameSpace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
     {
       return View ["inputpage.cshtml"];
     };

     Post["/results"] = _ =>
     {
       string target = Request.Form["target"];
       string search = Request.Form["search"];
       RepeatCounter newRepeatCounter = new RepeatCounter(search, target);
       return View ["outputpage.cshtml", newRepeatCounter.CountRepeats()];
     };

    }
  }
}
