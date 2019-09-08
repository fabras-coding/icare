using iCare.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCare.Application.Service
{
	public interface IUnitOfWork : IDisposable
	{
		CuidadorRepository CuidadorRepository();

		void Commit();
	}
}
