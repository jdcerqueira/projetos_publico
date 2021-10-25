using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpj_menudinamico_ne
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "-p")
            {
                if(args[1] == "-id")
                {
                    int intervalo = Convert.ToInt16(args[2]);
                    MenuExistente menuExistente = JsonConvert.DeserializeObject<MenuExistente>(File.ReadAllText("menu.json")); 
                    new MenuExistente().listaProximosIdsLivres(menuExistente,intervalo);
                }
            }
        }
    }
}
