using iCare.Domain.Entities.Models;
using iCare.Infrastructure.Data;
using iCare.Infrastructure.Data.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCare.Application.Core.Business
{
	public class Cuidador
	{

		public int NovoCuidador(CuidadorModel cuidadorModel, string nomeRef, string contatoRef, UnitOfWork uow)
		{

			try
			{

				uow.CuidadorRepository.Insert(cuidadorModel);
				uow.ReferenciaCuidadorRepository.Insert(new ReferenciaCuidadorModel()
				{
					idCuidador = cuidadorModel.idCuidador,
					contatoReferencia = contatoRef,
					nomeReferencia = nomeRef
				});
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
