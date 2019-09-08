using iCare.Domain.Entities.Models;
using iCare.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCare.Infrastructure.Data
{
	public interface IUnitOfWork : IDisposable
	{
		IRepositoryBase<CuidadorModel> CuidadorRepository { get; }
		IRepositoryBase<ReferenciaCuidadorModel> ReferenciaCuidadorRepository { get; }

		void Commit();
	}
}
