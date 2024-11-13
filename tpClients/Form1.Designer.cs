namespace tpClients
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCin = new TextBox();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtTelephone = new TextBox();
            Ajouter = new Button();
            button2 = new Button();
            button3 = new Button();
            gridClients = new DataGridView();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridClients).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 55);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 55);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 130);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 130);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // txtCin
            // 
            txtCin.Location = new Point(188, 55);
            txtCin.Name = "txtCin";
            txtCin.Size = new Size(188, 31);
            txtCin.TabIndex = 4;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(544, 55);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(188, 31);
            txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(188, 130);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(188, 31);
            txtPrenom.TabIndex = 6;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(544, 130);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(188, 31);
            txtTelephone.TabIndex = 7;
            // 
            // Ajouter
            // 
            Ajouter.Location = new Point(127, 192);
            Ajouter.Name = "Ajouter";
            Ajouter.Size = new Size(124, 36);
            Ajouter.TabIndex = 8;
            Ajouter.Text = "Ajouter";
            Ajouter.UseVisualStyleBackColor = true;
            Ajouter.Click += Ajouter_Click;
            // 
            // button2
            // 
            button2.Location = new Point(355, 192);
            button2.Name = "button2";
            button2.Size = new Size(124, 36);
            button2.TabIndex = 9;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(598, 192);
            button3.Name = "button3";
            button3.Size = new Size(124, 36);
            button3.TabIndex = 10;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // gridClients
            // 
            gridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClients.Location = new Point(38, 268);
            gridClients.Name = "gridClients";
            gridClients.ReadOnly = true;
            gridClients.RowHeadersWidth = 62;
            gridClients.Size = new Size(644, 166);
            gridClients.TabIndex = 11;
            gridClients.CellDoubleClick += gridClients_CellDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(714, 279);
            button1.Name = "button1";
            button1.Size = new Size(52, 36);
            button1.TabIndex = 12;
            button1.Text = "|<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(714, 398);
            button4.Name = "button4";
            button4.Size = new Size(52, 36);
            button4.TabIndex = 13;
            button4.Text = ">|";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(714, 358);
            button5.Name = "button5";
            button5.Size = new Size(52, 36);
            button5.TabIndex = 14;
            button5.Text = "<";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(714, 319);
            button6.Name = "button6";
            button6.Size = new Size(52, 36);
            button6.TabIndex = 15;
            button6.Text = ">";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(gridClients);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Ajouter);
            Controls.Add(txtTelephone);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(txtCin);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCin;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtTelephone;
        private Button Ajouter;
        private Button button2;
        private Button button3;
        private DataGridView gridClients;
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
