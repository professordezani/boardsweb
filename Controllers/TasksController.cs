using Microsoft.AspNetCore.Mvc;

public class TasksController: Controller
{
    public ActionResult Index(int id)
    {
        return View();
    }
    public ActionResult Create(int id)
    {
        return View();
    }
}