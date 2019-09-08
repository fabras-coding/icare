using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace iCare.Presentation.MVC.Mapper
{
	public class AutoMapperConfig
	{
		public static void RegisterMappings()
		{
			AutoMapper.Mapper.Initialize(x =>
			{
				x.AddProfile<DomainToViewModelMappingProfile>();
				x.AddProfile<ViewModelToDomainMappingProfile>();

			});
		}
	}
}