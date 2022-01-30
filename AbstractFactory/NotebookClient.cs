using AbstractFactory.Interfaces;


//classe cliente 
//esta classe irá receber os parametros 
namespace AbstractFactory
{
    public class NotebookClient
    {
        INotebookEscritorio notebookEscritorio;
        INotebookGamer notebookGamer;

        public NotebookClient(INotebook notebook)
        {
            notebookEscritorio = notebook.ShowOffice();
            notebookGamer = notebook.ShowGamer();
        }

        public string SearchModelOffice()
        {
            return notebookEscritorio.OfficeDetails();
        }

        public string SearchModelGamer()
        {
            return notebookGamer.GamerDetails();
        }


    }
}
