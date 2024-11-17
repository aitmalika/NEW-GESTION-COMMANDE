using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace NEW_GESTION_COMMANDE
{
    public partial class CLIENT : Form
    {
        public CLIENT()
        {
            InitializeComponent();
            RemplirDataGridView();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=GestionCommande2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void butAJOUT_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == true)
                    return;
                SqlCommand cmd = new SqlCommand("insert into client(CIN,Nom,Prenom,Ville,Telephone)values(@CIN,@NOM,@Prenom,@Ville,@Telephone)", cnx);

                cmd.Parameters.AddWithValue("@CIN", textBoxCIN.Text);
                cmd.Parameters.AddWithValue("@Nom", textBoxNOM.Text);
                cmd.Parameters.AddWithValue("@Prenom", textBoxPRENOM.Text);
                cmd.Parameters.AddWithValue("@Ville", textBoxVILLE.Text);
                cmd.Parameters.AddWithValue("@Telephone", textBoxTELE.Text);
                cnx.Close();
                cnx.Open();
                int result = cmd.ExecuteNonQuery();
                butAFF_Click(sender, e);
                if (result > 0)
                    MessageBox.Show("le client a été ajoute avec succès");
                else
                    MessageBox.Show("Erreur lors de l'ajout du client");
                cnx.Close();
                RemplirDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        int position = -1; string CINclient; bool check = false;
        private void dataGridViewCLIENT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dataGridViewCLIENT.CurrentRow.Index;
            CINclient = this.dataGridViewCLIENT.Rows[position].Cells[0].Value.ToString();

            this.textBoxCIN.Text = this.dataGridViewCLIENT.Rows[position].Cells[0].Value.ToString();
            this.textBoxNOM.Text = this.dataGridViewCLIENT.Rows[position].Cells[1].Value.ToString();
            this.textBoxPRENOM.Text = this.dataGridViewCLIENT.Rows[position].Cells[2].Value.ToString();
            this.textBoxVILLE.Text = this.dataGridViewCLIENT.Rows[position].Cells[3].Value.ToString();
            this.textBoxTELE.Text = this.dataGridViewCLIENT.Rows[position].Cells[4].Value.ToString();

            this.textBoxCIN.Enabled = false;
            check = true;

        }
        public void RemplirDataGridView()
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from client", cnx);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                dataGridViewCLIENT.Rows.Clear();
                while (reader.Read())
                {
                    dataGridViewCLIENT.Rows.Add(reader["CIN"].ToString(), reader["Nom"].ToString(), reader["Prenom"].ToString(), reader["Ville"].ToString(), reader["Telephone"].ToString());
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CLIENT_Load(object sender, EventArgs e)
        {
            butAFF_Click(sender, e);
            this.dataGridViewCLIENT.ReadOnly = true;
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butMODI_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update client set Nom='" + textBoxNOM.Text + "',Prenom='" + textBoxPRENOM.Text + "',Ville='" + textBoxVILLE.Text + "' ,Telephone='" + textBoxTELE.Text + "'where CIN='" + textBoxCIN.Text + "'", cnx);
            cmd.Parameters.AddWithValue("@CIN", textBoxCIN.Text);
            cmd.Parameters.AddWithValue("@Nom", textBoxNOM.Text);
            cmd.Parameters.AddWithValue("@prenom", textBoxPRENOM.Text);
            cmd.Parameters.AddWithValue("@Ville", textBoxVILLE.Text);
            cmd.Parameters.AddWithValue("@Telephone", textBoxTELE.Text);
            cnx.Close();
            cnx.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                MessageBox.Show("le client a ete modifier avec sucees");
            cnx.Close();
            RemplirDataGridView();


        }

        private void butAFF_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select * from client", cnx);
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string CIN = reader["CIN"].ToString();
                string Nom = reader["Nom"].ToString();
                string Prenom = reader["Prenom"].ToString();
                string Ville = reader["Ville"].ToString();
                string Telephone = reader["Telephone"].ToString();

            }
            reader.Close();
            cnx.Close();
            RemplirDataGridView();
        }

        private void butSUP_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("veuillez selection une ligne");
                return;
            }
            cnx.Close();
            SqlCommand cmd = new SqlCommand("delete from client where CIN=@CIN", cnx);
            cmd.Parameters.AddWithValue("CIN", CINclient);
            cnx.Open();
            cmd.ExecuteNonQuery();
            this.dataGridViewCLIENT.Rows.RemoveAt(position);
            MessageBox.Show("le client a ete supprimer avec sucees");
            cnx.Close();
            RemplirDataGridView();


        }
        private bool checkinfo()
        {
            if (this.textBoxCIN.Text.Trim().Equals(string.Empty) ||
                this.textBoxNOM.Text.Trim().Equals(string.Empty) ||
                this.textBoxPRENOM.Text.Trim().Equals(string.Empty) ||
                this.textBoxVILLE.Text.Trim().Equals(string.Empty) ||
                this.textBoxTELE.Text.Trim().Equals(string.Empty))
                return false;
            return true;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            check = false;
            this.textBoxCIN.Text = string.Empty;
            this.textBoxNOM.Text = string.Empty;
            this.textBoxPRENOM.Text = string.Empty;
            this.textBoxVILLE.Text = string.Empty;
            this.textBoxTELE.Text = string.Empty;
            this.textBoxCIN.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }
    }
}
