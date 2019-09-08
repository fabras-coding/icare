using iCare.Domain.Entities.Models;
using iCare.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCare.Application.Core.Business
{
	public class Cuidador
	{

		public int NovoCuidador(CuidadorModel cuidadorModel, IUnitOfWork uow)
		{

			try
			{

				uow.CuidadorRepository.Insert(cuidadorModel);
				uow.Commit();
				return cuidadorModel.idCuidador; ;


			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

	}
}
