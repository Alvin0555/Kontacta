namespace Kontacta
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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            panel1 = new Panel();
            txtLastName = new TextBox();
            lblLastName = new Label();
            textBox1 = new TextBox();
            lblEmail = new Label();
            lblGender = new Label();
            cBoxGender = new ComboBox();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtCOntactAddress = new TextBox();
            lblContactAddress = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            BtnPrint = new Button();
            dgvCobtactList = new DataGridView();
            txtCherche = new TextBox();
            lblSearch = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCobtactList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(411, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 0;
            label1.Text = "Contacts";
            label1.Click += label1_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(16, 86);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(103, 23);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(16, 113);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(313, 30);
            txtFirstName.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(16, 12);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 48);
            panel1.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(364, 113);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(313, 30);
            txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(364, 86);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(102, 23);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(703, 113);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 30);
            textBox1.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(703, 86);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 23);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(16, 170);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(103, 23);
            lblGender.TabIndex = 8;
            lblGender.Text = "First Name";
            // 
            // cBoxGender
            // 
            cBoxGender.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxGender.FormattingEnabled = true;
            cBoxGender.Items.AddRange(new object[] { "Female", "Male" });
            cBoxGender.Location = new Point(20, 196);
            cBoxGender.Name = "cBoxGender";
            cBoxGender.Size = new Size(309, 30);
            cBoxGender.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(364, 196);
            txtPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(313, 30);
            txtPhoneNumber.TabIndex = 11;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(364, 169);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(134, 23);
            lblPhoneNumber.TabIndex = 10;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtCOntactAddress
            // 
            txtCOntactAddress.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCOntactAddress.Location = new Point(703, 196);
            txtCOntactAddress.Margin = new Padding(4, 3, 4, 3);
            txtCOntactAddress.Name = "txtCOntactAddress";
            txtCOntactAddress.Size = new Size(313, 30);
            txtCOntactAddress.TabIndex = 13;
            // 
            // lblContactAddress
            // 
            lblContactAddress.AutoSize = true;
            lblContactAddress.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactAddress.Location = new Point(703, 169);
            lblContactAddress.Margin = new Padding(4, 0, 4, 0);
            lblContactAddress.Name = "lblContactAddress";
            lblContactAddress.Size = new Size(78, 23);
            lblContactAddress.TabIndex = 12;
            lblContactAddress.Text = "Address";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(20, 259);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 31);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(128, 259);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 31);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(236, 259);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 31);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.InfoText;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.ButtonHighlight;
            btnReset.Location = new Point(340, 259);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 31);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // BtnPrint
            // 
            BtnPrint.BackColor = SystemColors.InfoText;
            BtnPrint.FlatStyle = FlatStyle.Flat;
            BtnPrint.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrint.ForeColor = SystemColors.ButtonHighlight;
            BtnPrint.Location = new Point(445, 259);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(101, 31);
            BtnPrint.TabIndex = 18;
            BtnPrint.Text = "Print List";
            BtnPrint.UseVisualStyleBackColor = false;
            // 
            // dgvCobtactList
            // 
            dgvCobtactList.BackgroundColor = SystemColors.ActiveCaption;
            dgvCobtactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCobtactList.Location = new Point(2, 332);
            dgvCobtactList.Name = "dgvCobtactList";
            dgvCobtactList.RowHeadersWidth = 51;
            dgvCobtactList.Size = new Size(1097, 370);
            dgvCobtactList.TabIndex = 19;
            // 
            // txtCherche
            // 
            txtCherche.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCherche.Location = new Point(786, 296);
            txtCherche.Margin = new Padding(4, 3, 4, 3);
            txtCherche.Name = "txtCherche";
            txtCherche.Size = new Size(313, 30);
            txtCherche.TabIndex = 21;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(710, 303);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 23);
            lblSearch.TabIndex = 20;
            lblSearch.Text = "Search";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1100, 703);
            Controls.Add(txtCherche);
            Controls.Add(lblSearch);
            Controls.Add(dgvCobtactList);
            Controls.Add(BtnPrint);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCOntactAddress);
            Controls.Add(lblContactAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(cBoxGender);
            Controls.Add(lblGender);
            Controls.Add(textBox1);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(panel1);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCobtactList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Panel panel1;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox textBox1;
        private Label lblEmail;
        private Label lblGender;
        private ComboBox cBoxGender;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtCOntactAddress;
        private Label lblContactAddress;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
        private Button BtnPrint;
        private DataGridView dgvCobtactList;
        private TextBox txtCherche;
        private Label lblSearch;
    }
}
