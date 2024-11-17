namespace NEW_GESTION_COMMANDE
{
    partial class CONNEXION
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
            textBoxU = new TextBox();
            textBoxMOT = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxU
            // 
            textBoxU.Location = new Point(423, 96);
            textBoxU.Name = "textBoxU";
            textBoxU.Size = new Size(100, 23);
            textBoxU.TabIndex = 0;
            // 
            // textBoxMOT
            // 
            textBoxMOT.Location = new Point(423, 161);
            textBoxMOT.Name = "textBoxMOT";
            textBoxMOT.Size = new Size(100, 23);
            textBoxMOT.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 104);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "LOGIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 169);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 7;
            label4.Text = "MOT DE PASSE";
            // 
            // button1
            // 
            button1.Location = new Point(154, 257);
            button1.Name = "button1";
            button1.Size = new Size(145, 37);
            button1.TabIndex = 8;
            button1.Text = "CONNECTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(391, 257);
            button2.Name = "button2";
            button2.Size = new Size(166, 37);
            button2.TabIndex = 9;
            button2.Text = "ANNULER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CONNEXION
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxMOT);
            Controls.Add(textBoxU);
            Name = "CONNEXION";
            Text = "CONNEXION";
            Load += CONNEXION_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxU;
        private TextBox textBoxMOT;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}