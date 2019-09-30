using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTP
{
    public class ConstructeurLiasseVehiculeDoc : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeDoc()
        {
            liasse = new LiasseDOC();
        }

        public override void construitBonDeCommande(string nomClient)
        {
            string document;
            document = "<DOC>Bon de commande Client : " + nomClient + "</DOC>";
            liasse.ajouteDocument(document);
        }

        public override void construitDemandeImmatriculation(string nomDemandeur)
        {
            string document;
            document = "<DOC>Demande d’immatriculation Demandeur : " + nomDemandeur + "</DOC>";
            liasse.ajouteDocument(document);
        }
    }
}
