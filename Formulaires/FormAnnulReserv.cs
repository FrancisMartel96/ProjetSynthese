using ProjetSynthese.Classes;
using System;
using System.Windows.Forms;

namespace ProjetSynthese.Formulaires
{
    public partial class FormAnnulReserv : Form
    {
        public FormAnnulReserv()
        {
            InitializeComponent();
        }

        private void FormAnnulReserv_Load(object sender, EventArgs e)
        {

        }

        public void CacherErreurs()
        {
            // Cacher tous les labels d'erreurs du formulaire
            labelErreurNumReserv.Text = "";
        }

        public void ReinitialiserControles()
        {
            // Réinitialiser tous les champs du formulaire
            textBoxNumReserv.Clear();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            CacherErreurs();
            try
            {
                // Vérifier si le numéro de la réservation existe déjà dans la liste
                Reservation reservation = null;
                foreach (Reservation iReservation in StatistiquesSpa.ListReservations)
                {
                    if (iReservation.NumReserv == textBoxNumReserv.Text)
                    {
                        reservation = iReservation;
                    }
                }
                // Si oui, supprimer la réservation
                if (reservation != null)
                {
                    StatistiquesSpa.ListReservations.Remove(reservation);
                    ReinitialiserControles();
                    MessageBox.Show("La réservation a été supprimé avec succès!", "Confirmation");
                }
                // Sinon, afficher un message d'erreur
                else
                {
                    MessageBox.Show("La réservation n'existe pas.", "Avertissement");
                }
            }
            // Relever les messages d'erreurs dans les champs si nécessaire
            catch (ArgumentException error)
            {
                if (error.ParamName == "numReserv")
                {
                    labelErreurNumReserv.Text = error.Message;
                }
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            FormAnnulReserv f = new FormAnnulReserv();
            f = this;
            f.Close();
        }
    }
}
