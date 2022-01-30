using AbstractFactory.ConcretFactory;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //instanciação da classe samsung 
            INotebook samsungBook = new Samsung();
            NotebookClient clientSamsung = new NotebookClient(samsungBook);

            //aqui mostra em tela os disposittivos da samsung disponíveis
            Console.WriteLine("================= Dispositivos Samsung =================");
            Console.WriteLine(clientSamsung.SearchModelOffice());
            Console.WriteLine(clientSamsung.SearchModelGamer());
          
            
            //instanciação da classe Acer 
            INotebook acerBook = new Acer();
            NotebookClient clientAcer= new NotebookClient(acerBook);

            //aqui mostra em tela os disposittivos da samsung disponíveis
            Console.WriteLine("================= Dispositivos Acer =================");
            Console.WriteLine(clientAcer.SearchModelOffice());
            Console.WriteLine(clientAcer.SearchModelGamer());  
            
            //instanciação da classe Acer 
            INotebook dellBook = new Dell();
            NotebookClient clientDell= new NotebookClient(dellBook);

            //aqui mostra em tela os disposittivos da samsung disponíveis
            Console.WriteLine("================= Dispositivos Dell =================");
            Console.WriteLine(clientDell.SearchModelOffice());
            Console.WriteLine(clientDell.SearchModelGamer());

        }
    }
}
