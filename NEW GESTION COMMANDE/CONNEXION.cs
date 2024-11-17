using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEW_GESTION_COMMANDE
{
    public partial class CONNEXION : Form
    {
        public CONNEXION()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=GestionCommande2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Déconnecté avec succès");
            this.Close();

        }

        private void CONNEXION_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            MessageBox.Show("Connecté avec succès");
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }
    }
}
