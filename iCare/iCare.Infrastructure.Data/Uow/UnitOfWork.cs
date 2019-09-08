using iCare.Domain.Entities.Models;
using iCare.Infrastructure.Data.EntityFramework;
using iCare.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCare.Infrastructure.Data.Uow
{
	public class UnitOfWork : IDisposable, IUnitOfWork
	{
		private iCareContext context;
		//private RepositoryBase<CuidadorModel> cuidadorRepository;
		//private RepositoryBase<ReferenciaCuidadorModel> referenciaRepository;


		public UnitOfWork()
		{
			context = new iCareContext();

		}

		//public RepositoryBase<CuidadorModel> CuidadorRepository { get { return cuidadorRepository = cuidadorRepository ?? new RepositoryBase<CuidadorModel>(context); } }
		//public RepositoryBase<ReferenciaCuidadorModel> ReferenciaRepository { get { return referenciaRepository = referenciaRepository ?? new RepositoryBase<ReferenciaCuidadorModel>(context); } }

		public IRepositoryBase<CuidadorModel> CuidadorRepository {get{ return new CuidadorRepository(context) ;}}
		public IRepositoryBase<ReferenciaCuidadorModel> ReferenciaCuidadorRepository { get { return new ReferenciaRepository(context); } }


		public void Commit()
		{
			context.SaveChanges();
		}
		private bool disposed = false;

		

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					context.Dispose();
				}
			}
			this.disposed = true;
		}


		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

	}
}
