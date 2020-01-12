using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ProgressBar.Controllers
{
    public class TesteProgressBarController : Controller
    {
        // GET: TesteProgressBar
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetProgress(string id)
        {
            return Json(new
            {
                success = true,
                done = false,
                percent = DateTime.Now.Second * 100 / 60
            }) ;
        }
    }



    /*
     * https://stackoverflow.com/questions/24857346/mvc-progress-bar-wont-work-correctly
     * https://getbootstrap.com/docs/4.4/components/progress/
     * fazer com multiplas barras para mostrar o sucesso/falha
     */




}