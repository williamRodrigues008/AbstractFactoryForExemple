using AbstractFactory.Interfaces;

namespace AbstractFactory.Devices
{
    internal class AcerA31 : INotebookEscritorio
    {
        public string OfficeDetails()
        {
            //descrição do item
            return "\nNome: Acer A315-56-311J \nRam: 8Gb \nSSD: 256Gb \nPlaca de video: Não há\n";
        }

    }
}
