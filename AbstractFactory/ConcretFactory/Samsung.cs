using AbstractFactory.Devices;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcretFactory
{
    public class Samsung : INotebook
    {
        public INotebookGamer ShowGamer()
        {
            return new Samsung980H();

        }

        public INotebookEscritorio ShowOffice()
        {
            return new ChromeBook();
        }
    }
}
