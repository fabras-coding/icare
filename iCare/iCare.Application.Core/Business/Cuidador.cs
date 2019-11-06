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
				var cuidadort = new CuidadorModel()
				{
					dddCuidador = cuidadorModel.dddCuidador,
					descRestricoes = cuidadorModel.descRestricoes,
					dtCadastro = DateTime.Now,
					enderecoCuidador = cuidadorModel.enderecoCuidador,
					imagemCuidador = cuidadorModel.imagemCuidador,
					nomeCuidador = cuidadorModel.nomeCuidador,
					possuiReferencia = cuidadorModel.possuiReferencia,
					telefoneCuidador = cuidadorModel.telefoneCuidador
				};

				uow.CuidadorRepository.Insert(cuidadorModel);

				if (cuidadorModel.possuiReferencia)
				{
					uow.ReferenciaCuidadorRepository.Insert(new ReferenciaCuidadorModel()
					{
						idCuidador = cuidadort.idCuidador,
						contatoReferencia = contatoRef,
						nomeReferencia = nomeRef
					});
				}
				uow.Commit();

				return cuidadort.idCuidador;


			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

	}
}
