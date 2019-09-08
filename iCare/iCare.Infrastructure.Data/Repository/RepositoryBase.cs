using iCare.Infrastructure.Data.EntityFramework;
using iCare.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCare.Infrastructure.Data.Repository
{
	public class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{
		private iCareContext _context = null;

		public RepositoryBase(iCareContext ctx)
		{
			_context = ctx;
		}

		public void Delete(int id)
		{
			T existing = _context.Set<T>().Find(id);
		}

		public IQueryable<T> GetAll()
		{
			IQueryable<T> query = _context.Set<T>().AsQueryable();
			return query;
		}

		public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
		{
			IQueryable<T> query = _context.Set<T>().Where(predicate);
			return query;
		}

		public T GetById(int id)
		{
			return _context.Set<T>().Find(id);
		}

		public void Insert(T obj)
		{
			_context.Set<T>().Add(obj);
		}

		

		public void Update(T obj)
		{
			_context.Entry(obj).State = EntityState.Modified;
		}
	}
}
