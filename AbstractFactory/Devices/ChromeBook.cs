using AbstractFactory.Interfaces;

namespace AbstractFactory.Devices
{
    internal class ChromeBook : INotebookEscritorio
    {
        public string OfficeDetails()
        {
            //descrição do item
            return "\nNome: Chromebook 11.6 \nRam: 4Gb \nSSD: 32Gb \nPlaca de video: Não há\n";
        }

    }
}
