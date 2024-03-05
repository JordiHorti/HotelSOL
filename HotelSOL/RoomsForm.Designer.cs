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
            label7 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
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
            label7.Location = new Point(5, 196);
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
            label6.Location = new Point(5, 164);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 12;
            label6.Text = "Price";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F);
            textBox3.Location = new Point(164, 191);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(934, 32);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F);
            textBox2.Location = new Point(164, 158);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(934, 32);
            textBox2.TabIndex = 10;
            // 
            // buttonInsertCust
            // 
            buttonInsertCust.BackColor = SystemColors.ActiveCaption;
            buttonInsertCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInsertCust.Location = new Point(726, 238);
            buttonInsertCust.Margin = new Padding(3, 2, 3, 2);
            buttonInsertCust.Name = "buttonInsertCust";
            buttonInsertCust.Size = new Size(115, 34);
            buttonInsertCust.TabIndex = 9;
            buttonInsertCust.Text = "Insert";
            buttonInsertCust.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(855, 238);
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
            buttonDeleteCust.Location = new Point(983, 238);
            buttonDeleteCust.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteCust.Name = "buttonDeleteCust";
            buttonDeleteCust.Size = new Size(115, 34);
            buttonDeleteCust.TabIndex = 3;
            buttonDeleteCust.Text = "Delete";
            buttonDeleteCust.UseVisualStyleBackColor = false;
            // 
            // textBoxCustId
            // 
            textBoxCustId.Font = new Font("Segoe UI", 13.8F);
            textBoxCustId.Location = new Point(164, 125);
            textBoxCustId.Margin = new Padding(3, 2, 3, 2);
            textBoxCustId.Name = "textBoxCustId";
            textBoxCustId.Size = new Size(934, 32);
            textBoxCustId.TabIndex = 7;
            // 
            // textCustEmail
            // 
            textCustEmail.Font = new Font("Segoe UI", 13.8F);
            textCustEmail.Location = new Point(164, 94);
            textCustEmail.Margin = new Padding(3, 2, 3, 2);
            textCustEmail.Name = "textCustEmail";
            textCustEmail.Size = new Size(934, 32);
            textCustEmail.TabIndex = 6;
            // 
            // textCustConNO
            // 
            textCustConNO.Font = new Font("Segoe UI", 13.8F);
            textCustConNO.Location = new Point(164, 63);
            textCustConNO.Margin = new Padding(3, 2, 3, 2);
            textCustConNO.Name = "textCustConNO";
            textCustConNO.Size = new Size(934, 32);
            textCustConNO.TabIndex = 5;
            // 
            // textBoxCustName
            // 
            textBoxCustName.Font = new Font("Segoe UI", 13.8F);
            textBoxCustName.Location = new Point(164, 29);
            textBoxCustName.Margin = new Padding(3, 2, 3, 2);
            textBoxCustName.Name = "textBoxCustName";
            textBoxCustName.Size = new Size(934, 32);
            textBoxCustName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(5, 130);
            label5.Name = "label5";
            label5.Size = new Size(44, 25);
            label5.TabIndex = 3;
            label5.Text = "Bed";
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