namespace HotelSOL
{
    partial class CustomersForm
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
            buttonSearchCust = new Button();
            label1 = new Label();
            textBoxSearch = new TextBox();
            dataGridViewSeaarchResult = new DataGridView();
            dataGridViewAllCustomers = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            buttonInsertCust = new Button();
            buttonUpdateCust = new Button();
            buttonDeleteCust = new Button();
            textBoxCustId = new TextBox();
            textCustEmail = new TextBox();
            textCustConNO = new TextBox();
            textBoxCustName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox5 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllCustomers).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(buttonSearchCust);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1328, 212);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Customers";
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
            radioButtonPhone.Size = new Size(112, 24);
            radioButtonPhone.TabIndex = 3;
            radioButtonPhone.TabStop = true;
            radioButtonPhone.Text = "By Phone Nº";
            radioButtonPhone.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            radioButtonName.AutoSize = true;
            radioButtonName.Location = new Point(560, 26);
            radioButtonName.Name = "radioButtonName";
            radioButtonName.Size = new Size(90, 24);
            radioButtonName.TabIndex = 1;
            radioButtonName.TabStop = true;
            radioButtonName.Text = "By Name";
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
            // buttonSearchCust
            // 
            
            buttonSearchCust.BackColor = SystemColors.ActiveCaption;
            buttonSearchCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearchCust.Location = new Point(1173, 145);
            buttonSearchCust.Name = "buttonSearchCust";
            buttonSearchCust.Size = new Size(131, 46);
            buttonSearchCust.TabIndex = 2;
            buttonSearchCust.Text = "Search";
            buttonSearchCust.UseVisualStyleBackColor = false;
            buttonSearchCust.Click += buttonSearchCust_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(505, 31);
            label1.TabIndex = 1;
            label1.Text = "Search customers by ID,Name or Phone Number";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(34, 88);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(1276, 38);
            textBoxSearch.TabIndex = 0;
            // 
            // dataGridViewSeaarchResult
            // 
            dataGridViewSeaarchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSeaarchResult.Location = new Point(26, 35);
            dataGridViewSeaarchResult.Name = "dataGridViewSeaarchResult";
            dataGridViewSeaarchResult.RowHeadersWidth = 51;
            dataGridViewSeaarchResult.Size = new Size(569, 257);
            dataGridViewSeaarchResult.TabIndex = 1;
            // 
            // dataGridViewAllCustomers
            // 
            dataGridViewAllCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllCustomers.Location = new Point(27, 35);
            dataGridViewAllCustomers.Name = "dataGridViewAllCustomers";
            dataGridViewAllCustomers.RowHeadersWidth = 51;
            dataGridViewAllCustomers.Size = new Size(566, 257);
            dataGridViewAllCustomers.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllCustomers);
            groupBox2.Location = new Point(723, 244);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 320);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Al Customers";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonInsertCust);
            groupBox3.Controls.Add(buttonUpdateCust);
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
            groupBox3.Location = new Point(62, 570);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1278, 279);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Customer Details";
            // 
            // buttonInsertCust
            // 
            buttonInsertCust.BackColor = SystemColors.ActiveCaption;
            buttonInsertCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInsertCust.Location = new Point(819, 227);
            buttonInsertCust.Name = "buttonInsertCust";
            buttonInsertCust.Size = new Size(131, 46);
            buttonInsertCust.TabIndex = 9;
            buttonInsertCust.Text = "Insert";
            buttonInsertCust.UseVisualStyleBackColor = false;
            buttonInsertCust.Click += buttonInsertCust_Click;
            // 
            // buttonUpdateCust
            // 
            
            buttonUpdateCust.BackColor = SystemColors.ActiveCaption;
            buttonUpdateCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdateCust.Location = new Point(972, 227);
            buttonUpdateCust.Name = "buttonUpdateCust";
            buttonUpdateCust.Size = new Size(131, 46);
            buttonUpdateCust.TabIndex = 8;
            buttonUpdateCust.Text = "Update";
            buttonUpdateCust.UseVisualStyleBackColor = false;
            buttonUpdateCust.Click += buttonUpdateCust_Click;
            // 
            // buttonDeleteCust
            // 
            
            buttonDeleteCust.BackColor = SystemColors.ActiveCaption;
            buttonDeleteCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteCust.Location = new Point(1123, 227);
            buttonDeleteCust.Name = "buttonDeleteCust";
            buttonDeleteCust.Size = new Size(131, 46);
            buttonDeleteCust.TabIndex = 3;
            buttonDeleteCust.Text = "Delete";
            buttonDeleteCust.UseVisualStyleBackColor = false;
            buttonDeleteCust.Click += buttonDeleteCust_Click;
            // 
            // textBoxCustId
            // 
            textBoxCustId.Font = new Font("Segoe UI", 13.8F);
            textBoxCustId.Location = new Point(241, 167);
            textBoxCustId.Name = "textBoxCustId";
            textBoxCustId.Size = new Size(1013, 38);
            textBoxCustId.TabIndex = 7;
            // 
            // textCustEmail
            // 
            textCustEmail.Font = new Font("Segoe UI", 13.8F);
            textCustEmail.Location = new Point(241, 125);
            textCustEmail.Name = "textCustEmail";
            textCustEmail.Size = new Size(1013, 38);
            textCustEmail.TabIndex = 6;
            // 
            // textCustConNO
            // 
            textCustConNO.Font = new Font("Segoe UI", 13.8F);
            textCustConNO.Location = new Point(241, 84);
            textCustConNO.Name = "textCustConNO";
            textCustConNO.Size = new Size(1013, 38);
            textCustConNO.TabIndex = 5;
            // 
            // textBoxCustName
            // 
            textBoxCustName.Font = new Font("Segoe UI", 13.8F);
            textBoxCustName.Location = new Point(241, 39);
            textBoxCustName.Name = "textBoxCustName";
            textBoxCustName.Size = new Size(1013, 38);
            textBoxCustName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(6, 174);
            label5.Name = "label5";
            label5.Size = new Size(229, 31);
            label5.TabIndex = 3;
            label5.Text = "Customer Identity Nº";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(9, 132);
            label4.Name = "label4";
            label4.Size = new Size(174, 31);
            label4.TabIndex = 2;
            label4.Text = "Customer Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(9, 87);
            label3.Name = "label3";
            label3.Size = new Size(215, 31);
            label3.TabIndex = 1;
            label3.Text = "Customer Phone Nº";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(179, 31);
            label2.TabIndex = 0;
            label2.Text = "Customer Name";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewSeaarchResult);
            groupBox5.Location = new Point(62, 244);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(624, 320);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search Results";
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 904);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CustomersForm";
            Text = "CustomersForm";
            Load += CustomersForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllCustomers).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxSearch;
        private Button buttonSearchCust;
        private DataGridView dataGridViewSeaarchResult;
        private DataGridView dataGridViewAllCustomers;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonInsertCust;
        private Button buttonUpdateCust;
        private Button buttonDeleteCust;
        private TextBox textBoxCustId;
        private TextBox textCustEmail;
        private TextBox textCustConNO;
        private TextBox textBoxCustName;
        private GroupBox groupBox4;
        private RadioButton radioButton5;
        private RadioButton radioButtonPhone;
        private RadioButton radioButtonName;
        private RadioButton radioButtonIdentity;
        private GroupBox groupBox5;
    }
}