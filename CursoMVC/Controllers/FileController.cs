using CursoMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            if (TempData["Message"]!=null)
            {
                ViewBag.Message = TempData["Message"].ToString();  
            }

            return View();
        }

        public ActionResult Save(FileViewModel model)       
        {
            string RutaSitio = Server.MapPath("~/");
            string PathFile1 = Path.Combine(RutaSitio + "/Files/file1.png");
            string PathFile2 = Path.Combine(RutaSitio + "/Files/file2.png");

            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            model.File1.SaveAs(PathFile1);
            model.File2.SaveAs(PathFile2);

            @TempData["Message"] = "Se cargaron los archivos";
            return RedirectToAction("Index"); 
        }
    }
}