using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSynthese.Formulaires
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {

        }

        private void ajoutClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutClient f = new FormAjoutClient();
            f.MdiParent = this;
            f.Show();
        }

        private void modifClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModifClient f = new FormModifClient();
            f.MdiParent = this;
            f.Show();
        }

        private void ajoutResevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutReserv f = new FormAjoutReserv();
            f.MdiParent = this;
            f.Show();
        }

        private void modifResevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModifReserv f = new FormModifReserv();
            f.MdiParent = this;
            f.Show();
        }

        private void annulerReservToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnnulReserv f = new FormAnnulReserv();
            f.MdiParent = this;
            f.Show();
        }

        private void listReservsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListReservs f = new FormListReservs();
            f.MdiParent = this;
            f.Show();
        }

        private void spaStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpaStats f = new FormSpaStats();
            f.MdiParent = this;
            f.Show();
        }
    }
}
