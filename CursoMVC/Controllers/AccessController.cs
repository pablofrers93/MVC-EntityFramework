using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CursoMVC.Models;

namespace CursoMVC.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string password)
        {
            try
            {
                using(cursomvcEntities db = new cursomvcEntities())
                {
                    var lst = from d in db.user
                              where d.email == user && d.password == password && d.idState==1
                              select d;
                    if (lst.Count()>0)
                    {
                        user oUSer = lst.First();
                        Session["User"] = oUSer;
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario invalido");
                    }
                }
            }
            catch (Exception ex)
            {

                return Content("Ocurrió un error "+ex.Message);
            }
        }

    }
}