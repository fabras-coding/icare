using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iCare.Presentation.MVC.Models
{
	public class CuidadorViewModel
	{

		[Required]
		[Display(Name = "Nome Cuidador")]
		public string nomeCuidador { get; set; }


		[Required]
		[Display(Name = "Endereço")]
		public string enderecoCuidador { get; set; }

		[Required]
		[Display(Name = "DDD")]
		public int dddCuidador { get; set; }

		[Required]
		[Display(Name = "Telefone")]
		public string telefoneCuidador { get; set; }

		[Required]
		[Display(Name = "Possui referência?")]
		public System.Boolean possuiReferencia { get; set; }

		[Required]
		[Display(Name = "Restrições")]
		public string descRestricoes { get; set; }
	}
}