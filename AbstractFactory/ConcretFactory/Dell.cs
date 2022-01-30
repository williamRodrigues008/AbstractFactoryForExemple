using AbstractFactory.Devices;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcretFactory
{
    public class Dell : INotebook
    {
      

        public INotebookEscritorio ShowOffice()
        {
            return new DellInspiron54();
        }

        public INotebookGamer ShowGamer()
        {
            return new DellG15();
        }
    }
}
