namespace ProjetSynthese.Classes
{
    public abstract class Service
    {
        // Déclaration des attributs protégés
        protected string numService;
        protected string titreService;
        protected int prix;
        protected string duree;

        // Déclaration des propriétés
        public abstract string NumService
        {
            get;
            set;
        }

        public abstract string TitreService
        {
            get;
            set;
        }

        public abstract int Prix
        {
            get;
            set;
        }

        public abstract string Duree
        {
            get;
            set;
        }

        /// <summary>
        /// Méthode qui affiche les détails d'une réservation.
        /// Elle devra être surchargée.
        /// </summary>
        public abstract void Afficher();
    }
}
