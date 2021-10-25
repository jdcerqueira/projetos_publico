using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_devops
{
    class ItemMenuDinamico
	{
        public int? codigo { get; set; }
		public String nome { get; set; }
		public String descricao { get; set; }
		public String url { get; set; }
		public int? nivel { get; set; }
		public String ordem { get; set; }
		public int? coluna { get; set; }
		public String tipoPermissao { get; set; }
		public int? flagFiltro { get; set; }
		public String car { get; set; }
		public int? flagExclusividade { get; set; }
		public List<ItemMenuDinamico> MenuDinamico { get; set; }

		override
		public String ToString()
		{
			return this.codigo + " - " + this.ordem.Trim() + " - " + this.car + " - " + this.nome;
		}
	}
}
