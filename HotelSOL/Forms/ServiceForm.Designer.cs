namespace HotelSOL.Forms
{
    partial class ServiceForm
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
            buttonSearch = new Button();
            groupBox4 = new GroupBox();
            radioButtonIdentity = new RadioButton();
            label1 = new Label();
            groupBox5 = new GroupBox();
            dataGridViewSeaarchResult = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewAllServices = new DataGridView();
            groupBox3 = new GroupBox();
            buttonExport = new Button();
            textBoxPrice = new TextBox();
            textBoxService = new TextBox();
            buttonInsertUser = new Button();
            buttonUpdateUser = new Button();
            buttonDeleteUser = new Button();
            textBoxServerId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllServices).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1328, 212);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Rooms";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.ActiveCaption;
            buttonSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(1000, 161);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(131, 45);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonIdentity);
            groupBox4.Location = new Point(34, 73);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1097, 72);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search by";
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 39);
            label1.Name = "label1";
            label1.Size = new Size(217, 31);
            label1.TabIndex = 1;
            label1.Text = "Search Service by id";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewSeaarchResult);
            groupBox5.Location = new Point(12, 230);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(624, 269);
            groupBox5.TabIndex = 9;
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
            groupBox2.Controls.Add(dataGridViewAllServices);
            groupBox2.Location = new Point(672, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 269);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Al Services";
            // 
            // dataGridViewAllServices
            // 
            dataGridViewAllServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllServices.Location = new Point(27, 35);
            dataGridViewAllServices.Name = "dataGridViewAllServices";
            dataGridViewAllServices.RowHeadersWidth = 51;
            dataGridViewAllServices.Size = new Size(566, 207);
            dataGridViewAllServices.TabIndex = 2;
            dataGridViewAllServices.CellContentClick += dataGridViewAllServices_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonExport);
            groupBox3.Controls.Add(textBoxPrice);
            groupBox3.Controls.Add(textBoxService);
            groupBox3.Controls.Add(buttonInsertUser);
            groupBox3.Controls.Add(buttonUpdateUser);
            groupBox3.Controls.Add(buttonDeleteUser);
            groupBox3.Controls.Add(textBoxServerId);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 13.8F);
            groupBox3.Location = new Point(12, 518);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1278, 371);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Service Details";
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
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 13.8F);
            textBoxPrice.Location = new Point(187, 137);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(1067, 38);
            textBoxPrice.TabIndex = 14;
            // 
            // textBoxService
            // 
            textBoxService.Font = new Font("Segoe UI", 13.8F);
            textBoxService.Location = new Point(187, 89);
            textBoxService.Name = "textBoxService";
            textBoxService.Size = new Size(1067, 38);
            textBoxService.TabIndex = 13;
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
            // 
            // textBoxServerId
            // 
            textBoxServerId.Font = new Font("Segoe UI", 13.8F);
            textBoxServerId.Location = new Point(187, 39);
            textBoxServerId.Name = "textBoxServerId";
            textBoxServerId.Size = new Size(1067, 38);
            textBoxServerId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(9, 131);
            label4.Name = "label4";
            label4.Size = new Size(136, 31);
            label4.TabIndex = 2;
            label4.Text = "ServicePrice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(6, 89);
            label3.Name = "label3";
            label3.Size = new Size(86, 31);
            label3.TabIndex = 1;
            label3.Text = "Service";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(6, 41);
            label2.Name = "label2";
            label2.Size = new Size(112, 31);
            label2.TabIndex = 0;
            label2.Text = "Service Id";
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 949);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Name = "ServiceForm";
            Text = "Service";
            Load += ServiceForm_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllServices).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private RadioButton radioButtonIdentity;
        private Label label1;
        private GroupBox groupBox5;
        private DataGridView dataGridViewSeaarchResult;
        private GroupBox groupBox2;
        private DataGridView dataGridViewAllServices;
        private GroupBox groupBox3;
        private Button buttonExport;
        private TextBox textBoxPrice;
        private TextBox textBoxService;
        private Button buttonInsertUser;
        private Button buttonUpdateUser;
        private Button buttonDeleteUser;
        private TextBox textBoxServerId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonSearch;
    }
}