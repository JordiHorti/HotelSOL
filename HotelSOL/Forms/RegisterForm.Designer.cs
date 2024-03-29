namespace HotelSOL.Forms
{
    partial class RegisterForm
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
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            buttonInsertCust = new Button();
            textCustomerPassword = new TextBox();
            textCustomerPhone = new TextBox();
            textCustomerEmail = new TextBox();
            textBoxCustomerName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(6, 128);
            label3.Name = "label3";
            label3.Size = new Size(168, 31);
            label3.TabIndex = 1;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(buttonInsertCust);
            groupBox3.Controls.Add(textCustomerPassword);
            groupBox3.Controls.Add(textCustomerPhone);
            groupBox3.Controls.Add(textCustomerEmail);
            groupBox3.Controls.Add(textBoxCustomerName);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 13.8F);
            groupBox3.Location = new Point(58, 37);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1286, 290);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Customer Details";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(904, 227);
            button1.Name = "button1";
            button1.Size = new Size(131, 44);
            button1.TabIndex = 6;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonInsertCust
            // 
            buttonInsertCust.BackColor = SystemColors.ActiveCaption;
            buttonInsertCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInsertCust.Location = new Point(1123, 227);
            buttonInsertCust.Name = "buttonInsertCust";
            buttonInsertCust.Size = new Size(131, 46);
            buttonInsertCust.TabIndex = 9;
            buttonInsertCust.Text = "Insert";
            buttonInsertCust.UseVisualStyleBackColor = false;
            buttonInsertCust.Click += buttonInsertCust_Click;
            // 
            // textCustomerPassword
            // 
            textCustomerPassword.Font = new Font("Segoe UI", 13.8F);
            textCustomerPassword.Location = new Point(241, 167);
            textCustomerPassword.Name = "textCustomerPassword";
            textCustomerPassword.Size = new Size(1013, 38);
            textCustomerPassword.TabIndex = 7;
            // 
            // textCustomerPhone
            // 
            textCustomerPhone.Font = new Font("Segoe UI", 13.8F);
            textCustomerPhone.Location = new Point(241, 125);
            textCustomerPhone.Name = "textCustomerPhone";
            textCustomerPhone.Size = new Size(1013, 38);
            textCustomerPhone.TabIndex = 6;
            // 
            // textCustomerEmail
            // 
            textCustomerEmail.Font = new Font("Segoe UI", 13.8F);
            textCustomerEmail.Location = new Point(241, 84);
            textCustomerEmail.Name = "textCustomerEmail";
            textCustomerEmail.Size = new Size(1013, 38);
            textCustomerEmail.TabIndex = 5;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Font = new Font("Segoe UI", 13.8F);
            textBoxCustomerName.Location = new Point(241, 39);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(1013, 38);
            textBoxCustomerName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(6, 174);
            label5.Name = "label5";
            label5.Size = new Size(110, 31);
            label5.TabIndex = 3;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(6, 84);
            label4.Name = "label4";
            label4.Size = new Size(70, 31);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 333);
            Controls.Add(groupBox3);
            Name = "registerForm";
            Text = "registerForm";
            Load += registerForm_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private Button buttonInsertCust;
        private TextBox textCustomerPassword;
        private TextBox textCustomerPhone;
        private TextBox textCustomerEmail;
        private TextBox textBoxCustomerName;
        private Label label5;
        private Label label4;
        private Button button1;
    }
}