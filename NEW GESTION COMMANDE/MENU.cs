using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEW_GESTION_COMMANDE
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void commande_Click(object sender, EventArgs e)
        {
            DetailCommande detailcommande = new DetailCommande();
            detailcommande.Show();
            this.Hide();
        }

        private void Produit_Click(object sender, EventArgs e)
        {
            PRODUIT pro = new PRODUIT();
            pro.Show();
            this.Hide();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            CLIENT client = new CLIENT();
            client.Show();
            this.Hide();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            COMMANDE command = new COMMANDE();
            command.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
