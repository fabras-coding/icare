using iCare.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iCare.Infrastructure.Data.EntityFramework;

namespace iCare.Infrastructure.Data.Repository
{
	public class ReferenciaRepository : RepositoryBase<ReferenciaCuidadorModel>
	{
		public ReferenciaRepository(iCareContext ctx) : base(ctx)
		{
		}
	}
}
