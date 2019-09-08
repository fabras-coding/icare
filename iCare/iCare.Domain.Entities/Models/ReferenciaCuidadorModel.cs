using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCare.Domain.Entities.Models
{
	[Table("TB_REFERENCIA_CUIDADOR")]
	public class ReferenciaCuidadorModel
	{
		[Key]
		[Column("ID_REFERENCIA")]
		public int idReferencia{ get; set; }

		[Column("NM_REFERENCIA")]
		public string nomeReferencia{ get; set; }

		[Column("NM_CONTATO_REFERENCIA")]
		public string contatoReferencia{ get; set; }

		[Column("ID_CUIDADOR")]
		public int idCuidador{ get; set; }

		[ForeignKey("idCuidador")]
		public virtual CuidadorModel cuidador { get; set; }

	}
}
