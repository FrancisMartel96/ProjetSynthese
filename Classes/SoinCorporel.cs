using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSynthese.Classes
{
    public class SoinCorporel : Service
    {
        // Déclaration des attributs privés
        private string nomEsthe;

        // Déclaration des propriétés
        public string NomEsthe
        {
            get { return nomEsthe; }
            set { nomEsthe = value; }
        }

        // Constructeur avec paramètre sans valeurs par défaut
        public SoinCorporel(
            string numService,
            string titreService,
            int prix,
            string duree,
            string nomEsthe
            ) : base(numService, titreService, prix, duree)
        {
            // Validation de données
            if (nomEsthe == "")
                throw new ArgumentException
                    ("Veuillez choisir votre esthéticien(ne) désiré.", "nomEsthe");

            this.nomEsthe = nomEsthe;
        }

        // Appel de la méthode abstraite
        public override string AfficherInfo()
        {
            return ("Numéro: " + NumService + "\n" +
                    "Titre: " + TitreService + "\n" +
                    "Prix: " + Prix + "\n" +
                    "Durée: " + Duree + "\n" +
                    "Nom de l'esthéticienne: " + NomEsthe);
        }
    }
}
