using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Anagrams.Models;

namespace Anagrams.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("msg", "");
      return View("Index", model);
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      string msg = "";
      int qx = Int32.Parse(Request.Form["qx"]);
      int qy = Int32.Parse(Request.Form["qy"]);
      int vx = Int32.Parse(Request.Form["vx"]);
      int vy = Int32.Parse(Request.Form["vy"]);
      if (qx < 1 || qx > 8 || qy < 1 || qy > 8)
      {
        msg = "Queen cannot be at those Coordinates";
      }
      else if(vx < 1 || vx > 8 || vy < 1 || vy > 8)
      {
        msg = "Victim cannot be at those Coordinates";
      }
      else if(qx == vx && qy == vy)
      {
        msg = "Queen and Victim cannot share Coordinates";
      }
      else
      {
        Queen queen = new Queen(qx, qy);
        if (queen.CanAttack(vx, vy))
        {
          msg = "Queen Takes Piece!!!";
        }
        else
        {
          msg = "Queen cannot attack piece :(";
        }
      }
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("msg", msg);
      model.Add("qx", qx);
      model.Add("qy", qy);
      model.Add("vx", vx);
      model.Add("vy", vy);


      return View("Index", model);
    }
  }
}
