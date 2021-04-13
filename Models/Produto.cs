using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaginacaoBasica.Models
{
	[Table("Produtos")]
	public class Produto
	{
		public int Id { get; set; }

		public string Nome { get; set; }

		[Display(Name = "Preço")]
		[DisplayFormat(DataFormatString = "{0:C}")]
		public decimal Preco { get; set; }
	}
}
