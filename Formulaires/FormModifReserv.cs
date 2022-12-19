using ProjetSynthese.Classes;
using System;
using System.Windows.Forms;

namespace ProjetSynthese.Formulaires
{
    public partial class FormModifReserv : Form
    {
        public FormModifReserv()
        {
            InitializeComponent();
        }

        private void FormModifReserv_Load(object sender, EventArgs e)
        {

        }

        public void CacherErreurs()
        {
            // Cacher tous les labels d'erreurs du formulaire
            labelErreurNumReserv.Text = "";
            labelErreurNbInvite.Text = "";
            labelErreurDateVisite.Text = "";
            labelErreurPrix.Text = "";
            labelErreurHote.Text = "";
            labelErreurService.Text = "";
        }

        public void ReinitialiserControles()
        {
            // Réinitialiser tous les champs du formulaire
            textBoxNumReserv.Clear();
            comboBoxNbInvite.SelectedIndex = -1;
            dateTimePickerReserv.Value = DateTime.Today;
            textBoxPrix.Clear();
            comboBoxHote.SelectedIndex = -1;
            comboBoxService.SelectedIndex = -1;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            CacherErreurs();
            try
            {
                // Instancier une réservation avec les données entrées par l'utilisateur
                Reservation reservation = new Reservation(textBoxNumReserv.Text, comboBoxNbInvite.Text,
                    dateTimePickerReserv.Value, textBoxPrix.Text);

                // Vérifier si la réservation existe déjà dans la liste
                bool numReservDispo = true;
                foreach (Reservation iReservation in StatistiquesSpa.ListReservations)
                {
                    if (iReservation.NumReserv == reservation.NumReserv)
                    {
                        numReservDispo = false;
                    }
                }
                // Si oui, modifier les informations
                if (!numReservDispo)
                {
                    StatistiquesSpa.ListReservations.Remove(reservation);
                    StatistiquesSpa.ListReservations.Add(reservation);
                    ReinitialiserControles();
                    MessageBox.Show("La réservation a été modifié avec succès!", "Confirmation");
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
                string errorMessage = error.Message.Substring(0, error.Message.LastIndexOf("\r"));
                if (error.ParamName == "numReserv")
                {
                    labelErreurNumReserv.Text = errorMessage;
                }
                else if (error.ParamName == "nbInvite")
                {
                    labelErreurNbInvite.Text = errorMessage;
                }
                else if (error.ParamName == "dateVisite")
                {
                    labelErreurDateVisite.Text = errorMessage;
                }
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            FormModifReserv f = new FormModifReserv();
            f = this;
            f.Close();
        }
    }
}
