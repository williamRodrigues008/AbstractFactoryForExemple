using AbstractFactory.Devices;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcretFactory
{
    public class Acer : INotebook
    {

        public INotebookEscritorio ShowOffice()
        {
            return new AcerA31();
        }

        public INotebookGamer ShowGamer()
        {
            return new AcerNitro();
        }
    }
}
