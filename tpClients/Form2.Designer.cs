namespace tpClients
{
    partial class Form2
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
            dateCr = new DateTimePicker();
            txtSolde = new TextBox();
            comboClient = new ComboBox();
            gridCompte = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridCompte).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 58);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Date Creation :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 58);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 1;
            label2.Text = "Solde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 142);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 2;
            label3.Text = "Clients";
            // 
            // dateCr
            // 
            dateCr.Location = new Point(266, 59);
            dateCr.Name = "dateCr";
            dateCr.Size = new Size(181, 31);
            dateCr.TabIndex = 3;
            // 
            // txtSolde
            // 
            txtSolde.Location = new Point(571, 61);
            txtSolde.Name = "txtSolde";
            txtSolde.Size = new Size(154, 31);
            txtSolde.TabIndex = 4;
            // 
            // comboClient
            // 
            comboClient.FormattingEnabled = true;
            comboClient.Location = new Point(202, 134);
            comboClient.Name = "comboClient";
            comboClient.Size = new Size(195, 33);
            comboClient.TabIndex = 5;
            // 
            // gridCompte
            // 
            gridCompte.AllowUserToAddRows = false;
            gridCompte.AllowUserToDeleteRows = false;
            gridCompte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCompte.Location = new Point(57, 212);
            gridCompte.Name = "gridCompte";
            gridCompte.ReadOnly = true;
            gridCompte.RowHeadersWidth = 62;
            gridCompte.Size = new Size(724, 159);
            gridCompte.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(455, 132);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(gridCompte);
            Controls.Add(comboClient);
            Controls.Add(txtSolde);
            Controls.Add(dateCr);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "  Comptes";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)gridCompte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateCr;
        private TextBox txtSolde;
        private ComboBox comboClient;
        private DataGridView gridCompte;
        private Button button1;
    }
}