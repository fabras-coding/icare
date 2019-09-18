using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace iCare.Presentation.MVC.Areas.Admin.Controllers
{
    public class PrincipalController : Controller
    {
		//private UnitOfWork uow;
		public PrincipalController()
		{
			//uow = new UnitOfWork();
		}
        // GET: Admin/Principal
        public ActionResult ListarCuidadores()
        {
            return View();
        }
    }
}