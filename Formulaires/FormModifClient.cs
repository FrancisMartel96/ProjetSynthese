using ProjetSynthese.Classes;
using System;
using System.Windows.Forms;

namespace ProjetSynthese.Formulaires
{
    public partial class FormModifClient : Form
    {
        public FormModifClient()
        {
            InitializeComponent();
        }

        private void FormModifClient_Load(object sender, EventArgs e)
        {

        }

        public void CacherErreurs()
        {
            // Cacher tous les labels d'erreurs du formulaire
            labelErreurNumClient.Text = "";
            labelErreurPrenom.Text = "";
            labelErreurNom.Text = "";
            labelErreurDate.Text = "";
            labelErreurCourriel.Text = "";
            labelErreurNumTel.Text = "";
        }

        public void ReinitialiserControles()
        {
            // Réinitialiser tous les champs du formulaire
            textBoxNumClient.Clear();
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            dateTimePickerClient.Value = DateTime.Today;
            textBoxCourriel.Clear();
            textBoxNumTel.Clear();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            CacherErreurs();
            try
            {
                // Instancier un client avec les données entrées par l'utilisateur
                Client client = new Client(textBoxNumClient.Text, textBoxNom.Text,
                    textBoxPrenom.Text, dateTimePickerClient.Value, textBoxCourriel.Text, textBoxNumTel.Text);

                // Vérifier si le client existe déjà dans la liste
                bool numClientDispo = true;
                foreach (Client iClient in StatistiquesSpa.ListClients)
                {
                    if (iClient.NumClient == client.NumClient)
                    {
                        numClientDispo = false;
                    }
                }

                // Si oui, modifier les informations
                if (!numClientDispo)
                {
                    StatistiquesSpa.ListClients.Remove(client);
                    StatistiquesSpa.ListClients.Add(client);
                    ReinitialiserControles();
                    MessageBox.Show("Le client a été modifié avec succès!", "Confirmation");
                }
                // Sinon, afficher un message d'erreur
                else
                {
                    MessageBox.Show("Le client n'existe pas.", "Avertissement");
                }
            }
            // Relever les messages d'erreurs dans les champs si nécessaire
            catch (ArgumentException error)
            {
                string errorMessage = error.Message.Substring(0, error.Message.LastIndexOf("\r"));
                if (error.ParamName == "numClient")
                {
                    labelErreurNumClient.Text = errorMessage;
                }
                else if (error.ParamName == "prenom")
                {
                    labelErreurPrenom.Text = errorMessage;
                }
                else if (error.ParamName == "nom")
                {
                    labelErreurNom.Text = errorMessage;
                }
                else if (error.ParamName == "dateNaiss")
                {
                    labelErreurDate.Text = errorMessage;
                }
                else if (error.ParamName == "courriel")
                {
                    labelErreurCourriel.Text = errorMessage;
                }
                else if (error.ParamName == "numTel")
                {
                    labelErreurNumTel.Text = errorMessage;
                }
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            FormModifClient f = new FormModifClient();
            f = this;
            f.Close();
        }
    }
}
