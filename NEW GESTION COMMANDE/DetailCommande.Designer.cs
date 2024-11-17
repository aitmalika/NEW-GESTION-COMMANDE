namespace NEW_GESTION_COMMANDE
{
    partial class DetailCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxREF = new ComboBox();
            textBoxQU = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1CIN = new GroupBox();
            comboBoxNUM = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            groupBox2 = new GroupBox();
            buttonTER = new Button();
            buttonSUP = new Button();
            buttonMOD = new Button();
            buttonAJ = new Button();
            buttonNOU = new Button();
            dataGridViewDetailsCommande = new DataGridView();
            Num_cmd = new DataGridViewTextBoxColumn();
            RefProduit = new DataGridViewTextBoxColumn();
            QUANTITE = new DataGridViewTextBoxColumn();
            CIN = new DataGridViewTextBoxColumn();
            Categorie = new DataGridViewTextBoxColumn();
            PRIXUNITAIRE = new DataGridViewTextBoxColumn();
            Intitule = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1CIN.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetailsCommande).BeginInit();
            SuspendLayout();
            // 
            // comboBoxREF
            // 
            comboBoxREF.FormattingEnabled = true;
            comboBoxREF.Location = new Point(199, 31);
            comboBoxREF.Name = "comboBoxREF";
            comboBoxREF.Size = new Size(121, 23);
            comboBoxREF.TabIndex = 0;
            // 
            // textBoxQU
            // 
            textBoxQU.Location = new Point(199, 76);
            textBoxQU.Name = "textBoxQU";
            textBoxQU.Size = new Size(121, 23);
            textBoxQU.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 36);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "REFERENCE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 79);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "QUANTITE";
            // 
            // textBox1CIN
            // 
            textBox1CIN.Controls.Add(comboBoxNUM);
            textBox1CIN.Controls.Add(comboBox1);
            textBox1CIN.Controls.Add(label3);
            textBox1CIN.Controls.Add(label4);
            textBox1CIN.Controls.Add(dateTimePicker1);
            textBox1CIN.Controls.Add(label5);
            textBox1CIN.Controls.Add(label1);
            textBox1CIN.Controls.Add(label2);
            textBox1CIN.Controls.Add(comboBoxREF);
            textBox1CIN.Controls.Add(textBoxQU);
            textBox1CIN.Location = new Point(35, 38);
            textBox1CIN.Name = "textBox1CIN";
            textBox1CIN.Size = new Size(412, 242);
            textBox1CIN.TabIndex = 4;
            textBox1CIN.TabStop = false;
            textBox1CIN.Text = "DETAILS";
            // 
            // comboBoxNUM
            // 
            comboBoxNUM.FormattingEnabled = true;
            comboBoxNUM.Location = new Point(197, 105);
            comboBoxNUM.Name = "comboBoxNUM";
            comboBoxNUM.Size = new Size(121, 23);
            comboBoxNUM.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(199, 199);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 105);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "NUMERO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 207);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 10;
            label4.Text = "CIN CLIENT";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(199, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(119, 23);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.Value = new DateTime(2024, 10, 23, 22, 51, 11, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 149);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 11;
            label5.Text = "DATE COMMANDE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonTER);
            groupBox2.Controls.Add(buttonSUP);
            groupBox2.Controls.Add(buttonMOD);
            groupBox2.Controls.Add(buttonAJ);
            groupBox2.Controls.Add(buttonNOU);
            groupBox2.Location = new Point(453, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(277, 185);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // buttonTER
            // 
            buttonTER.Location = new Point(98, 151);
            buttonTER.Name = "buttonTER";
            buttonTER.Size = new Size(96, 23);
            buttonTER.TabIndex = 4;
            buttonTER.Text = "TERMINER";
            buttonTER.UseVisualStyleBackColor = true;
            buttonTER.Click += buttonTER_Click;
            // 
            // buttonSUP
            // 
            buttonSUP.Location = new Point(156, 110);
            buttonSUP.Name = "buttonSUP";
            buttonSUP.Size = new Size(97, 23);
            buttonSUP.TabIndex = 3;
            buttonSUP.Text = "SUPPRIMER";
            buttonSUP.UseVisualStyleBackColor = true;
            buttonSUP.Click += button4_Click;
            // 
            // buttonMOD
            // 
            buttonMOD.Location = new Point(156, 52);
            buttonMOD.Name = "buttonMOD";
            buttonMOD.Size = new Size(97, 23);
            buttonMOD.TabIndex = 2;
            buttonMOD.Text = "MODIFIER";
            buttonMOD.UseVisualStyleBackColor = true;
            buttonMOD.Click += buttonMOD_Click;
            // 
            // buttonAJ
            // 
            buttonAJ.Location = new Point(31, 110);
            buttonAJ.Name = "buttonAJ";
            buttonAJ.Size = new Size(96, 23);
            buttonAJ.TabIndex = 1;
            buttonAJ.Text = "AJOUTER";
            buttonAJ.UseVisualStyleBackColor = true;
            buttonAJ.Click += buttonAJ_Click;
            // 
            // buttonNOU
            // 
            buttonNOU.Location = new Point(31, 52);
            buttonNOU.Name = "buttonNOU";
            buttonNOU.Size = new Size(96, 23);
            buttonNOU.TabIndex = 0;
            buttonNOU.Text = "NOUVEAU";
            buttonNOU.UseVisualStyleBackColor = true;
            buttonNOU.Click += buttonNOU_Click;
            // 
            // dataGridViewDetailsCommande
            // 
            dataGridViewDetailsCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDetailsCommande.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewDetailsCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetailsCommande.Columns.AddRange(new DataGridViewColumn[] { Num_cmd, RefProduit, QUANTITE, CIN, Categorie, PRIXUNITAIRE, Intitule });
            dataGridViewDetailsCommande.Location = new Point(12, 298);
            dataGridViewDetailsCommande.Name = "dataGridViewDetailsCommande";
            dataGridViewDetailsCommande.Size = new Size(776, 140);
            dataGridViewDetailsCommande.TabIndex = 6;
            dataGridViewDetailsCommande.CellContentClick += dataGridViewDetailsCommande_CellContentClick;
            // 
            // Num_cmd
            // 
            Num_cmd.HeaderText = "NUMERO";
            Num_cmd.Name = "Num_cmd";
            // 
            // RefProduit
            // 
            RefProduit.HeaderText = "REFERENCE";
            RefProduit.Name = "RefProduit";
            // 
            // QUANTITE
            // 
            QUANTITE.HeaderText = "QUANTITE";
            QUANTITE.Name = "QUANTITE";
            // 
            // CIN
            // 
            CIN.HeaderText = "CIN";
            CIN.Name = "CIN";
            // 
            // Categorie
            // 
            Categorie.HeaderText = "Categorie";
            Categorie.Name = "Categorie";
            // 
            // PRIXUNITAIRE
            // 
            PRIXUNITAIRE.HeaderText = "PRIX UNITAIRE";
            PRIXUNITAIRE.Name = "PRIXUNITAIRE";
            // 
            // Intitule
            // 
            Intitule.HeaderText = "Intitule";
            Intitule.Name = "Intitule";
            // 
            // button1
            // 
            button1.Location = new Point(0, 9);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 19;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DetailCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewDetailsCommande);
            Controls.Add(groupBox2);
            Controls.Add(textBox1CIN);
            Name = "DetailCommande";
            Text = "DetailCommande";
            Load += DetailCommande_Load;
            textBox1CIN.ResumeLayout(false);
            textBox1CIN.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetailsCommande).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxREF;
        private TextBox textBoxQU;
        private Label label1;
        private Label label2;
        private GroupBox textBox1CIN;
        private GroupBox groupBox2;
        private Button buttonSUP;
        private Button buttonMOD;
        private Button buttonAJ;
        private Button buttonNOU;
        private Button buttonTER;
        private DataGridView dataGridViewDetailsCommande;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBoxNUM;
        private DataGridViewTextBoxColumn Num_cmd;
        private DataGridViewTextBoxColumn RefProduit;
        private DataGridViewTextBoxColumn QUANTITE;
        private DataGridViewTextBoxColumn CIN;
        private DataGridViewTextBoxColumn Categorie;
        private DataGridViewTextBoxColumn PRIXUNITAIRE;
        private DataGridViewTextBoxColumn Intitule;
    }
}