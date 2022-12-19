using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetSynthese.Classes
{
    public class Client
    {
        // Déclaration des attributs privés
        private string numClient;
        private string prenom;
        private string nom;
        private DateTime dateNaiss;
        private string courriel;
        private string numTel;

        // Déclaration des propriétés
        public string NumClient
        {
            get { return numClient; }
            set { numClient = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public DateTime DateNaiss
        {
            get { return dateNaiss; }
            set { dateNaiss = value; }
        }

        public string Courriel
        {
            get { return courriel; }
            set { courriel = value; }
        }

        public string NumTel
        {
            get { return numTel; }
            set { numTel = value; }
        }

        // Constructeur avec paramètres et valeurs par défaut
        public Client(string numClient = "",
            string prenom = "",
            string nom = "",
            DateTime dateNaiss = default(DateTime),
            string courriel = "",
            string numTel = "")
        {
            // Validation de données à l'aide du Regex
            Regex regNumClient = new Regex("^[0-9]{6}$");
            Regex regPrenom = new Regex("^[A-Z]{1}[a-z]{1,20}$");
            Regex regNom = new Regex("^[A-Z]{1}[a-z]{1,20}$");
            Regex regCourriel = new Regex("^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$");
            Regex regNumTel = new Regex("^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$");

            if (!regNumClient.IsMatch(numClient))
                throw new ArgumentException
                    ("Doit être composé de six chiffres", "numClient");

            if (!regPrenom.IsMatch(prenom))
                throw new ArgumentException
                    ("Doit commencer par une majuscule suivie d'un à vingt caractères alphabétiques.", "prenom");

            if (!regNom.IsMatch(nom))
                throw new ArgumentException
                    ("Doit commencer par une majuscule suivie d'un à vingt caractères alphabétiques.", "nom");

            if (Age(dateNaiss) < 16)
                throw new ArgumentException
                    ("Le client doit avoir au moins 16 ans.", "dateNaiss");

            if (!regCourriel.IsMatch(courriel))
                throw new ArgumentException
                    ("Veuillez saisir une adresse de courriel valide.", "courriel");

            if (!regNumTel.IsMatch(numTel))
                throw new ArgumentException
                    ("Veuillez saisir un numéro de téléphone valide.", "numTel");

            this.numClient = numClient;
            this.prenom = prenom;
            this.nom = nom;
            this.dateNaiss = dateNaiss;
            this.courriel = courriel;
            this.numTel = numTel;
        }

        /// <summary>
        /// Méthode qui calcule l'âge d'un client
        /// Source: 
        /// </summary>
        /// <param name="dateNaiss"></param>
        /// <returns>Âge du client</returns>
        public static int Age(DateTime dateNaiss)
        {
            // Enregistre la date d'aujourd'hui
            var today = DateTime.Today;
            // Calcule l'âge
            var age = today.Year - dateNaiss.Year;
            // Retourne à l'année de naissance de la personne en cas d'année bissextile
            if (dateNaiss.Date > today.AddYears(-age)) age = age - 1;
            return age;
        }
    }
}
