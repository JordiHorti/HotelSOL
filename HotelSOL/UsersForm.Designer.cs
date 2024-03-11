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
            dataGridViewAllCustomers = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridViewSeaarchResult = new DataGridView();
            groupBox3 = new GroupBox();
            label6 = new Label();
            buttonInsertUser = new Button();
            buttonUpdateUser = new Button();
            buttonDeleteUser = new Button();
            textBoxUserId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            textBoxRole = new TextBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllCustomers).BeginInit();
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
            groupBox1.Location = new Point(12, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1162, 159);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Rooms";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonRole);
            groupBox4.Controls.Add(radioButtonUserName);
            groupBox4.Controls.Add(radioButtonIdentity);
            groupBox4.Location = new Point(31, 99);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(960, 54);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search by";
            // 
            // radioButtonRole
            // 
            radioButtonRole.AutoSize = true;
            radioButtonRole.Location = new Point(760, 20);
            radioButtonRole.Margin = new Padding(3, 2, 3, 2);
            radioButtonRole.Name = "radioButtonRole";
            radioButtonRole.Size = new Size(86, 19);
            radioButtonRole.TabIndex = 3;
            radioButtonRole.TabStop = true;
            radioButtonRole.Text = "By userRole";
            radioButtonRole.UseVisualStyleBackColor = true;
            radioButtonRole.CheckedChanged += radioButtonRole_CheckedChanged;
            // 
            // radioButtonUserName
            // 
            radioButtonUserName.AutoSize = true;
            radioButtonUserName.Location = new Point(490, 19);
            radioButtonUserName.Margin = new Padding(3, 2, 3, 2);
            radioButtonUserName.Name = "radioButtonUserName";
            radioButtonUserName.Size = new Size(93, 19);
            radioButtonUserName.TabIndex = 1;
            radioButtonUserName.TabStop = true;
            radioButtonUserName.Text = "By username";
            radioButtonUserName.UseVisualStyleBackColor = true;
            radioButtonUserName.CheckedChanged += radioButtonUserName_CheckedChanged;
            // 
            // radioButtonIdentity
            // 
            radioButtonIdentity.AutoSize = true;
            radioButtonIdentity.Location = new Point(164, 20);
            radioButtonIdentity.Margin = new Padding(3, 2, 3, 2);
            radioButtonIdentity.Name = "radioButtonIdentity";
            radioButtonIdentity.Size = new Size(88, 19);
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
            buttonSearch.Location = new Point(1026, 109);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(115, 34);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(310, 25);
            label1.TabIndex = 1;
            label1.Text = "Search User by type and availability";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(30, 66);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(1117, 32);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllCustomers);
            groupBox2.Location = new Point(613, 210);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(540, 202);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Al Users";
            // 
            // dataGridViewAllCustomers
            // 
            dataGridViewAllCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllCustomers.Location = new Point(24, 26);
            dataGridViewAllCustomers.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAllCustomers.Name = "dataGridViewAllCustomers";
            dataGridViewAllCustomers.RowHeadersWidth = 51;
            dataGridViewAllCustomers.Size = new Size(495, 155);
            dataGridViewAllCustomers.TabIndex = 2;
            dataGridViewAllCustomers.CellContentClick += dataGridViewAllCustomers_CellContentClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewSeaarchResult);
            groupBox5.Location = new Point(42, 210);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(546, 202);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search Results";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // dataGridViewSeaarchResult
            // 
            dataGridViewSeaarchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSeaarchResult.Location = new Point(23, 26);
            dataGridViewSeaarchResult.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSeaarchResult.Name = "dataGridViewSeaarchResult";
            dataGridViewSeaarchResult.RowHeadersWidth = 51;
            dataGridViewSeaarchResult.Size = new Size(498, 155);
            dataGridViewSeaarchResult.TabIndex = 1;
            // 
            // groupBox3
            // 
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
            groupBox3.Location = new Point(43, 447);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(1118, 278);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "User Details";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(8, 131);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 12;
            label6.Text = "User Role";
            // 
            // buttonInsertUser
            // 
            buttonInsertUser.BackColor = SystemColors.ActiveCaption;
            buttonInsertUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInsertUser.Location = new Point(724, 227);
            buttonInsertUser.Margin = new Padding(3, 2, 3, 2);
            buttonInsertUser.Name = "buttonInsertUser";
            buttonInsertUser.Size = new Size(115, 34);
            buttonInsertUser.TabIndex = 9;
            buttonInsertUser.Text = "Insert";
            buttonInsertUser.UseVisualStyleBackColor = false;
            buttonInsertUser.Click += buttonInsertUser_Click;
            // 
            // buttonUpdateUser
            // 
            buttonUpdateUser.BackColor = SystemColors.ActiveCaption;
            buttonUpdateUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdateUser.Location = new Point(852, 227);
            buttonUpdateUser.Margin = new Padding(3, 2, 3, 2);
            buttonUpdateUser.Name = "buttonUpdateUser";
            buttonUpdateUser.Size = new Size(115, 34);
            buttonUpdateUser.TabIndex = 8;
            buttonUpdateUser.Text = "Update";
            buttonUpdateUser.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.BackColor = SystemColors.ActiveCaption;
            buttonDeleteUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteUser.Location = new Point(983, 227);
            buttonDeleteUser.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(115, 34);
            buttonDeleteUser.TabIndex = 3;
            buttonDeleteUser.Text = "Delete";
            buttonDeleteUser.UseVisualStyleBackColor = false;
            // 
            // textBoxUserId
            // 
            textBoxUserId.Font = new Font("Segoe UI", 13.8F);
            textBoxUserId.Location = new Point(164, 29);
            textBoxUserId.Margin = new Padding(3, 2, 3, 2);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(934, 32);
            textBoxUserId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(8, 98);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(5, 67);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 1;
            label3.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(5, 31);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 0;
            label2.Text = "User ID";
            label2.Click += label2_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Font = new Font("Segoe UI", 13.8F);
            textBoxUserName.Location = new Point(164, 67);
            textBoxUserName.Margin = new Padding(3, 2, 3, 2);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(934, 32);
            textBoxUserName.TabIndex = 13;
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 13.8F);
            textBoxPassword.Location = new Point(164, 103);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(934, 32);
            textBoxPassword.TabIndex = 14;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxRole
            // 
            textBoxRole.Font = new Font("Segoe UI", 13.8F);
            textBoxRole.Location = new Point(164, 139);
            textBoxRole.Margin = new Padding(3, 2, 3, 2);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(934, 32);
            textBoxRole.TabIndex = 15;
            textBoxRole.TextChanged += textBoxRole_TextChanged;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1635, 773);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Name = "UsersForm";
            Text = "UsersForm";
            Load += UsersForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllCustomers).EndInit();
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
        private DataGridView dataGridViewAllCustomers;
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
    }
}