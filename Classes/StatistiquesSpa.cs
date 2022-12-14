using System.Collections.Generic;

namespace ProjetSynthese.Classes
{
    public static class StatistiquesSpa
    {
        // Déclaration de la liste de réservations
        private static List<Reservation> listReservations;

        // Déclaration des propriétés
        public static List<Reservation> ListReservations
        {
            get { return listReservations; }
            set { listReservations = value; }
        }

        // Constructeur
        static StatistiquesSpa()
        {
            listReservations = new List<Reservation>();
        }

        /// <summary>
        /// Méthode qui retourne le nombre de réservations dans la liste
        /// </summary>
        /// <returns>Nombre de réservations</returns>
        public static int CompterReserv()
        {
            return listReservations.Count;
        }
    }
}
