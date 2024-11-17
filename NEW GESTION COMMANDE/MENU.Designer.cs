namespace NEW_GESTION_COMMANDE
{
    partial class MENU
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
            Produit = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            commande = new Button();
            Client = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Produit
            // 
            Produit.Location = new Point(25, 41);
            Produit.Name = "Produit";
            Produit.Size = new Size(173, 71);
            Produit.TabIndex = 0;
            Produit.Text = "Produit";
            Produit.UseVisualStyleBackColor = true;
            Produit.Click += Produit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(commande);
            groupBox1.Controls.Add(Client);
            groupBox1.Controls.Add(Produit);
            groupBox1.Location = new Point(140, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 302);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion de Commande";
            // 
            // button1
            // 
            button1.Location = new Point(25, 186);
            button1.Name = "button1";
            button1.Size = new Size(173, 75);
            button1.TabIndex = 3;
            button1.Text = "Command";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // commande
            // 
            commande.Location = new Point(261, 186);
            commande.Name = "commande";
            commande.Size = new Size(163, 69);
            commande.TabIndex = 2;
            commande.Text = "Detail Commande";
            commande.UseVisualStyleBackColor = true;
            commande.Click += commande_Click;
            // 
            // Client
            // 
            Client.Location = new Point(261, 41);
            Client.Name = "Client";
            Client.Size = new Size(163, 71);
            Client.TabIndex = 1;
            Client.Text = "Client";
            Client.UseVisualStyleBackColor = true;
            Client.Click += Client_Click;
            // 
            // button2
            // 
            button2.Location = new Point(649, 170);
            button2.Name = "button2";
            button2.Size = new Size(110, 50);
            button2.TabIndex = 2;
            button2.Text = "FERMER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "MENU";
            Text = "MENU";
            Load += MENU_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Produit;
        private GroupBox groupBox1;
        private Button commande;
        private Button Client;
        private Button button1;
        private Button button2;
    }
}