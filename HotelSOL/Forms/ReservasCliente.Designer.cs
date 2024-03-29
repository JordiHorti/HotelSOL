namespace HotelSOL.Forms
{
    partial class ReservasCliente
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
            groupBox3 = new GroupBox();
            buttonSearchCust = new Button();
            textCustEmail = new TextBox();
            textBoxCustName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            groupBox5 = new GroupBox();
            dataGridViewSeaarchResult = new DataGridView();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonSearchCust);
            groupBox3.Controls.Add(textCustEmail);
            groupBox3.Controls.Add(textBoxCustName);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 13.8F);
            groupBox3.Location = new Point(25, 45);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1278, 229);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Customer Search";
            // 
            // buttonSearchCust
            // 
            buttonSearchCust.BackColor = SystemColors.ActiveCaption;
            buttonSearchCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearchCust.Location = new Point(1123, 155);
            buttonSearchCust.Name = "buttonSearchCust";
            buttonSearchCust.Size = new Size(131, 46);
            buttonSearchCust.TabIndex = 7;
            buttonSearchCust.Text = "Search";
            buttonSearchCust.UseVisualStyleBackColor = false;
            buttonSearchCust.Click += buttonSearchCust_Click;
            // 
            // textCustEmail
            // 
            textCustEmail.Font = new Font("Segoe UI", 13.8F);
            textCustEmail.Location = new Point(241, 99);
            textCustEmail.Name = "textCustEmail";
            textCustEmail.Size = new Size(1013, 38);
            textCustEmail.TabIndex = 6;
            // 
            // textBoxCustName
            // 
            textBoxCustName.Font = new Font("Segoe UI", 13.8F);
            textBoxCustName.Location = new Point(241, 39);
            textBoxCustName.Name = "textBoxCustName";
            textBoxCustName.Size = new Size(1013, 38);
            textBoxCustName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(11, 99);
            label4.Name = "label4";
            label4.Size = new Size(174, 31);
            label4.TabIndex = 2;
            label4.Text = "Customer Email";
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
            groupBox5.Location = new Point(25, 300);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1278, 433);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search Results";
            // 
            // dataGridViewSeaarchResult
            // 
            dataGridViewSeaarchResult.BackgroundColor = SystemColors.Control;
            dataGridViewSeaarchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSeaarchResult.Location = new Point(26, 35);
            dataGridViewSeaarchResult.Name = "dataGridViewSeaarchResult";
            dataGridViewSeaarchResult.RowHeadersWidth = 51;
            dataGridViewSeaarchResult.Size = new Size(1228, 368);
            dataGridViewSeaarchResult.TabIndex = 1;
            dataGridViewSeaarchResult.CellContentClick += dataGridViewSeaarchResult_CellContentClick;
            // 
            // ReservasCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 812);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Name = "ReservasCliente";
            Text = "ReservasCliente";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox textCustEmail;
        private TextBox textBoxCustName;
        private Label label4;
        private Label label2;
        private Button buttonSearchCust;
        private GroupBox groupBox5;
        private DataGridView dataGridViewSeaarchResult;
    }
}