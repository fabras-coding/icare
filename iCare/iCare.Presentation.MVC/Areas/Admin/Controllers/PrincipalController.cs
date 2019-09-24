using iCare.Domain.Entities.Models;
using iCare.Infrastructure.Data.Uow;
using iCare.Presentation.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace iCare.Presentation.MVC.Areas.Admin.Controllers
{
	[Authorize(Roles = "Admin")]
    public class PrincipalController : Controller
    {
		private UnitOfWork uow;
		public PrincipalController()
		{
			uow = new UnitOfWork();
		}
        // GET: Admin/Principal
        public ActionResult ListarCuidadores()
        {

			var cuidadores = AutoMapper.Mapper.Map<List<CuidadorModel>, List<CuidadorViewModel>>(uow.CuidadorRepository.GetAll().ToList());

			cuidadores.ForEach(x => {
				x.Referencia = AutoMapper.Mapper.Map<ReferenciaCuidadorModel, ReferenciaViewModel>(uow.ReferenciaCuidadorRepository.FindBy(c => c.idCuidador == x.idCuidador).FirstOrDefault());
			});
            return View(cuidadores);
        }
    }
}