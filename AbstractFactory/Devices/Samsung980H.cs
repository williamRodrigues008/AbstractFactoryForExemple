using AbstractFactory.Interfaces;

namespace AbstractFactory.Devices
{
    internal class Samsung980H : INotebookGamer
    {
       public string GamerDetails()
        {
            //descrição do item
            return "\nNome: Samsung 9300H \nRam: 8Gb \nSSD/HD: NO\nPlaca de video: NVIDIA GeForce GTX 1650\n";
        }
    }
}
