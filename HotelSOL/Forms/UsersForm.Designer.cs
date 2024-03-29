namespace HotelSOL
{
    partial class UsersForm
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
            groupBox4 = new GroupBox();
            radioButtonRole = new RadioButton();
            radioButtonUserName = new RadioButton();
            radioButtonIdentity = new RadioButton();
            buttonSearch = new Button();
            label1 = new Label();
            textBoxSearch = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewAllUsers = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridViewSeaarchResult = new DataGridView();
            groupBox3 = new GroupBox();
            buttonExport = new Button();
            textBoxRole = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            label6 = new Label();
            buttonInsertUser = new Button();
            buttonUpdateUser = new Button();
            buttonDeleteUser = new Button();
            textBoxUserId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            buttonImportData = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllUsers).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(14, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1328, 212);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Rooms";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonRole);
            groupBox4.Controls.Add(radioButtonUserName);
            groupBox4.Controls.Add(radioButtonIdentity);
            groupBox4.Location = new Point(35, 132);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1097, 72);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search by";
            // 
            // radioButtonRole
            // 
            radioButtonRole.AutoSize = true;
            radioButtonRole.Location = new Point(869, 27);
            radioButtonRole.Name = "radioButtonRole";
            radioButtonRole.Size = new Size(107, 24);
            radioButtonRole.TabIndex = 3;
            radioButtonRole.TabStop = true;
            radioButtonRole.Text = "By userRole";
            radioButtonRole.UseVisualStyleBackColor = true;
            radioButtonRole.CheckedChanged += radioButtonRole_CheckedChanged;
            // 
            // radioButtonUserName
            // 
            radioButtonUserName.AutoSize = true;
            radioButtonUserName.Location = new Point(560, 25);
            radioButtonUserName.Name = "radioButtonUserName";
            radioButtonUserName.Size = new Size(114, 24);
            radioButtonUserName.TabIndex = 1;
            radioButtonUserName.TabStop = true;
            radioButtonUserName.Text = "By username";
            radioButtonUserName.UseVisualStyleBackColor = true;
            radioButtonUserName.CheckedChanged += radioButtonUserName_CheckedChanged;
            // 
            // radioButtonIdentity
            // 
            radioButtonIdentity.AutoSize = true;
            radioButtonIdentity.Location = new Point(187, 27);
            radioButtonIdentity.Name = "radioButtonIdentity";
            radioButtonIdentity.Size = new Size(108, 24);
            radioButtonIdentity.TabIndex = 0;
            radioButtonIdentity.TabStop = true;
            radioButtonIdentity.Text = "By Indentity";
            radioButtonIdentity.UseVisualStyleBackColor = true;
            radioButtonIdentity.CheckedChanged += radioButtonIdentity_CheckedChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.ActiveCaption;
            buttonSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(1173, 145);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(131, 45);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 39);
            label1.Name = "label1";
            label1.Size = new Size(377, 31);
            label1.TabIndex = 1;
            label1.Text = "Search User by type and availability";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(34, 88);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(1276, 38);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllUsers);
            groupBox2.Location = new Point(701, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 269);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Al Users";
            // 
            // dataGridViewAllUsers
            // 
            dataGridViewAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllUsers.Location = new Point(27, 35);
            dataGridViewAllUsers.Name = "dataGridViewAllUsers";
            dataGridViewAllUsers.RowHeadersWidth = 51;
            dataGridViewAllUsers.Size = new Size(566, 207);
            dataGridViewAllUsers.TabIndex = 2;
            dataGridViewAllUsers.CellContentClick += dataGridViewAllCustomers_CellContentClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewSeaarchResult);
            groupBox5.Location = new Point(48, 280);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(624, 269);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search Results";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // dataGridViewSeaarchResult
            // 
            dataGridViewSeaarchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSeaarchResult.Location = new Point(26, 35);
            dataGridViewSeaarchResult.Name = "dataGridViewSeaarchResult";
            dataGridViewSeaarchResult.RowHeadersWidth = 51;
            dataGridViewSeaarchResult.Size = new Size(569, 207);
            dataGridViewSeaarchResult.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonImportData);
            groupBox3.Controls.Add(buttonExport);
            groupBox3.Controls.Add(textBoxRole);
            groupBox3.Controls.Add(textBoxPassword);
            groupBox3.Controls.Add(textBoxUserName);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(buttonInsertUser);
            groupBox3.Controls.Add(buttonUpdateUser);
            groupBox3.Controls.Add(buttonDeleteUser);
            groupBox3.Controls.Add(textBoxUserId);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 13.8F);
            groupBox3.Location = new Point(49, 596);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1278, 371);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "User Details";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // buttonExport
            // 
            buttonExport.BackColor = SystemColors.ActiveCaption;
            buttonExport.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExport.Location = new Point(25, 302);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(131, 46);
            buttonExport.TabIndex = 16;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // textBoxRole
            // 
            textBoxRole.Font = new Font("Segoe UI", 13.8F);
            textBoxRole.Location = new Point(187, 185);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(1067, 38);
            textBoxRole.TabIndex = 15;
            textBoxRole.TextChanged += textBoxRole_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 13.8F);
            textBoxPassword.Location = new Point(187, 137);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(1067, 38);
            textBoxPassword.TabIndex = 14;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Font = new Font("Segoe UI", 13.8F);
            textBoxUserName.Location = new Point(187, 89);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(1067, 38);
            textBoxUserName.TabIndex = 13;
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(9, 175);
            label6.Name = "label6";
            label6.Size = new Size(110, 31);
            label6.TabIndex = 12;
            label6.Text = "User Role";
            // 
            // buttonInsertUser
            // 
            buttonInsertUser.BackColor = SystemColors.ActiveCaption;
            buttonInsertUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInsertUser.Location = new Point(827, 303);
            buttonInsertUser.Name = "buttonInsertUser";
            buttonInsertUser.Size = new Size(131, 45);
            buttonInsertUser.TabIndex = 9;
            buttonInsertUser.Text = "Insert";
            buttonInsertUser.UseVisualStyleBackColor = false;
            buttonInsertUser.Click += buttonInsertUser_Click;
            // 
            // buttonUpdateUser
            // 
            buttonUpdateUser.BackColor = SystemColors.ActiveCaption;
            buttonUpdateUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdateUser.Location = new Point(974, 303);
            buttonUpdateUser.Name = "buttonUpdateUser";
            buttonUpdateUser.Size = new Size(131, 45);
            buttonUpdateUser.TabIndex = 8;
            buttonUpdateUser.Text = "Update";
            buttonUpdateUser.UseVisualStyleBackColor = false;
            buttonUpdateUser.Click += buttonUpdateUser_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.BackColor = SystemColors.ActiveCaption;
            buttonDeleteUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteUser.Location = new Point(1123, 303);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(131, 45);
            buttonDeleteUser.TabIndex = 3;
            buttonDeleteUser.Text = "Delete";
            buttonDeleteUser.UseVisualStyleBackColor = false;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // textBoxUserId
            // 
            textBoxUserId.Font = new Font("Segoe UI", 13.8F);
            textBoxUserId.Location = new Point(187, 39);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(1067, 38);
            textBoxUserId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(9, 131);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(6, 89);
            label3.Name = "label3";
            label3.Size = new Size(127, 31);
            label3.TabIndex = 1;
            label3.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(6, 41);
            label2.Name = "label2";
            label2.Size = new Size(88, 31);
            label2.TabIndex = 0;
            label2.Text = "User ID";
            label2.Click += label2_Click;
            // 
            // buttonImportData
            // 
            buttonImportData.BackColor = SystemColors.ActiveCaption;
            buttonImportData.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonImportData.Location = new Point(245, 302);
            buttonImportData.Name = "buttonImportData";
            buttonImportData.Size = new Size(154, 46);
            buttonImportData.TabIndex = 17;
            buttonImportData.Text = "ImportData";
            buttonImportData.UseVisualStyleBackColor = false;
            buttonImportData.Click += buttonImportData_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1869, 1031);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsersForm";
            Text = "UsersForm";
            Load += UsersForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllUsers).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private RadioButton radioButtonRole;
        private RadioButton radioButtonUserName;
        private RadioButton radioButtonIdentity;
        private Button buttonSearch;
        private Label label1;
        private TextBox textBoxSearch;
        private GroupBox groupBox2;
        private DataGridView dataGridViewAllUsers;
        private GroupBox groupBox5;
        private DataGridView dataGridViewSeaarchResult;
        private GroupBox groupBox3;
        private Label label7;
        private Label label6;
        private TextBox textBoxRoomBooked;
        private TextBox textBoxRoomPrice;
        private Button buttonInsertUser;
        private Button buttonUpdateUser;
        private Button buttonDeleteUser;
        private TextBox textBoxRoomType;
        private TextBox textBoxRommNo;
        private TextBox textBoxUserId;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxRole;
        private TextBox textBoxPassword;
        private TextBox textBoxUserName;
        private Button buttonExport;
        private Button buttonImportData;
    }
}