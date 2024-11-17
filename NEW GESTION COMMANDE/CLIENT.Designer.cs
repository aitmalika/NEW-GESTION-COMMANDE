namespace NEW_GESTION_COMMANDE
{
    partial class CLIENT
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxCIN = new TextBox();
            textBoxNOM = new TextBox();
            textBoxPRENOM = new TextBox();
            textBoxVILLE = new TextBox();
            textBoxTELE = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            butAJOUT = new Button();
            butMODI = new Button();
            butSUP = new Button();
            butAFF = new Button();
            dataGridViewCLIENT = new DataGridView();
            CIN = new DataGridViewTextBoxColumn();
            NOM = new DataGridViewTextBoxColumn();
            PRENOM = new DataGridViewTextBoxColumn();
            VILLE = new DataGridViewTextBoxColumn();
            TELEPHONE = new DataGridViewTextBoxColumn();
            buttonQ = new Button();
            groupBox1 = new GroupBox();
            buttonNew = new Button();
            groupBox2 = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCLIENT).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCIN
            // 
            textBoxCIN.Location = new Point(219, 22);
            textBoxCIN.Name = "textBoxCIN";
            textBoxCIN.Size = new Size(100, 23);
            textBoxCIN.TabIndex = 0;
            // 
            // textBoxNOM
            // 
            textBoxNOM.Location = new Point(219, 79);
            textBoxNOM.Name = "textBoxNOM";
            textBoxNOM.Size = new Size(100, 23);
            textBoxNOM.TabIndex = 1;
            // 
            // textBoxPRENOM
            // 
            textBoxPRENOM.Location = new Point(219, 147);
            textBoxPRENOM.Name = "textBoxPRENOM";
            textBoxPRENOM.Size = new Size(100, 23);
            textBoxPRENOM.TabIndex = 2;
            // 
            // textBoxVILLE
            // 
            textBoxVILLE.Location = new Point(219, 209);
            textBoxVILLE.Name = "textBoxVILLE";
            textBoxVILLE.Size = new Size(100, 23);
            textBoxVILLE.TabIndex = 3;
            // 
            // textBoxTELE
            // 
            textBoxTELE.Location = new Point(219, 273);
            textBoxTELE.Name = "textBoxTELE";
            textBoxTELE.Size = new Size(100, 23);
            textBoxTELE.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 30);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 5;
            label1.Text = "CIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 87);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "NOM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 147);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 7;
            label3.Text = "PRENOM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 209);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 8;
            label4.Text = "VILLE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 276);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 9;
            label5.Text = "TELEPHONE";
            // 
            // butAJOUT
            // 
            butAJOUT.Location = new Point(87, 75);
            butAJOUT.Name = "butAJOUT";
            butAJOUT.Size = new Size(103, 36);
            butAJOUT.TabIndex = 10;
            butAJOUT.Text = "AJOUTER";
            butAJOUT.UseVisualStyleBackColor = true;
            butAJOUT.Click += butAJOUT_Click;
            // 
            // butMODI
            // 
            butMODI.Location = new Point(87, 134);
            butMODI.Name = "butMODI";
            butMODI.Size = new Size(103, 36);
            butMODI.TabIndex = 11;
            butMODI.Text = "MODIFIER";
            butMODI.UseVisualStyleBackColor = true;
            butMODI.Click += butMODI_Click;
            // 
            // butSUP
            // 
            butSUP.Location = new Point(87, 192);
            butSUP.Name = "butSUP";
            butSUP.Size = new Size(103, 36);
            butSUP.TabIndex = 12;
            butSUP.Text = "SUPPRIMER";
            butSUP.UseVisualStyleBackColor = true;
            butSUP.Click += butSUP_Click;
            // 
            // butAFF
            // 
            butAFF.Location = new Point(87, 245);
            butAFF.Name = "butAFF";
            butAFF.Size = new Size(103, 35);
            butAFF.TabIndex = 13;
            butAFF.Text = "AFFICHER";
            butAFF.UseVisualStyleBackColor = true;
            butAFF.Click += butAFF_Click;
            // 
            // dataGridViewCLIENT
            // 
            dataGridViewCLIENT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCLIENT.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCLIENT.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCLIENT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCLIENT.Columns.AddRange(new DataGridViewColumn[] { CIN, NOM, PRENOM, VILLE, TELEPHONE });
            dataGridViewCLIENT.Location = new Point(-2, 368);
            dataGridViewCLIENT.Name = "dataGridViewCLIENT";
            dataGridViewCLIENT.Size = new Size(790, 104);
            dataGridViewCLIENT.TabIndex = 14;
            dataGridViewCLIENT.CellContentClick += dataGridViewCLIENT_CellContentClick;
            // 
            // CIN
            // 
            CIN.HeaderText = "CIN";
            CIN.Name = "CIN";
            // 
            // NOM
            // 
            NOM.HeaderText = "NOM";
            NOM.Name = "NOM";
            // 
            // PRENOM
            // 
            PRENOM.HeaderText = "PRENOM";
            PRENOM.Name = "PRENOM";
            // 
            // VILLE
            // 
            VILLE.HeaderText = "VILLE";
            VILLE.Name = "VILLE";
            // 
            // TELEPHONE
            // 
            TELEPHONE.HeaderText = "TELEPHONE";
            TELEPHONE.Name = "TELEPHONE";
            // 
            // buttonQ
            // 
            buttonQ.Location = new Point(87, 299);
            buttonQ.Name = "buttonQ";
            buttonQ.Size = new Size(103, 36);
            buttonQ.TabIndex = 15;
            buttonQ.Text = "QUITTER";
            buttonQ.UseVisualStyleBackColor = true;
            buttonQ.Click += buttonQ_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonNew);
            groupBox1.Controls.Add(butAJOUT);
            groupBox1.Controls.Add(butMODI);
            groupBox1.Controls.Add(buttonQ);
            groupBox1.Controls.Add(butSUP);
            groupBox1.Controls.Add(butAFF);
            groupBox1.Location = new Point(475, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 339);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(87, 22);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(103, 36);
            buttonNew.TabIndex = 16;
            buttonNew.Text = "Nouveau";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBoxPRENOM);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(textBoxCIN);
            groupBox2.Controls.Add(textBoxNOM);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxVILLE);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxTELE);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(-2, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(790, 356);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(6, 11);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 18;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CLIENT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 471);
            Controls.Add(groupBox2);
            Controls.Add(dataGridViewCLIENT);
            Name = "CLIENT";
            Text = "CLIENT";
            Load += CLIENT_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCLIENT).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxCIN;
        private TextBox textBoxNOM;
        private TextBox textBoxPRENOM;
        private TextBox textBoxVILLE;
        private TextBox textBoxTELE;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button butAJOUT;
        private Button butMODI;
        private Button butSUP;
        private Button butAFF;
        private DataGridView dataGridViewCLIENT;
        private Button buttonQ;
        private DataGridViewTextBoxColumn CIN;
        private DataGridViewTextBoxColumn NOM;
        private DataGridViewTextBoxColumn PRENOM;
        private DataGridViewTextBoxColumn VILLE;
        private DataGridViewTextBoxColumn TELEPHONE;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonNew;
        private Button button1;
    }
}
