using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace db_devops
{
    class ManutencaoMenuDinamico
    {

        List<ItemMenuDinamico> itemMenuJson = JsonConvert.DeserializeObject<List<ItemMenuDinamico>>(File.ReadAllText("MenuTeste.json"));

        public void limparTela()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cls";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
        }

        public void exibirItensMenuDinamico(ItemMenuDinamico itemMenu)
        {
            Console.WriteLine("");
            Console.WriteLine("************************** " + itemMenu.nome + " **************************");
            ItemMenuDinamico[] menus = new ItemMenuDinamico[itemMenu.MenuDinamico.Count];
            int ivc = 0;
            foreach (ItemMenuDinamico menu in itemMenu.MenuDinamico)
            {
                menus[ivc] = menu;
                ivc++;
            }


            for (int indexOfArray = 0; indexOfArray < menus.Length; indexOfArray++)
            {
                if (indexOfArray % 3 == 0)
                    Console.WriteLine("");

                Console.Write(" (" + menus[indexOfArray].car.Trim() + ") - " + menus[indexOfArray].ordem.Trim() + " - " + menus[indexOfArray].nome);
            }
            Console.WriteLine("");
        }

        public void retornaItensFamilia(String car)
        {
            Console.WriteLine("Código da Familia Selecionada:" + this.itemMenuJson.Find(x=>x.car.Trim() == car).codigo);
            //Console.WriteLine(car);
        }

        public void exibirSelecaoFamilia()
        {
            Console.WriteLine("Digite o (CAR) da família que deseja realizar a manutenção. Exemplo: 'P' para 'Pagamentos'");

            // nivel 1
            foreach(ItemMenuDinamico itemMenuDinamico in this.itemMenuJson)
            {
                this.exibirItensMenuDinamico(itemMenuDinamico);
            }

            this.retornaItensFamilia(Console.ReadLine());
        }
    }
}
