using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iCare.Presentation.MVC.Models
{
	public class CuidadorViewModel
	{
		public int idCuidador { get; set; }

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

		public HttpPostedFileBase arquivo { get; set; }

		public byte[] imagemCuidador { get; set; }

		public virtual ReferenciaViewModel Referencia { get; set; }


		public string nomeReferencia { get; set; }
		public string contatoReferencia { get; set; }

	}
}