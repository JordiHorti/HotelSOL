﻿namespace HotelSOL
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
            label7 = new Label();
            label6 = new Label();
            textBoxRoomBooked = new TextBox();
            textBoxRoomPrice = new TextBox();
            buttonInsertCust = new Button();
            button3 = new Button();
            buttonDeleteCust = new Button();
            textBoxRoomType = new TextBox();
            textBoxRommNo = new TextBox();
            textBoxRoomId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            groupBox1.Location = new Point(10, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1162, 159);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Rooms";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonPhone);
            groupBox4.Controls.Add(radioButtonName);
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
            // radioButtonPhone
            // 
            radioButtonPhone.AutoSize = true;
            radioButtonPhone.Location = new Point(760, 21);
            radioButtonPhone.Margin = new Padding(3, 2, 3, 2);
            radioButtonPhone.Name = "radioButtonPhone";
            radioButtonPhone.Size = new Size(97, 19);
            radioButtonPhone.TabIndex = 3;
            radioButtonPhone.TabStop = true;
            radioButtonPhone.Text = "By availability";
            radioButtonPhone.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            radioButtonName.AutoSize = true;
            radioButtonName.Location = new Point(490, 20);
            radioButtonName.Margin = new Padding(3, 2, 3, 2);
            radioButtonName.Name = "radioButtonName";
            radioButtonName.Size = new Size(64, 19);
            radioButtonName.TabIndex = 1;
            radioButtonName.TabStop = true;
            radioButtonName.Text = "By type";
            radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonIdentity
            // 
            radioButtonIdentity.AutoSize = true;
            radioButtonIdentity.Location = new Point(164, 21);
            radioButtonIdentity.Margin = new Padding(3, 2, 3, 2);
            radioButtonIdentity.Name = "radioButtonIdentity";
            radioButtonIdentity.Size = new Size(88, 19);
            radioButtonIdentity.TabIndex = 0;
            radioButtonIdentity.TabStop = true;
            radioButtonIdentity.Text = "By Indentity";
            radioButtonIdentity.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1026, 109);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(115, 34);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(317, 25);
            label1.TabIndex = 1;
            label1.Text = "Search room by type and availability";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(30, 66);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1117, 32);
            textBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewSeaarchResult);
            groupBox5.Location = new Point(41, 172);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(546, 202);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search Results";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllCustomers);
            groupBox2.Location = new Point(612, 172);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(540, 202);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Al Rooms";
            groupBox2.Enter += groupBox2_Enter;
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
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBoxRoomBooked);
            groupBox3.Controls.Add(textBoxRoomPrice);
            groupBox3.Controls.Add(buttonInsertCust);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(buttonDeleteCust);
            groupBox3.Controls.Add(textBoxRoomType);
            groupBox3.Controls.Add(textBoxRommNo);
            groupBox3.Controls.Add(textBoxRoomId);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 13.8F);
            groupBox3.Location = new Point(41, 386);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(1118, 278);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Room Details";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.Location = new Point(5, 162);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 13;
            label7.Text = "Booked";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(8, 132);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 12;
            label6.Text = "Price";
            // 
            // textBoxRoomBooked
            // 
            textBoxRoomBooked.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomBooked.Location = new Point(164, 160);
            textBoxRoomBooked.Margin = new Padding(3, 2, 3, 2);
            textBoxRoomBooked.Name = "textBoxRoomBooked";
            textBoxRoomBooked.Size = new Size(934, 32);
            textBoxRoomBooked.TabIndex = 11;
            // 
            // textBoxRoomPrice
            // 
            textBoxRoomPrice.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomPrice.Location = new Point(164, 127);
            textBoxRoomPrice.Margin = new Padding(3, 2, 3, 2);
            textBoxRoomPrice.Name = "textBoxRoomPrice";
            textBoxRoomPrice.Size = new Size(934, 32);
            textBoxRoomPrice.TabIndex = 10;
            // 
            // buttonInsertCust
            // 
            buttonInsertCust.BackColor = SystemColors.ActiveCaption;
            buttonInsertCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInsertCust.Location = new Point(724, 227);
            buttonInsertCust.Margin = new Padding(3, 2, 3, 2);
            buttonInsertCust.Name = "buttonInsertCust";
            buttonInsertCust.Size = new Size(115, 34);
            buttonInsertCust.TabIndex = 9;
            buttonInsertCust.Text = "Insert";
            buttonInsertCust.UseVisualStyleBackColor = false;
            buttonInsertCust.Click += buttonInsertCust_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(852, 227);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(115, 34);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteCust
            // 
            buttonDeleteCust.BackColor = SystemColors.ActiveCaption;
            buttonDeleteCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteCust.Location = new Point(983, 227);
            buttonDeleteCust.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteCust.Name = "buttonDeleteCust";
            buttonDeleteCust.Size = new Size(115, 34);
            buttonDeleteCust.TabIndex = 3;
            buttonDeleteCust.Text = "Delete";
            buttonDeleteCust.UseVisualStyleBackColor = false;
            // 
            // textBoxRoomType
            // 
            textBoxRoomType.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomType.Location = new Point(164, 94);
            textBoxRoomType.Margin = new Padding(3, 2, 3, 2);
            textBoxRoomType.Name = "textBoxRoomType";
            textBoxRoomType.Size = new Size(934, 32);
            textBoxRoomType.TabIndex = 6;
            // 
            // textBoxRommNo
            // 
            textBoxRommNo.Font = new Font("Segoe UI", 13.8F);
            textBoxRommNo.Location = new Point(164, 63);
            textBoxRommNo.Margin = new Padding(3, 2, 3, 2);
            textBoxRommNo.Name = "textBoxRommNo";
            textBoxRommNo.Size = new Size(934, 32);
            textBoxRommNo.TabIndex = 5;
            // 
            // textBoxRoomId
            // 
            textBoxRoomId.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomId.Location = new Point(164, 29);
            textBoxRoomId.Margin = new Padding(3, 2, 3, 2);
            textBoxRoomId.Name = "textBoxRoomId";
            textBoxRoomId.Size = new Size(934, 32);
            textBoxRoomId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(8, 99);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 2;
            label4.Text = "Romm type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(5, 68);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 1;
            label3.Text = "Room Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(5, 32);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 0;
            label2.Text = "Room ID";
            label2.Click += label2_Click;
            // 
            // RoomsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 680);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RoomsForm";
            Text = "RoomsForm";
            Load += RoomsForm_Load;
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
        private TextBox textBoxRoomType;
        private TextBox textBoxRommNo;
        private TextBox textBoxRoomId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private TextBox textBoxRoomBooked;
        private TextBox textBoxRoomPrice;
    }
}