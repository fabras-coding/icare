using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCare.Domain.Entities.Models
{
	[Table("TB_CUIDADOR")]
	public class CuidadorModel
	{
		[Key]
		[Column("ID_CUIDADOR")]
		public int idCuidador{ get; set; }

		[Column("NM_CUIDADOR")]
		public string nomeCuidador{ get; set; }

		[Column("NM_ENDERECO")]
		public string enderecoCuidador{ get; set; }

		[Column("NU_DDD")]
		public int dddCuidador { get; set; }

		[Column("NM_TELEFONE")]
		public string telefoneCuidador{ get; set; }

		[Column("FL_REFERENCIA")]
		public System.Boolean possuiReferencia{ get; set; }

		[Column("DS_RESTRICOES")]
		public string descRestricoes{ get; set; }

		[Column("IMAGEM_CUIDADOR")]
		public byte[] imagemCuidador { get; set; }

		[Column("DT_CADASTRO")]
		public DateTime? dtCadastro{ get; set; }

		//[ForeignKey("idCuidador")]
		//public virtual ReferenciaCuidadorModel Referencia { get; set; }

		//public virtual ReferenciaCuidadorModel Referencia { get; set; }
	}
}
