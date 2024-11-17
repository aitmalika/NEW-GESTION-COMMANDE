namespace NEW_GESTION_COMMANDE
{
    partial class PRODUIT
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
            groupBox1 = new GroupBox();
            comboBoxcate = new ComboBox();
            Boxprix = new TextBox();
            Boxintit = new TextBox();
            BoxREF = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonNouv = new Button();
            buttonq = new Button();
            buttonsupp = new Button();
            buttonmodif = new Button();
            buttonajou = new Button();
            buttonRech = new Button();
            dataGridViewPRO = new DataGridView();
            REFERENCE = new DataGridViewTextBoxColumn();
            INTITULE = new DataGridViewTextBoxColumn();
            CATEGORIE = new DataGridViewTextBoxColumn();
            PRIXVENTE = new DataGridViewTextBoxColumn();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPRO).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxcate);
            groupBox1.Controls.Add(Boxprix);
            groupBox1.Controls.Add(Boxintit);
            groupBox1.Controls.Add(BoxREF);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(65, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 303);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "PRODUIT";
            // 
            // comboBoxcate
            // 
            comboBoxcate.FormattingEnabled = true;
            comboBoxcate.Location = new Point(205, 157);
            comboBoxcate.Name = "comboBoxcate";
            comboBoxcate.Size = new Size(121, 23);
            comboBoxcate.TabIndex = 7;
            comboBoxcate.SelectedIndexChanged += comboBoxcate_SelectedIndexChanged;
            // 
            // Boxprix
            // 
            Boxprix.Location = new Point(205, 236);
            Boxprix.Name = "Boxprix";
            Boxprix.Size = new Size(121, 23);
            Boxprix.TabIndex = 6;
            Boxprix.TextChanged += textBox3_TextChanged;
            // 
            // Boxintit
            // 
            Boxintit.Location = new Point(205, 96);
            Boxintit.Name = "Boxintit";
            Boxintit.Size = new Size(121, 23);
            Boxintit.TabIndex = 5;
            // 
            // BoxREF
            // 
            BoxREF.Location = new Point(205, 35);
            BoxREF.Name = "BoxREF";
            BoxREF.Size = new Size(121, 23);
            BoxREF.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 236);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "PRIX DE VENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 160);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "CATEGORIE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 96);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "INTITULE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "REFERENCE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonNouv);
            groupBox2.Controls.Add(buttonq);
            groupBox2.Controls.Add(buttonsupp);
            groupBox2.Controls.Add(buttonmodif);
            groupBox2.Controls.Add(buttonajou);
            groupBox2.Controls.Add(buttonRech);
            groupBox2.Location = new Point(487, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 303);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "OPERATIONS";
            // 
            // buttonNouv
            // 
            buttonNouv.Location = new Point(71, 35);
            buttonNouv.Name = "buttonNouv";
            buttonNouv.Size = new Size(120, 33);
            buttonNouv.TabIndex = 6;
            buttonNouv.Text = "Nouveau";
            buttonNouv.UseVisualStyleBackColor = true;
            buttonNouv.Click += buttonNouv_Click;
            // 
            // buttonq
            // 
            buttonq.Location = new Point(71, 237);
            buttonq.Name = "buttonq";
            buttonq.Size = new Size(120, 32);
            buttonq.TabIndex = 5;
            buttonq.Text = "QUITTER";
            buttonq.UseVisualStyleBackColor = true;
            buttonq.Click += buttonq_Click;
            // 
            // buttonsupp
            // 
            buttonsupp.Location = new Point(71, 193);
            buttonsupp.Name = "buttonsupp";
            buttonsupp.Size = new Size(120, 38);
            buttonsupp.TabIndex = 4;
            buttonsupp.Text = "SUPPRIMER";
            buttonsupp.UseVisualStyleBackColor = true;
            buttonsupp.Click += buttonsupp_Click;
            // 
            // buttonmodif
            // 
            buttonmodif.Location = new Point(71, 155);
            buttonmodif.Name = "buttonmodif";
            buttonmodif.Size = new Size(120, 32);
            buttonmodif.TabIndex = 3;
            buttonmodif.Text = "MODIFIER";
            buttonmodif.UseVisualStyleBackColor = true;
            buttonmodif.Click += buttonmodif_Click;
            // 
            // buttonajou
            // 
            buttonajou.Location = new Point(71, 113);
            buttonajou.Name = "buttonajou";
            buttonajou.Size = new Size(120, 36);
            buttonajou.TabIndex = 2;
            buttonajou.Text = "AJOUTER";
            buttonajou.UseVisualStyleBackColor = true;
            buttonajou.Click += buttonajou_Click;
            // 
            // buttonRech
            // 
            buttonRech.Location = new Point(71, 74);
            buttonRech.Name = "buttonRech";
            buttonRech.Size = new Size(120, 33);
            buttonRech.TabIndex = 1;
            buttonRech.Text = "RECHERCHER";
            buttonRech.UseVisualStyleBackColor = true;
            buttonRech.Click += buttonRech_Click;
            // 
            // dataGridViewPRO
            // 
            dataGridViewPRO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPRO.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewPRO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPRO.Columns.AddRange(new DataGridViewColumn[] { REFERENCE, INTITULE, CATEGORIE, PRIXVENTE });
            dataGridViewPRO.Location = new Point(12, 321);
            dataGridViewPRO.Name = "dataGridViewPRO";
            dataGridViewPRO.Size = new Size(776, 131);
            dataGridViewPRO.TabIndex = 2;
            dataGridViewPRO.CellContentClick += dataGridViewPRO_CellContentClick;
            // 
            // REFERENCE
            // 
            REFERENCE.HeaderText = "REFERENCE";
            REFERENCE.Name = "REFERENCE";
            // 
            // INTITULE
            // 
            INTITULE.HeaderText = "INTITULE";
            INTITULE.Name = "INTITULE";
            // 
            // CATEGORIE
            // 
            CATEGORIE.HeaderText = "CATEGORIE";
            CATEGORIE.Name = "CATEGORIE";
            // 
            // PRIXVENTE
            // 
            PRIXVENTE.HeaderText = "PRIXVENTE";
            PRIXVENTE.Name = "PRIXVENTE";
            // 
            // button1
            // 
            button1.Location = new Point(7, 12);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 19;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PRODUIT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewPRO);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PRODUIT";
            Text = "PRODUIT";
            Load += PRODUIT_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPRO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Boxprix;
        private TextBox Boxintit;
        private TextBox BoxREF;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox comboBoxcate;
        private Button buttonq;
        private Button buttonsupp;
        private Button buttonmodif;
        private Button buttonajou;
        private Button buttonRech;
        private DataGridView dataGridViewPRO;
        private DataGridViewTextBoxColumn REFERENCE;
        private DataGridViewTextBoxColumn INTITULE;
        private DataGridViewTextBoxColumn CATEGORIE;
        private DataGridViewTextBoxColumn PRIXVENTE;
        private Button buttonNouv;
        private Button button1;
    }
}