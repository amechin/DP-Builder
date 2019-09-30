using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTP
{
    public class ClientVehicule
    {
        static void Main(string[] args)
        {
            ConstructeurLiasseVehicule constructeur;
            Console.WriteLine("Voulez-vous construire " + "des liasses HTML (1), PDF (2) ou DOC (3):");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else if (choix == "2")
            {
                constructeur = new ConstructeurLiasseVehiculePdf();
            }
            else
            {
                constructeur = new ConstructeurLiasseVehiculeDoc();
            }
            Vendeur vendeur = new Vendeur(constructeur);
            Liasse liasse = vendeur.construit("Dupuis");
            liasse.imprime();
            Console.ReadKey();
        }
    }
}
