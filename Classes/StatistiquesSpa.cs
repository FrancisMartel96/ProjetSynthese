using System.Collections.Generic;
using System.Configuration;

namespace ProjetSynthese.Classes
{
    public static class StatistiquesSpa
    {
        // Déclaration des listes
        private static List<Reservation> listReservations;
        private static List<Client> listClients;

        // Déclaration des propriétés
        public static List<Reservation> ListReservations
        {
            get { return listReservations; }
            set { listReservations = value; }
        }

        public static List<Client> ListClients
        {
            get { return listClients; }
            set { listClients = value; }
        }

        // Constructeur
        static StatistiquesSpa()
        {
            listReservations = new List<Reservation>();
            listClients = new List<Client>();
        }

        /// <summary>
        /// Méthode qui retourne le nombre de réservations dans la liste
        /// </summary>
        /// <returns>Nombre de réservations</returns>
        public static int CompterReserv()
        {
            return listReservations.Count;
        }

        /// <summary>
        /// Méthode qui retourne le nombre de clients dans la liste
        /// </summary>
        /// <returns>Nombre de clients</returns>
        public static int CompterClient() 
        { 
            return listClients.Count;
        }
    }
}
