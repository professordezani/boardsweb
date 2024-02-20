using Microsoft.AspNetCore.Mvc;

public class BoardController: Controller
{
    public ActionResult Index(int id)
    {
        return View();
    }

    public ActionResult Create()
    {
        return View();
    }
}