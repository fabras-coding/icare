using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iCare.Infrastructure.Data.Uow;
using System.Linq;
using iCare.Presentation.MVC;
using iCare.Infrastructure.Data;

namespace iCare.Tests
{
	[TestClass]
	public class UnitTest1
	{


		[TestMethod]
		public void GetCuidadores()
		{

			var uow = new UnitOfWork();

			var cuidadores = uow.CuidadorRepository.GetAll().ToList();

			Assert.IsNotNull(cuidadores);
		}
	}
}
