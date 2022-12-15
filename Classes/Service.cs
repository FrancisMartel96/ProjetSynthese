namespace ProjetSynthese.Classes
{
    public class Service
    {
        // Déclaration des attributs privés
        private string numService;
        private string titreService;
        private int prix;
        private string duree;

        // Déclaration des propriétés
        public string NumService
        {
            get { return numService; }
            set { numService = value; }
        }

        public string TitreService
        {
            get { return titreService; }
            set { titreService = value; }
        }

        public int Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public string Duree
        {
            get { return duree; }
            set { duree = value; }
        }

        // Constructeur avec paramètres sans valeurs par défaut
        public Service(string numService, string titreService, int prix, string duree)
        {
            this.numService = numService;
            this.titreService = titreService;
            this.prix = prix;
            this.duree = duree;
        }
    }
}
