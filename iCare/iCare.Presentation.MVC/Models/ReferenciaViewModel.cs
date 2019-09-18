using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace iCare.Presentation.MVC.Models
{
	public class ReferenciaViewModel
	{

		[Display(Name = "Nome Referência")]
		public string nomeReferencia { get; set; }

		[Display(Name = "Contato Referência")]
		public string contatoReferencia { get; set; }
	}
}