using AbstractFactory.Interfaces;

namespace AbstractFactory.Devices
{
    internal class DellInspiron54 : INotebookEscritorio
    {
        public string OfficeDetails()
        {
            //descrição do item
            return "\nNome: Dell Inspiron 5402 \nRam: 8Gb \nSSD: 256Gb \nPlaca de video: Não há\n";
        }
    }
}
