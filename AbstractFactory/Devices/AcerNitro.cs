using AbstractFactory.Interfaces;

namespace AbstractFactory.Devices
{
    internal class AcerNitro : INotebookGamer
    {
        public string GamerDetails()
        {
            //descrição do item
            return "\nNome: Dell Aspire Nitro \nRam: 8Gb \nSSD: 512Gb \nPlaca de video: GTX 1650\n";
            
        }

    }
}
