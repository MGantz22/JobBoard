using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobsController : Controller
  {

    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Jobs> allJobs = Jobs.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobs/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string description)
    {
    Jobs newJob = new Jobs(description);
      return RedirectToAction("Index");
    }

  }
}