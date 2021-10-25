using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace controle_menu_dinamico
{
    class Json
    {
        public Menus carregarJsonMenus(string fileName)
        {
            return JsonConvert.DeserializeObject<Menus>(File.ReadAllText(fileName));
        }

    }
}