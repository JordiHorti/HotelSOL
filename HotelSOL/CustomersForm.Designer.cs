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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            buttonInsertCust = new Button();
            button3 = new Button();
            button2 = new Button();
            textBoxCustId = new TextBox();
            textCustEmail = new TextBox();
            textCustConNO = new TextBox();
            textBoxCustName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1328, 212);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Customers";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(635, 144);
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
            label1.Size = new Size(566, 31);
            label1.TabIndex = 1;
            label1.Text = "Search customers by ID,Name,Email or Phone Number";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(34, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1276, 38);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(21, 35);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(560, 257);
            dataGridView2.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(735, 244);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(605, 320);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Al Customers";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonInsertCust);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
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
            buttonInsertCust.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(972, 227);
            button3.Name = "button3";
            button3.Size = new Size(131, 46);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1123, 227);
            button2.Name = "button2";
            button2.Size = new Size(131, 46);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
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
            label3.Location = new Point(6, 91);
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
            label2.Click += label2_Click;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 904);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "CustomersForm";
            Text = "CustomersForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonInsertCust;
        private Button button3;
        private Button button2;
        private TextBox textBoxCustId;
        private TextBox textCustEmail;
        private TextBox textCustConNO;
        private TextBox textBoxCustName;
    }
}