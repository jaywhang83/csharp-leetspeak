using Nancy;
using System.Collections.Generic;

namespace LeetSpeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["input_form.cshtml"];
      Post["/results"] = _ => {
        string userInput = Request.Form["sentence"];
        LeetSpeakTranslator newTranslator = new LeetSpeakTranslator();
        string result = newTranslator.Translate(userInput);
        return View["results.cshtml", result];
      };
    }

  }
}
