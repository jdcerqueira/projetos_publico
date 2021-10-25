using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpj_menudinamico_ne
{
    public class MenuExistente
    {
        public int menuPai { get; set; }
        public List<int> menusExistentes { get; set; }

        public void listaProximosIdsLivres(MenuExistente menuExistente, int intervalo)
        {
            
            List<int> disponiveis = new List<int>();

            int menuPai = menuExistente.menuPai;
            List<int> menusExistentes = menuExistente.menusExistentes;
            Console.WriteLine("menu Pai: " + menuPai);
            Console.WriteLine("total itens: " + menusExistentes.Count);

           
            for (int i = menuPai; i < (menuPai+intervalo); i++)
            {
                bool encontrou = false;
                foreach (int menu in menusExistentes)
                {
                    if (menu == i)
                        encontrou = true;
                }

                if (!encontrou)
                    disponiveis.Add(i);
            }

            foreach (int menu in disponiveis)
            {
                Console.WriteLine(menu);
            }
           

        }
    }
}
