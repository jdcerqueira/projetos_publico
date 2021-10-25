using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financeiro
{
    public class Fonte
    {
        [Required (ErrorMessage = "O campo nome é obrigatório.")]
        [StringLength (maximumLength:30, ErrorMessage = "O campo nome só aceita 30 caracteres.")]
        public String nome { get; set; }

        [Required(ErrorMessage = "O campo tipo é obrigatório.")]
        [StringLength(maximumLength: 20, ErrorMessage = "O campo tipo só aceita 20 caracteres.")]
        public String tipo { get; set; }

        [StringLength(maximumLength: 2, MinimumLength = 2, ErrorMessage = "O campo dia fechamento só aceita 2 caracter.")]
        public String diaFechamento { get; set; }

        [StringLength(maximumLength: 2, MinimumLength = 2, ErrorMessage = "O campo dia fechamento só aceita 2 caracter.")]
        public String diaFatura { get; set; }

        public Fonte fonteDestino { get; set; }

        public void ValidaClasse()
        {
            ValidationContext validationContext = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            Boolean validate = Validator.TryValidateObject(this, validationContext, validationResults,true);
            if (!validate)
            {
                StringBuilder errorMessage = new StringBuilder();
                foreach (ValidationResult validationResult in validationResults)
                    errorMessage.AppendLine(validationResult.ErrorMessage);

                throw new ValidationException(errorMessage.ToString());
            }
        }

        public static List<Fonte> fontes()
        {
            if (!File.Exists(Util.Constantes.arquivoFontes))
                return null;

            return JsonConvert.DeserializeObject<List<Fonte>>(File.ReadAllText(@"Fontes\Cadastro.json"));
        }

        public static List<Fonte> fontes(Boolean FonteComDestino)
        {
            if (!File.Exists(Util.Constantes.arquivoFontes))
                return null;

            return JsonConvert.DeserializeObject<List<Fonte>>(File.ReadAllText(@"Fontes\Cadastro.json")).FindAll(x=>x.fonteDestino != null);
        }

        public static void gravaFonte(Fonte fonte)
        {
            try
            {
                if (!Directory.Exists(Util.Constantes.diretorioFontes))
                    Directory.CreateDirectory(Util.Constantes.diretorioFontes);

                List<Fonte> fontes = Fonte.fontes();
                if (fontes == null)
                    fontes = new List<Fonte>();

                fontes.Add(fonte);

                File.WriteAllText(Util.Constantes.arquivoFontes, JsonConvert.SerializeObject(fontes, Formatting.Indented));
            }catch(ValidationException ex)
            {
                throw new Exception(ex.Message);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Fonte getFonteNome(String _nome)
        {
            List<Fonte> fontes = Fonte.fontes();
            if (fontes == null)
                return null;

            Fonte retorno = fontes.Find(x => x.nome == _nome);
            return retorno;            
        }
        override
        public String ToString()
        {
            return this.nome;
        }
    }
}
