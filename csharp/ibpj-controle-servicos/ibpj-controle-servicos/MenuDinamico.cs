using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ibpj_controle_servicos
{
    public class MenuDinamico
	{
        public int codigo { get; set; }

		[Required (ErrorMessage = "Obrigatório informar o campo texto.", AllowEmptyStrings = false)]
		[StringLength(maximumLength:100, ErrorMessage = "O campo texto deve ter no máximo 100 caracteres.")]
		public String nome { get; set; }

		[Required(ErrorMessage = "Obrigatório informar o campo descrição.", AllowEmptyStrings = false)]
		[StringLength(maximumLength: 100, ErrorMessage = "O campo descrição deve ter no máximo 255 caracteres.")]
		public String descricao { get; set; }

		[StringLength(maximumLength: 255, ErrorMessage = "O campo URL deve ter no máximo 255 caracteres.")]
		public String url { get; set; }
		public int nivel { get; set; }

		[Required(ErrorMessage = "Obrigatório informar o campo ordem.", AllowEmptyStrings = false)]
		[StringLength(maximumLength: 10, MinimumLength = 2, ErrorMessage = "O campo ordem deve ter entre 2 e 10 caracteres.")]
		public String ordem { get; set; }
		public int coluna { get; set; }
		public String tipoPermissao { get; set; }
		public int? codigoPai { get; set; }
		public int indicadorFiltro { get; set; }
		public int? estilo { get; set; }
		public AcessoDireto car { get; set; }
		public int? ambiente { get; set; }
		public int? tagCampanha { get; set; }

		[Required(ErrorMessage = "Obrigatório informar o tipo de contrato.")]
		public List<int?> contratos { get; set; }
		public ServicoMenu trincaPermissao { get; set; }
		public List<FiltroMenu> filtros { get; set; }

		[Required(ErrorMessage = "Obrigatório informar o campo líder solicitante.", AllowEmptyStrings = false)]
		public String liderSolicitante { get; set; }

		/* Variáveis estáticas para auxílio na tela */

		private const String arquivoMenuDinamico = "ibpj-menu-dinamico.json";

		public const int total_colunas_datagrid = 35;

		public const int idx_codigo = 0;
		public const int idx_nivel = 1;
		public const int idx_ordem = 2;
		public const int idx_familia = 3;
		public const int idx_subfamilia = 4;
		public const int idx_subfamiliacomplementar = 5;
		public const int idx_nome = 6;
		public const int idx_descricao = 7;
		public const int idx_codigoPai = 8;
		public const int idx_tipoPermissao = 9;
		public const int idx_car = 10;
		public const int idx_car_palavra_chave = 11;
		public const int idx_car_descricao = 12;
		public const int idx_url = 13;
		public const int idx_estilo = 14;
		public const int idx_contrato_padrao = 15;
		public const int idx_contrato_consulta = 16;
		public const int idx_contrato_consulta_cobranca = 17;
		public const int idx_contrato_consulta_webta = 18;
		public const int idx_contrato_consulta_cobranca_webta = 19;
		public const int idx_contrato_investimentos = 20;
		public const int idx_contrato_ativos_escriturais = 21;
		public const int idx_contrato_ativos_escritutais_webta = 22;
		public const int idx_contrato_pessoa_fisica = 23;
		public const int idx_contrato_nao_correntista = 24;
		public const int idx_contrato_site_independente = 25;
		public const int idx_contrato_nao_correntista_sem_representatividade = 26;
		public const int idx_grupo = 27;
		public const int idx_servico = 28;
		public const int idx_operacao = 29;
		public const int idx_indicadorFiltro = 30;
		public const int idx_coluna = 31;
		public const int idx_ambiente = 32;
		public const int idx_tagCampanha = 33;
		public const int idx_lider_solicitante = 34;

		public const int nivel_paginaInicial = 1;
		public const int nivel_familia = 2;
		public const int nivel_subfamilia = 3;
		public const int nivel_subfamiliacomplementar = 4;
		public const int nivel_item_subfamiliacomplementar = 5;

		public static List<MenuDinamico> carregaArquivoJson()
        {
            try
            {
				return JsonConvert.DeserializeObject<List<MenuDinamico>>(File.ReadAllText(arquivoMenuDinamico));
			}
            catch(FileLoadException ex)
            {
				MessageBox.Show("ERR: " + ex.Message,"Erro ao carregar o arquivo de menu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch(Exception ex)
            {
				MessageBox.Show("ERR: " + ex.Message, "Erro ao carregar o arquivo de menu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}

			return null;
        }

		public void ValidaPreenchimentoClasse()
        {
			ValidationContext context = new ValidationContext(this, null, null);
			List<ValidationResult> results = new List<ValidationResult>();
			Boolean validator = Validator.TryValidateObject(this, context, results, true);
            if (!validator)
            {
				StringBuilder errorMessage = new StringBuilder();
				foreach(ValidationResult validation in results)
					errorMessage.AppendLine(validation.ErrorMessage);

				throw new ValidationException(errorMessage.ToString());
            }
        }

		public static void persisteArquivo(List<MenuDinamico> menuDinamicos)
        {
            try
            {
				File.WriteAllText(arquivoMenuDinamico, JsonConvert.SerializeObject(menuDinamicos.OrderBy(x => x.ordem), Formatting.Indented));
				MessageBox.Show("Arquivo atualizado com sucesso.", "Gravação de Arquivo (Menu Dinâmico)", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(Exception ex)
            {
				MessageBox.Show("ERR: " + ex.Message, "Gravação de Arquivo (Menu Dinâmico)", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
        }

		public static List<List<String>> retornaAtualizacaoCampos(MenuDinamico _anterior, MenuDinamico _atualizado)
        {
			List<List<String>> retorno = new List<List<String>>();

			// gera os espaços de memória para VOLTA e IDA
			retorno.Add(new List<String>());
			retorno.Add(new List<String>());

			if (_anterior.nome != _atualizado.nome)
            {
				retorno[0].Add($"iMenuDnamc = '{_anterior.nome}'");
				retorno[1].Add($"iMenuDnamc = '{_atualizado.nome}'");
			}
			if(_anterior.descricao != _atualizado.descricao)
			{
				retorno[0].Add($"rMenuDnamc = '{_anterior.descricao}'");
				retorno[1].Add($"rMenuDnamc = '{_atualizado.descricao}'");
			}
			if (_anterior.url != _atualizado.url)
			{
				retorno[0].Add($"eUrlMenuDnamc = '{_anterior.url}'");
				retorno[1].Add($"eUrlMenuDnamc = '{_atualizado.url}'");
			}
			if (_anterior.nivel != _atualizado.nivel)
			{
				retorno[0].Add($"cNvelHierqMenuDnamc = {_anterior.nivel}");
				retorno[1].Add($"cNvelHierqMenuDnamc = {_atualizado.nivel}");
			}
			if (_anterior.ordem != _atualizado.ordem)
			{
				retorno[0].Add($"cOrdSeqMenuDnamc = '{_anterior.ordem.Trim()}'");
				retorno[1].Add($"cOrdSeqMenuDnamc = '{_atualizado.ordem.Trim()}'");
			}
			if (_anterior.coluna != _atualizado.coluna)
			{
				retorno[0].Add($"cIdtfdPosicItemMenuDnamc = {_anterior.coluna}");
				retorno[1].Add($"cIdtfdPosicItemMenuDnamc = {_atualizado.coluna}");
			}
			if (_anterior.tipoPermissao != _atualizado.tipoPermissao)
			{
				retorno[0].Add($"cTpoPrmssAcsso = '{_anterior.tipoPermissao}'");
				retorno[1].Add($"cTpoPrmssAcsso = '{_atualizado.tipoPermissao}'");
			}
			if (_anterior.indicadorFiltro != _atualizado.indicadorFiltro)
			{
				retorno[0].Add($"cIndcdRestMenu = {_anterior.indicadorFiltro}");
				retorno[1].Add($"cIndcdRestMenu = {_atualizado.indicadorFiltro}");
			}
			if (_anterior.estilo != _atualizado.estilo)
			{
				retorno[0].Add($"cEstilEspecMenuDnamc = {_anterior.estilo}");
				retorno[1].Add($"cEstilEspecMenuDnamc = {_atualizado.estilo}");
			}
			//if (_anterior.car != _atualizado.car)
			//{
			//	retorno[0].Add($"eUrlMenuDnamc = '{_anterior.car}'");
			//	retorno[1].Add($"eUrlMenuDnamc = '{_atualizado.car}'");
			//}
			if (_anterior.ambiente != _atualizado.ambiente)
			{
				retorno[0].Add($"cIndcdMenuExcvd = {_anterior.ambiente}");
				retorno[1].Add($"cIndcdMenuExcvd = {_atualizado.ambiente}");
			}
			if (_anterior.tagCampanha != _atualizado.tagCampanha)
			{
				retorno[0].Add($"cIndcdMenuHabltCampa = {_anterior.tagCampanha}");
				retorno[1].Add($"cIndcdMenuHabltCampa = {_atualizado.tagCampanha}");
			}
			//if (_anterior.contratos != _atualizado.contratos)
			//{
			//	retorno[0].Add($"eUrlMenuDnamc = '{_anterior.url}'");
			//	retorno[1].Add($"eUrlMenuDnamc = '{_atualizado.url}'");
			//}
			//if (_anterior.trincaPermissao != _atualizado.trincaPermissao)
			//{
			//	retorno[0].Add($"eUrlMenuDnamc = '{_anterior.url}'");
			//	retorno[1].Add($"eUrlMenuDnamc = '{_atualizado.url}'");
			//}
			//if (_anterior.filtros != _atualizado.filtros)
			//{
			//	retorno[0].Add($"eUrlMenuDnamc = '{_anterior.url}'");
			//	retorno[1].Add($"eUrlMenuDnamc = '{_atualizado.url}'");
			//}

			return retorno;
        }

		public class Familia
        {
			public int codigo { get; }
			public String nome { get; }
			public String dsApresentaCombo { get; }

			public Familia(int _codigo, String _nome)
            {
				this.codigo = _codigo;
				this.nome = _nome;
				this.dsApresentaCombo = (_codigo == 0 ? "" : _codigo + " - ") + _nome;
            }

			public static List<Familia> familias(List<MenuDinamico> menus)
            {
				List<Familia> familias = new List<Familia>();

				familias.Add(new Familia(0,Util.TodosItens));
				foreach (MenuDinamico menu in menus.FindAll(x => x.nivel == 2).OrderBy(x => x.ordem).ToList())
					familias.Add(new Familia(menu.codigo, menu.nome));

				return familias;
            }
        }
	}
}
