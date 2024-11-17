using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace NEW_GESTION_COMMANDE
{
    public partial class DetailCommande : Form
    {
        public DetailCommande()
        {
            InitializeComponent();
            RemplirDataGridView();

        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=GestionCommande2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from DetailsCommande where Num_cmd=@Num_cmd", cnx);
            cmd.Parameters.AddWithValue("Num_cmd", comboBoxNUM.Text);
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("detail de commande a ete supprimé avec sucés");
            RemplirDataGridView();

        }

        private void DetailCommande_Load(object sender, EventArgs e)
        {
            RemplirComboBoxCategorie();
            RemplirComboBoxClient();
            remplircomboxcommand();
        }

        private void buttonAJ_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO DetailsCommande (Num_cmd,RefProduit, Quantite,CIN) VALUES (@Num_cmd,@RefProduit, @Quantite,@CIN)", cnx);

            cmd.Parameters.AddWithValue("@Num_cmd", comboBoxNUM.SelectedItem);
            cmd.Parameters.AddWithValue("@RefProduit", comboBoxREF.SelectedItem);
            cmd.Parameters.AddWithValue("@Quantite", textBoxQU.Text);
            cmd.Parameters.AddWithValue("CIN",comboBox1.SelectedItem);
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("details de commande ajoutés avec succés");
            RemplirDataGridView();
        }

        private void buttonNOU_Click(object sender, EventArgs e)
        {
            this.comboBoxNUM.Text = string.Empty;
            this.comboBoxREF.SelectedIndex = -1;
            this.textBoxQU.Text = string.Empty;
            this.comboBoxREF.Enabled = true;
        }

        private void buttonMOD_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update DetailsCommande set RefProduit=@RefProduit,Quantite=@Quantite WHERE Num_cmd=@Num_cmd", cnx);
            cmd.Parameters.AddWithValue("@RefProduit", comboBoxREF.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Quantite", textBoxQU.Text);
            cmd.Parameters.AddWithValue("@Num_cmd", comboBoxNUM.Text);
            cmd.Parameters.AddWithValue("@datecommande", dateTimePicker1.Text);
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Détails de commande modifiés avec succès.");
            RemplirDataGridView();
        }
        private void RemplirDataGridView()
        {
            dataGridViewDetailsCommande.Rows.Clear();
            using (SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=GestionCommande2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                string query = "SELECT dc.Num_cmd, dc.RefProduit, dc.Quantite, dc.CIN,p.PrixVente, p.Intitule,p.Categorie " +
                      "FROM DetailsCommande dc " +
                      "JOIN Produit p ON dc.RefProduit = p.Refproduit";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cnx.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    dataGridViewDetailsCommande.Rows.Add(
                reader["Num_cmd"], reader["RefProduit"], reader["Quantite"], reader["CIN"], reader["Categorie"],
                reader["PrixVente"], reader["Intitule"]);
                }
                reader.Close();
                cnx.Close();
            }
        }

        private void buttonTER_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void remplircomboxcommand()
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                comboBoxNUM.Items.Clear();
                SqlCommand cmd = new SqlCommand("select Num_cmd from Commande", cnx);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxNUM.Items.Add(reader["Num_cmd"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
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

                comboBoxREF.Items.Clear();
                SqlCommand cmd = new SqlCommand("SELECT Refproduit FROM Produit", cnx);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxREF.Items.Add(reader["Refproduit"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        private void RemplirComboBoxClient()
        {
            
            try

            {
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
               
                comboBox1.Items.Clear();
                SqlCommand cmd = new SqlCommand("SELECT CIN FROM Client", cnx);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["CIN"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }
        int position = -1; bool check = false;
        private void dataGridViewDetailsCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dataGridViewDetailsCommande.CurrentRow.Index;
            comboBoxNUM.Text = this.dataGridViewDetailsCommande.Rows[position].Cells[0].Value.ToString();

            this.comboBoxNUM.Text = this.dataGridViewDetailsCommande.Rows[position].Cells[0].Value.ToString();
            this.comboBoxREF.Text = this.dataGridViewDetailsCommande.Rows[position].Cells[1].Value.ToString();
            this.textBoxQU.Text = this.dataGridViewDetailsCommande.Rows[position].Cells[2].Value.ToString();
            this.comboBox1 .Text= this.dataGridViewDetailsCommande.Rows[position].Cells[3].Value.ToString();

            this.comboBoxNUM.Enabled = false;
            check = true;
        }
    }
}
