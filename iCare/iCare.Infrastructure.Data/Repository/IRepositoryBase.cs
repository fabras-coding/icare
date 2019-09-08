using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace iCare.Infrastructure.Data.Repository
{
	public interface IRepositoryBase<T> where T : class
	{

		IQueryable<T> GetAll();

		IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

		T GetById(int id);

		void Insert(T obj);

		void Update(T obj);

		void Delete(int id);



	}
}
