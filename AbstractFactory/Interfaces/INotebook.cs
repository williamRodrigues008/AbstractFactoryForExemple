using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esta é a classe Abstrata pricinpal, onde as demais irão como seu escopo


namespace AbstractFactory.Interfaces
{
    /// <summary>
    /// AbstractFactory
    /// </summary>
    public interface INotebook
    {
        INotebookEscritorio ShowOffice();
        INotebookGamer ShowGamer();
    }
}
