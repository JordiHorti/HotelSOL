namespace HotelSOL
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 76);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(773, 45);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Hotel SOL Management System";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(155, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 357);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please login to coniue";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(197, 281);
            button1.Name = "button1";
            button1.Size = new Size(420, 40);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(197, 201);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(420, 34);
            textBoxPassword.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(197, 90);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(420, 34);
            textBoxUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 201);
            label3.Name = "label3";
            label3.Size = new Size(137, 35);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 90);
            label2.Name = "label2";
            label2.Size = new Size(141, 35);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(24F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 704);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(9, 7, 9, 7);
            Name = "Form1";
            Text = "Hotel Management System Login";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button button1;
    }
}
