namespace HotelSOL.Forms
{
    partial class InvoiceForm
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
            label1 = new Label();
            textBoxSearch = new TextBox();
            radioButtonIdentity = new RadioButton();
            dataGridViewAllInvoices = new DataGridView();
            groupBox5 = new GroupBox();
            radioButtonCustomerEmail = new RadioButton();
            radioButtonCustomerName = new RadioButton();
            buttonExport = new Button();
            buttonSearch = new Button();
            buttonImportData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllInvoices).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(552, 31);
            label1.TabIndex = 10;
            label1.Text = "Search Invoice by Id, CustomerName, CustomerEmail";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(12, 53);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(1276, 38);
            textBoxSearch.TabIndex = 8;
            // 
            // radioButtonIdentity
            // 
            radioButtonIdentity.AutoSize = true;
            radioButtonIdentity.Location = new Point(205, 111);
            radioButtonIdentity.Name = "radioButtonIdentity";
            radioButtonIdentity.Size = new Size(114, 24);
            radioButtonIdentity.TabIndex = 9;
            radioButtonIdentity.TabStop = true;
            radioButtonIdentity.Text = "By Invoice Id";
            radioButtonIdentity.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAllInvoices
            // 
            dataGridViewAllInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllInvoices.Location = new Point(29, 35);
            dataGridViewAllInvoices.Name = "dataGridViewAllInvoices";
            dataGridViewAllInvoices.RowHeadersWidth = 51;
            dataGridViewAllInvoices.Size = new Size(1222, 391);
            dataGridViewAllInvoices.TabIndex = 1;
            dataGridViewAllInvoices.CellContentClick += dataGridViewAllInvoices_CellContentClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewAllInvoices);
            groupBox5.Location = new Point(12, 148);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1257, 413);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search Results";
            // 
            // radioButtonCustomerEmail
            // 
            radioButtonCustomerEmail.AutoSize = true;
            radioButtonCustomerEmail.Location = new Point(907, 111);
            radioButtonCustomerEmail.Name = "radioButtonCustomerEmail";
            radioButtonCustomerEmail.Size = new Size(150, 24);
            radioButtonCustomerEmail.TabIndex = 12;
            radioButtonCustomerEmail.TabStop = true;
            radioButtonCustomerEmail.Text = "By CustomerEmail";
            radioButtonCustomerEmail.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomerName
            // 
            radioButtonCustomerName.AutoSize = true;
            radioButtonCustomerName.Location = new Point(513, 111);
            radioButtonCustomerName.Name = "radioButtonCustomerName";
            radioButtonCustomerName.Size = new Size(153, 24);
            radioButtonCustomerName.TabIndex = 13;
            radioButtonCustomerName.TabStop = true;
            radioButtonCustomerName.Text = "By CustomerName";
            radioButtonCustomerName.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            buttonExport.BackColor = SystemColors.ActiveCaption;
            buttonExport.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExport.Location = new Point(363, 580);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(131, 46);
            buttonExport.TabIndex = 21;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click_1;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.ActiveCaption;
            buttonSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(1159, 97);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(131, 45);
            buttonSearch.TabIndex = 20;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonImportData
            // 
            buttonImportData.BackColor = SystemColors.ActiveCaption;
            buttonImportData.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonImportData.Location = new Point(677, 580);
            buttonImportData.Name = "buttonImportData";
            buttonImportData.Size = new Size(141, 46);
            buttonImportData.TabIndex = 22;
            buttonImportData.Text = "ImportData";
            buttonImportData.UseVisualStyleBackColor = false;
            buttonImportData.Click += buttonImportData_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 656);
            Controls.Add(buttonImportData);
            Controls.Add(buttonExport);
            Controls.Add(buttonSearch);
            Controls.Add(radioButtonCustomerName);
            Controls.Add(radioButtonCustomerEmail);
            Controls.Add(label1);
            Controls.Add(textBoxSearch);
            Controls.Add(radioButtonIdentity);
            Controls.Add(groupBox5);
            Name = "InvoiceForm";
            Text = "Form2";
            Load += Invoice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllInvoices).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSearch;
        private RadioButton radioButtonIdentity;
        private DataGridView dataGridViewAllInvoices;
        private GroupBox groupBox5;
        private RadioButton radioButtonCustomerEmail;
        private RadioButton radioButtonCustomerName;
        private Button buttonExport;
        private Button buttonSearch;
        private Button buttonImportData;
    }
}