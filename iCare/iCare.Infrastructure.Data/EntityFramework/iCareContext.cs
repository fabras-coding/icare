using iCare.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCare.Infrastructure.Data.EntityFramework
{
	public class iCareContext : DbContext
	{

		public iCareContext() : base ("iCareConnection")
		{

		}

		public DbSet<CuidadorModel> Cuidador { get; set; }
		public DbSet<ReferenciaCuidadorModel> ReferenciaCuidador{ get; set; }

	}
}
