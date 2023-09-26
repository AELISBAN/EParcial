using Microsoft.AspNetCore.Mvc;

namespace mimvc.Controllers;

 

public class DemoController : Controller

{

 

     public IActionResult Index()

    {

        ViewBag.Mesage="Hola ELISBAN";

        return View();

    }

}