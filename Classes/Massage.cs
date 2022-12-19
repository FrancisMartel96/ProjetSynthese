using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetSynthese.Classes
{
    public class Massage : Service
    {
        // Déclaration des attributs privés
        private string nomMasso;
        private string numLicence;

        // Déclaration des propriétés
        public string NomMasso
        {
            get { return nomMasso; }
            set { nomMasso = value; }
        }

        public string NumLicence
        {
            get { return numLicence; }
            set { numLicence = value; }
        }

        // Constructeur avec paramètres
        public Massage(
            string numService,
            string titreService,
            int prix,
            string duree,
            string nomMasso,
            string numLicence
            ) : base(numService, titreService, prix, duree)
        {
            // Validation de données
            if (nomMasso == "")
                throw new ArgumentException
                    ("Veuillez choisir votre massothérapeute désiré.", "nomMasso");

            this.nomMasso = nomMasso;
            this.numLicence = numLicence;
        }

        // Appel de la méthode abstraite
        public override string AfficherInfo()
        {
            return ("Numéro: " + NumService + "\n" +
                    "Titre: " + TitreService + "\n" +
                    "Prix: " + Prix + "\n" +
                    "Durée: " + Duree + "\n" +
                    "Nom du massothérapeute: " + NomMasso + "\n" +
                    "Numéro de licence: " + NumLicence);
        }
    }
}