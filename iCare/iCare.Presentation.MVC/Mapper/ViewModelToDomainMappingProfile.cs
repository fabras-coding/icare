using AutoMapper;
using iCare.Domain.Entities.Models;
using iCare.Presentation.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iCare.Presentation.MVC.Mapper
{
	public class ViewModelToDomainMappingProfile : Profile
	{
		protected override void Configure()
        {
			AutoMapper.Mapper.CreateMap<CuidadorViewModel ,CuidadorModel>();
		}
	}
}