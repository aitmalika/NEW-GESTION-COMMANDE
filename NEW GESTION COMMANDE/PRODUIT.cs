using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NEW_GESTION_COMMANDE
{
    public partial class PRODUIT : Form
    {
        public PRODUIT()
        {
            InitializeComponent();
            RemplirDataGridView();
            RemplirComboBoxCategorie();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=GestionCommande2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonajou_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                SqlCommand cmdselect = new SqlCommand("select distinct Categorie from Produit", cnx);
                SqlDataReader reader = cmdselect.ExecuteReader();
                comboBoxcate.Items.Clear();
                while (reader.Read())
                {
                    comboBoxcate.Items.Add(reader["CATEGORIE"].ToString());
                }

                reader.Close();
                SqlCommand cmd = new SqlCommand("insert into Produit(Intitule,Categorie,PrixVente)values(@Intitule,@Categorie,@PrixVente)", cnx);
                cmd.Parameters.AddWithValue("@Intitule", Boxintit.Text);
                cmd.Parameters.AddWithValue("@Categorie", comboBoxcate.Text);
                cmd.Parameters.AddWithValue("@PrixVente", Boxprix.Text);

                int resultat = cmd.ExecuteNonQuery();
                if (resultat > 0)
                {
                    MessageBox.Show("le produit ajouter avec sucees");
                }
                else
                {
                    MessageBox.Show("erreur d'ajouter un produit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

            RemplirDataGridView();

        }

        private void buttonq_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int position = -1; string reff; bool check = false;
        private void dataGridViewPRO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dataGridViewPRO.CurrentRow.Index;
            reff = this.dataGridViewPRO.Rows[position].Cells[0].Value.ToString();

            this.BoxREF.Text = this.dataGridViewPRO.Rows[position].Cells[0].Value.ToString();
            this.Boxintit.Text = this.dataGridViewPRO.Rows[position].Cells[1].Value.ToString();
            this.comboBoxcate.SelectedValue = this.dataGridViewPRO.Rows[position].Cells[2].Value.ToString();
            this.Boxprix.Text = this.dataGridViewPRO.Rows[position].Cells[3].Value.ToString();

            this.BoxREF.Enabled = false;
            check = true;
        }
        public void RemplirDataGridView()
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from Produit", cnx);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                
                dataGridViewPRO.Rows.Clear();
                while (reader.Read())
                {
                    dataGridViewPRO.Rows.Add(reader["Refproduit"].ToString(), reader["Intitule"].ToString(), reader["Categorie"].ToString(), reader["PrixVente"].ToString());
                }
            }
        }
        private void RemplirComboBoxCategorie()
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                {
                     cnx.Open();
                }
               
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Categorie FROM Produit", cnx);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxcate.Items.Add(reader["Categorie"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        private void PRODUIT_Load(object sender, EventArgs e)
        {
            RemplirComboBoxCategorie();
            this.dataGridViewPRO.ReadOnly = true;
        }

        private void buttonNouv_Click(object sender, EventArgs e)
        {
            check = false;
            this.BoxREF.Text = string.Empty;
            this.Boxintit.Text = string.Empty;
            this.comboBoxcate.SelectedValue = string.Empty;
            this.Boxprix.Text = string.Empty;
            this.BoxREF.Enabled = true;
        }

        private void buttonmodif_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Produit set Intitule='" + Boxintit.Text + "',Categorie='" + comboBoxcate.Text + "' ,PrixVente='" + Boxprix.Text + "'where Refproduit='" + BoxREF.Text + "'", cnx);
            cmd.Parameters.AddWithValue("@Refproduit", BoxREF.Text);
            cmd.Parameters.AddWithValue("@Intitule", Boxintit.Text);
            cmd.Parameters.AddWithValue("@Categorie", comboBoxcate.Text);
            cmd.Parameters.AddWithValue("@PrixVente", Boxprix.Text);

            cnx.Close();
            cnx.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                MessageBox.Show("le produit a ete modifier avec sucees");
            cnx.Close();
            RemplirDataGridView();
        }

        private void buttonsupp_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("veuillez selection une ligne");
                return;
            }
            cnx.Close();
            SqlCommand cmd = new SqlCommand("delete from Produit where Refproduit=@Refproduit", cnx);
            cmd.Parameters.AddWithValue("Refproduit", reff);
            cnx.Open();
            cmd.ExecuteNonQuery();
            this.dataGridViewPRO.Rows.RemoveAt(position);
            MessageBox.Show("le produit a ete supprimer avec sucees");
            cnx.Close();
            RemplirDataGridView();

        }

        private void buttonRech_Click(object sender, EventArgs e)
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
            }

            try
            {
                SqlCommand cmd = new SqlCommand("select Intitule, Categorie, PrixVente from Produit where Refproduit = @Refproduit", cnx);
                cmd.Parameters.AddWithValue("@Refproduit", BoxREF.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string intitule = reader["Intitule"].ToString();
                    string categorie = reader["Categorie"].ToString();
                    string prixVente = reader["PrixVente"].ToString();
                    Boxintit.Text = intitule;
                    comboBoxcate.Text = categorie;
                    Boxprix.Text = prixVente;
                }
                else
                {
                    MessageBox.Show("Produit non trouvé !");
                }

                reader.Close();
            }
            finally
            {
                cnx.Close();
            }
        }

        private void comboBoxcate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
            }

            try
            {
                SqlCommand cmd = new SqlCommand("select * from Produit where Refproduit='" + comboBoxcate.SelectedValue + "'", cnx);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BoxREF.Text = dr[1].ToString();
                    Boxintit.Text = dr[2].ToString();
                    Boxprix.Text = dr[3].ToString();
                }

                dr.Close();
            }
            finally
            {
                cnx.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }
    }
}
