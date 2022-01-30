using AbstractFactory.Interfaces;

namespace AbstractFactory.Devices
{
    public class DellG15 : INotebookGamer
    {
        public string GamerDetails()
        {
            //descrição do item
            return "\nNome: Dell G15 \nRam: 8Gb \nSSD: 256Gb \nPlaca de video: GeForce Nvidia \n";
        }
    }
}
