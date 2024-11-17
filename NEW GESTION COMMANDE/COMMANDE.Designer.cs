namespace NEW_GESTION_COMMANDE
{
    partial class COMMANDE
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxNUM = new TextBox();
            dataGridViewCOM = new DataGridView();
            Num_cmd = new DataGridViewTextBoxColumn();
            CIN = new DataGridViewTextBoxColumn();
            Datecmd = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            comboBoxCIN = new ComboBox();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCOM).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "NUMERO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 135);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "CIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "DATE COMMANDE";
            // 
            // textBoxNUM
            // 
            textBoxNUM.Location = new Point(117, 33);
            textBoxNUM.Name = "textBoxNUM";
            textBoxNUM.Size = new Size(100, 23);
            textBoxNUM.TabIndex = 3;
            // 
            // dataGridViewCOM
            // 
            dataGridViewCOM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCOM.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCOM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCOM.Columns.AddRange(new DataGridViewColumn[] { Num_cmd, CIN, Datecmd });
            dataGridViewCOM.Location = new Point(12, 253);
            dataGridViewCOM.Name = "dataGridViewCOM";
            dataGridViewCOM.Size = new Size(776, 185);
            dataGridViewCOM.TabIndex = 6;
            dataGridViewCOM.CellContentClick += dataGridViewCOM_CellContentClick;
            // 
            // Num_cmd
            // 
            Num_cmd.HeaderText = "NUMERO";
            Num_cmd.Name = "Num_cmd";
            // 
            // CIN
            // 
            CIN.HeaderText = "CIN";
            CIN.Name = "CIN";
            // 
            // Datecmd
            // 
            Datecmd.HeaderText = "DATE COMMANDE";
            Datecmd.Name = "Datecmd";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.Off;
            dateTimePicker1.Location = new Point(117, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(119, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2024, 10, 23, 22, 51, 11, 0);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxCIN);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxNUM);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 245);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "COMMANDES";
            // 
            // comboBoxCIN
            // 
            comboBoxCIN.FormattingEnabled = true;
            comboBoxCIN.Location = new Point(117, 127);
            comboBoxCIN.Name = "comboBoxCIN";
            comboBoxCIN.Size = new Size(121, 23);
            comboBoxCIN.TabIndex = 9;
            comboBoxCIN.SelectedIndexChanged += comboBoxCIN_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(441, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(312, 235);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // button6
            // 
            button6.Font = new Font("Algerian", 12F);
            button6.Location = new Point(154, 141);
            button6.Name = "button6";
            button6.Size = new Size(136, 23);
            button6.TabIndex = 5;
            button6.Text = "QUITTER";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Algerian", 12F);
            button5.Location = new Point(21, 141);
            button5.Name = "button5";
            button5.Size = new Size(117, 23);
            button5.TabIndex = 4;
            button5.Text = "RECHERCHER";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Algerian", 12F);
            button4.Location = new Point(154, 94);
            button4.Name = "button4";
            button4.Size = new Size(136, 23);
            button4.TabIndex = 3;
            button4.Text = "SUPPRIMER";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Algerian", 12F);
            button3.Location = new Point(21, 94);
            button3.Name = "button3";
            button3.Size = new Size(117, 23);
            button3.TabIndex = 2;
            button3.Text = "MODIFIER";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Algerian", 12F);
            button2.Location = new Point(154, 52);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 1;
            button2.Text = "AJOUTER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Algerian", 12F);
            button1.Location = new Point(21, 52);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 0;
            button1.Text = "NOUVEAU";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(348, 12);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 11;
            button7.Text = "Menu";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // COMMANDE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewCOM);
            Name = "COMMANDE";
            Text = "COMMANDE";
            Load += COMMANDE_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCOM).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNUM;
        private DataGridView dataGridViewCOM;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button7;
        private ComboBox comboBoxCIN;
        private DataGridViewTextBoxColumn Num_cmd;
        private DataGridViewTextBoxColumn CIN;
        private DataGridViewTextBoxColumn Datecmd;
    }
}