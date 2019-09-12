using iCare.Domain.Entities.Models;
using iCare.Infrastructure.Data;
using iCare.Presentation.MVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace iCare.Presentation.MVC.Controllers
{
    public class CuidadorController : Controller
    {

		IUnitOfWork _uow;
		private Application.Core.Business.Cuidador cuidadorBussines;

		public object Alert { get; private set; }

		public CuidadorController(IUnitOfWork uow)
		{
			this.cuidadorBussines = new Application.Core.Business.Cuidador();
			this._uow = uow;
		}
	

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult NovoCuidador(CuidadorViewModel cuidador)
		{

			if (Request.Files.Count > 0)
			{
				var ms = new MemoryStream();
				Request.Files[0].InputStream.CopyTo(ms);

				cuidador.imagemCuidador = ms.ToArray();
			}

			int idCuidador = cuidadorBussines.NovoCuidador(AutoMapper.Mapper.Map<CuidadorViewModel, CuidadorModel>(cuidador), _uow);


			return RedirectToAction("Index",  "Home", null);
		}

    }
}