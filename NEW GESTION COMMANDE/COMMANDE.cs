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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NEW_GESTION_COMMANDE
{
    public partial class COMMANDE : Form
    {
        public COMMANDE()
        {
            InitializeComponent();
            RemplirDataGridView();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=GestionCommande2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNUM.Text = string.Empty;
            dateTimePicker1 = new DateTimePicker();
            this.comboBoxCIN.SelectedIndex = -1;
            this.comboBoxCIN.Enabled = true;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("insert into Commande(CIN,Datecmd)values(@CIN,@Datecmd)", cnx);
                cmd.Parameters.AddWithValue("@CIN", comboBoxCIN.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Datecmd", dateTimePicker1.Value);
                cnx.Close();
                cnx.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("le commande a été ajoute avec succès");
                else
                    MessageBox.Show("Erreur lors de l'ajout du client");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                comboBoxCIN.Items.Clear();
                SqlCommand cmd = new SqlCommand("SELECT CIN FROM Client", cnx);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxCIN.Items.Add(reader["CIN"].ToString());
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
        public void RemplirDataGridView()
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from Commande", cnx);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                dataGridViewCOM.Rows.Clear();
                while (reader.Read())
                {
                    dataGridViewCOM.Rows.Add(reader["Num_cmd"].ToString(), reader["CIN"].ToString(), reader["Datecmd"].ToString());
                }
            }
        }
        int position = -1; bool check = false;
        private void button4_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("veuillez selection une ligne");
                return;
            }
            cnx.Close();
            SqlCommand cmd = new SqlCommand("delete from Commande where Num_cmd=@Num_cmd", cnx);
            cmd.Parameters.AddWithValue("@Num_cmd", textBoxNUM.Text);
            cnx.Open();
            cmd.ExecuteNonQuery();
            this.dataGridViewCOM.Rows.RemoveAt(position);
            MessageBox.Show("la commande a ete supprimer avec sucees");
            cnx.Close();
            RemplirDataGridView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void COMMANDE_Load(object sender, EventArgs e)
        {
            RemplirComboBoxClient();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBoxCIN.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un CIN dans la liste.");
                return;
            }
            SqlCommand cmd = new SqlCommand("Update Commande set CIN='" + comboBoxCIN.Text + "',Datecmd='" + dateTimePicker1.Value + "'where Num_cmd='" + textBoxNUM.Text + "'", cnx);
            cmd.Parameters.AddWithValue("@Num_cmd", textBoxNUM.Text);
            cmd.Parameters.AddWithValue("@CIN", comboBoxCIN.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Datecmd", dateTimePicker1.Value);
            cnx.Close();
            cnx.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                MessageBox.Show("la commande a ete modifier avec sucees");
            cnx.Close();
            RemplirDataGridView();
        }
        private void recherchecommabde()
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM Commande WHERE Num_cmd = @Num_cmd", cnx);
                cmd.Parameters.AddWithValue("@Num_cmd", textBoxNUM.Text);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBoxNUM.Text = reader["Num_cmd"].ToString();
                        comboBoxCIN.SelectedItem = reader["CIN"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(reader["Datecmd"]);
                    }
                    else
                    {
                        MessageBox.Show("Aucune commande trouvée pour ce numéro.");
                    }
                }
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

        private void button5_Click(object sender, EventArgs e)
        {
            recherchecommabde();
        }

        private void dataGridViewCOM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dataGridViewCOM.CurrentRow.Index;
            textBoxNUM.Text = this.dataGridViewCOM.Rows[position].Cells[0].Value.ToString();

            this.textBoxNUM.Text = this.dataGridViewCOM.Rows[position].Cells[0].Value.ToString();
            this.comboBoxCIN.Text = this.dataGridViewCOM.Rows[position].Cells[1].Value.ToString();
            this.dateTimePicker1.Value = Convert.ToDateTime(this.dataGridViewCOM.Rows[position].Cells[2].Value);

            this.textBoxNUM.Enabled = false;
            check = true;
        }

        private void comboBoxCIN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}