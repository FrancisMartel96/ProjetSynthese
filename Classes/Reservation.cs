using System;
using System.Text.RegularExpressions;

namespace ProjetSynthese.Classes
{
    public class Reservation
    {
        // Déclaration des attributs privés
        private string numReserv;
        private string nbInvite;
        private DateTime dateVisite;
        private string prix;
        private string nomBreuvage;
        private int prixBreuvage;
        private Client client;
        private Service service;

        // Déclaration des propriétés
        public string NumReserv
        {
            get { return numReserv; }
            set { numReserv = value; }
        }

        public string NbInvite
        {
            get { return nbInvite; }
            set { nbInvite = value; }
        }

        public DateTime DateVisite
        {
            get { return dateVisite; }
            set { dateVisite = value; }
        }

        public string Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public string NomBreuvage
        {
            get { return nomBreuvage; }
            set { nomBreuvage = value; }
        }

        public int PrixBreuvage
        {
            get { return prixBreuvage; }
            set { prixBreuvage = value; }
        }

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public Service Service
        {
            get { return service; }
            set { service = value; }
        }

        // Constructeur avec paramètres et valeurs par défaut
        public Reservation(
            string numReserv = "",
            string nbInvite = "",
            DateTime dateVisite = default(DateTime),
            string prix = "")
        {
            // Validation de données à l'aide du Regex
            Regex regNumReserv = new Regex("^[0-9]{6}$");

            if (!regNumReserv.IsMatch(numReserv))
                throw new ArgumentException
                    ("Doit être composé de six chiffres.", "numReserv");
            
            if (nbInvite == "")
                throw new ArgumentException
                        ("Veuillez choisir un nombre d'invité(s).", "nbInvite");
            
            if (dateVisite < DateTime.Today)
                throw new ArgumentException
                    ("Veuillez entrer une date présente ou future.", "dateVisite");

            this.numReserv = numReserv;
            this.nbInvite = nbInvite;
            this.dateVisite = dateVisite;
            this.prix = prix;
        }

        // Constructeur avec paramètres sans valeurs par défaut
        public Reservation(string nomBreuvage, int prixBreuvage, Client host, Service serv)
        {
            this.nomBreuvage = nomBreuvage;
            this.prixBreuvage = prixBreuvage;
            client = host;
            service = serv;
        }
    }
}
