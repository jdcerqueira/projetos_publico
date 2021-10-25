using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_menu_dinamico
{
    class Program
    {
        static void Main(string[] args)
        {

            Parametros parametros = new Parametros().validaParametros(args);
            if(parametros != null)
            {
                try
                {
                    //carrega arquivo json completo
                    string caminhoMenuCompleto = args[0];
                    Menus menuCompleto = new Json().carregarJsonMenus(caminhoMenuCompleto);

                    //carrega arquivo parcial
                    string caminhoMenuParcial = args[1];
                    Menus menuManutencao = new Json().carregarJsonMenus(caminhoMenuParcial);

                    //reserva os itens de menu disponíveis
                    Menus novoMenu = new MenuDinamicoJson().novosMenusDisponiveis(menuCompleto, menuManutencao);

                    // inicia o processo de criacao do novo arquivo completo
                    Menus novoMenuCompleto = new MenuDinamicoJson().geraNovoMenuCompleto(menuCompleto, menuManutencao, novoMenu);
                    foreach (var item in novoMenuCompleto.menus)
                        Console.WriteLine(item);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
