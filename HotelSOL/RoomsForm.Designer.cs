namespace HotelSOL
{
    partial class RoomsForm
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
            radioButtonPhone = new RadioButton();
            radioButtonName = new RadioButton();
            radioButtonIdentity = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox5 = new GroupBox();
            dataGridViewSeaarchResult = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewAllCustomers = new DataGridView();
            groupBox3 = new GroupBox();
            buttonInsertCust = new Button();
            button3 = new Button();
            buttonDeleteCust = new Button();
            textBoxCustId = new TextBox();
            textCustEmail = new TextBox();
            textCustConNO = new TextBox();
            textBoxCustName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllCustomers).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1328, 212);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Rooms";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonPhone);
            groupBox4.Controls.Add(radioButtonName);
            groupBox4.Controls.Add(radioButtonIdentity);
            groupBox4.Location = new Point(35, 132);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1097, 72);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search by";
            // 
            // radioButtonPhone
            // 
            radioButtonPhone.AutoSize = true;
            radioButtonPhone.Location = new Point(869, 28);
            radioButtonPhone.Name = "radioButtonPhone";
            radioButtonPhone.Size = new Size(122, 24);
            radioButtonPhone.TabIndex = 3;
            radioButtonPhone.TabStop = true;
            radioButtonPhone.Text = "By availability";
            radioButtonPhone.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            radioButtonName.AutoSize = true;
            radioButtonName.Location = new Point(560, 26);
            radioButtonName.Name = "radioButtonName";
            radioButtonName.Size = new Size(79, 24);
            radioButtonName.TabIndex = 1;
            radioButtonName.TabStop = true;
            radioButtonName.Text = "By type";
            radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonIdentity
            // 
            radioButtonIdentity.AutoSize = true;
            radioButtonIdentity.Location = new Point(187, 28);
            radioButtonIdentity.Name = "radioButtonIdentity";
            radioButtonIdentity.Size = new Size(108, 24);
            radioButtonIdentity.TabIndex = 0;
            radioButtonIdentity.TabStop = true;
            radioButtonIdentity.Text = "By Indentity";
            radioButtonIdentity.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1173, 145);
            button1.Name = "button1";
            button1.Size = new Size(131, 46);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(385, 31);
            label1.TabIndex = 1;
            label1.Text = "Search room by type and availability";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(34, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1276, 38);
            textBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewSeaarchResult);
            groupBox5.Location = new Point(47, 230);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(624, 270);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search Results";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllCustomers);
            groupBox2.Location = new Point(699, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 270);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Al Rooms";
            // 
            // dataGridViewAllCustomers
            // 
            dataGridViewAllCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllCustomers.Location = new Point(27, 35);
            dataGridViewAllCustomers.Name = "dataGridViewAllCustomers";
            dataGridViewAllCustomers.RowHeadersWidth = 51;
            dataGridViewAllCustomers.Size = new Size(566, 207);
            dataGridViewAllCustomers.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(buttonInsertCust);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(buttonDeleteCust);
            groupBox3.Controls.Add(textBoxCustId);
            groupBox3.Controls.Add(textCustEmail);
            groupBox3.Controls.Add(textCustConNO);
            groupBox3.Controls.Add(textBoxCustName);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 13.8F);
            groupBox3.Location = new Point(47, 515);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1278, 370);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Room Details";
            // 
            // buttonInsertCust
            // 
            buttonInsertCust.BackColor = SystemColors.ActiveCaption;
            buttonInsertCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInsertCust.Location = new Point(830, 318);
            buttonInsertCust.Name = "buttonInsertCust";
            buttonInsertCust.Size = new Size(131, 46);
            buttonInsertCust.TabIndex = 9;
            buttonInsertCust.Text = "Insert";
            buttonInsertCust.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(977, 318);
            button3.Name = "button3";
            button3.Size = new Size(131, 46);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteCust
            // 
            buttonDeleteCust.BackColor = SystemColors.ActiveCaption;
            buttonDeleteCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteCust.Location = new Point(1123, 318);
            buttonDeleteCust.Name = "buttonDeleteCust";
            buttonDeleteCust.Size = new Size(131, 46);
            buttonDeleteCust.TabIndex = 3;
            buttonDeleteCust.Text = "Delete";
            buttonDeleteCust.UseVisualStyleBackColor = false;
            // 
            // textBoxCustId
            // 
            textBoxCustId.Font = new Font("Segoe UI", 13.8F);
            textBoxCustId.Location = new Point(187, 167);
            textBoxCustId.Name = "textBoxCustId";
            textBoxCustId.Size = new Size(1067, 38);
            textBoxCustId.TabIndex = 7;
            // 
            // textCustEmail
            // 
            textCustEmail.Font = new Font("Segoe UI", 13.8F);
            textCustEmail.Location = new Point(187, 125);
            textCustEmail.Name = "textCustEmail";
            textCustEmail.Size = new Size(1067, 38);
            textCustEmail.TabIndex = 6;
            // 
            // textCustConNO
            // 
            textCustConNO.Font = new Font("Segoe UI", 13.8F);
            textCustConNO.Location = new Point(187, 84);
            textCustConNO.Name = "textCustConNO";
            textCustConNO.Size = new Size(1067, 38);
            textCustConNO.TabIndex = 5;
            // 
            // textBoxCustName
            // 
            textBoxCustName.Font = new Font("Segoe UI", 13.8F);
            textBoxCustName.Location = new Point(187, 39);
            textBoxCustName.Name = "textBoxCustName";
            textBoxCustName.Size = new Size(1067, 38);
            textBoxCustName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(6, 174);
            label5.Name = "label5";
            label5.Size = new Size(53, 31);
            label5.TabIndex = 3;
            label5.Text = "Bed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(9, 132);
            label4.Name = "label4";
            label4.Size = new Size(131, 31);
            label4.TabIndex = 2;
            label4.Text = "Romm type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(163, 31);
            label3.TabIndex = 1;
            label3.Text = "Room Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(101, 31);
            label2.TabIndex = 0;
            label2.Text = "Room ID";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F);
            textBox2.Location = new Point(187, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1067, 38);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F);
            textBox3.Location = new Point(187, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1067, 38);
            textBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(6, 218);
            label6.Name = "label6";
            label6.Size = new Size(64, 31);
            label6.TabIndex = 12;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.Location = new Point(6, 262);
            label7.Name = "label7";
            label7.Size = new Size(90, 31);
            label7.TabIndex = 13;
            label7.Text = "Booked";
            label7.Click += label7_Click;
            // 
            // RoomsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 906);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Name = "RoomsForm";
            Text = "RoomsForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllCustomers).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private RadioButton radioButtonPhone;
        private RadioButton radioButtonName;
        private RadioButton radioButtonIdentity;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox5;
        private DataGridView dataGridViewSeaarchResult;
        private GroupBox groupBox2;
        private DataGridView dataGridViewAllCustomers;
        private GroupBox groupBox3;
        private Button buttonInsertCust;
        private Button button3;
        private Button buttonDeleteCust;
        private TextBox textBoxCustId;
        private TextBox textCustEmail;
        private TextBox textCustConNO;
        private TextBox textBoxCustName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}