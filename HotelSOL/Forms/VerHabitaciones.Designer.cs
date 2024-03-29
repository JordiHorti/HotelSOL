namespace HotelSOL.Cliente
{
    partial class VerHabitaciones
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
            groupBoxPrice = new GroupBox();
            radioButtonPriceAll = new RadioButton();
            radioButtonPrice300 = new RadioButton();
            radioButtonPrice100 = new RadioButton();
            groupBox4 = new GroupBox();
            radioButtonSuite = new RadioButton();
            radioButtonFamiliar = new RadioButton();
            radioButtonTodas = new RadioButton();
            radioButtonIndividual = new RadioButton();
            radioButtonDoble = new RadioButton();
            label1 = new Label();
            buttonBuscar = new Button();
            groupBox5 = new GroupBox();
            dataGridView1 = new DataGridView();
            dataGridViewSeaarchResult = new DataGridView();
            button1 = new Button();
            groupBox2 = new GroupBox();
            dataGridViewAllServices = new DataGridView();
            textBoxName = new TextBox();
            textBoxRoomNumber = new TextBox();
            textBoxServiceId = new TextBox();
            textBoxEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            textBoxCheckIn = new TextBox();
            label7 = new Label();
            textBoxCheckOut = new TextBox();
            groupBox1.SuspendLayout();
            groupBoxPrice.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllServices).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBoxPrice);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(40, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1165, 227);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar habitaciones";
            // 
            // groupBoxPrice
            // 
            groupBoxPrice.Controls.Add(radioButtonPriceAll);
            groupBoxPrice.Controls.Add(radioButtonPrice300);
            groupBoxPrice.Controls.Add(radioButtonPrice100);
            groupBoxPrice.Location = new Point(34, 135);
            groupBoxPrice.Name = "groupBoxPrice";
            groupBoxPrice.Size = new Size(1097, 72);
            groupBoxPrice.TabIndex = 4;
            groupBoxPrice.TabStop = false;
            groupBoxPrice.Text = "Precio";
            // 
            // radioButtonPriceAll
            // 
            radioButtonPriceAll.AutoSize = true;
            radioButtonPriceAll.Location = new Point(869, 25);
            radioButtonPriceAll.Name = "radioButtonPriceAll";
            radioButtonPriceAll.Size = new Size(69, 24);
            radioButtonPriceAll.TabIndex = 3;
            radioButtonPriceAll.TabStop = true;
            radioButtonPriceAll.Text = "Todas";
            radioButtonPriceAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrice300
            // 
            radioButtonPrice300.AutoSize = true;
            radioButtonPrice300.Location = new Point(495, 25);
            radioButtonPrice300.Name = "radioButtonPrice300";
            radioButtonPrice300.Size = new Size(92, 24);
            radioButtonPrice300.TabIndex = 1;
            radioButtonPrice300.TabStop = true;
            radioButtonPrice300.Text = "101-300€";
            radioButtonPrice300.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrice100
            // 
            radioButtonPrice100.AutoSize = true;
            radioButtonPrice100.Location = new Point(187, 25);
            radioButtonPrice100.Name = "radioButtonPrice100";
            radioButtonPrice100.Size = new Size(76, 24);
            radioButtonPrice100.TabIndex = 0;
            radioButtonPrice100.TabStop = true;
            radioButtonPrice100.Text = "0-100€";
            radioButtonPrice100.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonSuite);
            groupBox4.Controls.Add(radioButtonFamiliar);
            groupBox4.Controls.Add(radioButtonTodas);
            groupBox4.Controls.Add(radioButtonIndividual);
            groupBox4.Controls.Add(radioButtonDoble);
            groupBox4.Location = new Point(34, 57);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1097, 72);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tipos";
            // 
            // radioButtonSuite
            // 
            radioButtonSuite.AutoSize = true;
            radioButtonSuite.Location = new Point(524, 27);
            radioButtonSuite.Name = "radioButtonSuite";
            radioButtonSuite.Size = new Size(63, 24);
            radioButtonSuite.TabIndex = 5;
            radioButtonSuite.TabStop = true;
            radioButtonSuite.Text = "Suite";
            radioButtonSuite.UseVisualStyleBackColor = true;
            // 
            // radioButtonFamiliar
            // 
            radioButtonFamiliar.AutoSize = true;
            radioButtonFamiliar.Location = new Point(753, 26);
            radioButtonFamiliar.Name = "radioButtonFamiliar";
            radioButtonFamiliar.Size = new Size(82, 24);
            radioButtonFamiliar.TabIndex = 4;
            radioButtonFamiliar.TabStop = true;
            radioButtonFamiliar.Text = "Familiar";
            radioButtonFamiliar.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodas
            // 
            radioButtonTodas.AutoSize = true;
            radioButtonTodas.Location = new Point(1003, 26);
            radioButtonTodas.Name = "radioButtonTodas";
            radioButtonTodas.Size = new Size(69, 24);
            radioButtonTodas.TabIndex = 3;
            radioButtonTodas.TabStop = true;
            radioButtonTodas.Text = "Todas";
            radioButtonTodas.UseVisualStyleBackColor = true;
            // 
            // radioButtonIndividual
            // 
            radioButtonIndividual.AutoSize = true;
            radioButtonIndividual.Location = new Point(290, 26);
            radioButtonIndividual.Name = "radioButtonIndividual";
            radioButtonIndividual.Size = new Size(95, 24);
            radioButtonIndividual.TabIndex = 1;
            radioButtonIndividual.TabStop = true;
            radioButtonIndividual.Text = "Individual";
            radioButtonIndividual.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoble
            // 
            radioButtonDoble.AutoSize = true;
            radioButtonDoble.Location = new Point(100, 27);
            radioButtonDoble.Name = "radioButtonDoble";
            radioButtonDoble.Size = new Size(71, 24);
            radioButtonDoble.TabIndex = 0;
            radioButtonDoble.TabStop = true;
            radioButtonDoble.Text = "Doble";
            radioButtonDoble.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(121, 31);
            label1.TabIndex = 1;
            label1.Text = "Search for:";
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.ActiveCaption;
            buttonBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBuscar.Location = new Point(1040, 248);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(131, 45);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Search";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView1);
            groupBox5.Controls.Add(dataGridViewSeaarchResult);
            groupBox5.Location = new Point(40, 289);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1191, 171);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Results";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(6, 328);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1091, 145);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridViewSeaarchResult
            // 
            dataGridViewSeaarchResult.BackgroundColor = Color.Azure;
            dataGridViewSeaarchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSeaarchResult.GridColor = SystemColors.InactiveBorder;
            dataGridViewSeaarchResult.Location = new Point(26, 35);
            dataGridViewSeaarchResult.Name = "dataGridViewSeaarchResult";
            dataGridViewSeaarchResult.RowHeadersWidth = 51;
            dataGridViewSeaarchResult.Size = new Size(1091, 105);
            dataGridViewSeaarchResult.TabIndex = 1;
            dataGridViewSeaarchResult.CellContentClick += dataGridViewSeaarchResult_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1040, 787);
            button1.Name = "button1";
            button1.Size = new Size(131, 45);
            button1.TabIndex = 8;
            button1.Text = "Booking";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllServices);
            groupBox2.Location = new Point(40, 466);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1191, 188);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Al Services";
            // 
            // dataGridViewAllServices
            // 
            dataGridViewAllServices.BackgroundColor = Color.White;
            dataGridViewAllServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllServices.GridColor = SystemColors.HighlightText;
            dataGridViewAllServices.Location = new Point(26, 26);
            dataGridViewAllServices.Name = "dataGridViewAllServices";
            dataGridViewAllServices.RowHeadersWidth = 51;
            dataGridViewAllServices.Size = new Size(1091, 133);
            dataGridViewAllServices.TabIndex = 2;
            dataGridViewAllServices.CellContentClick += dataGridViewAllServices_CellContentClick;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(216, 683);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(130, 27);
            textBoxName.TabIndex = 13;
            // 
            // textBoxRoomNumber
            // 
            textBoxRoomNumber.Location = new Point(216, 727);
            textBoxRoomNumber.Name = "textBoxRoomNumber";
            textBoxRoomNumber.Size = new Size(130, 27);
            textBoxRoomNumber.TabIndex = 17;
            // 
            // textBoxServiceId
            // 
            textBoxServiceId.Location = new Point(932, 681);
            textBoxServiceId.Name = "textBoxServiceId";
            textBoxServiceId.Size = new Size(130, 27);
            textBoxServiceId.TabIndex = 23;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(586, 683);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(130, 27);
            textBoxEmail.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(102, 683);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 24;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(47, 723);
            label3.Name = "label3";
            label3.Size = new Size(163, 31);
            label3.TabIndex = 25;
            label3.Text = "Room Number";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(481, 679);
            label5.Name = "label5";
            label5.Size = new Size(70, 31);
            label5.TabIndex = 27;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(814, 677);
            label6.Name = "label6";
            label6.Size = new Size(112, 31);
            label6.TabIndex = 28;
            label6.Text = "Service Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(481, 731);
            label4.Name = "label4";
            label4.Size = new Size(100, 31);
            label4.TabIndex = 29;
            label4.Text = "Check In";
            // 
            // textBoxCheckIn
            // 
            textBoxCheckIn.Location = new Point(586, 737);
            textBoxCheckIn.Name = "textBoxCheckIn";
            textBoxCheckIn.Size = new Size(130, 27);
            textBoxCheckIn.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.Location = new Point(807, 731);
            label7.Name = "label7";
            label7.Size = new Size(119, 31);
            label7.TabIndex = 32;
            label7.Text = "Check Out";
            label7.Click += label7_Click;
            // 
            // textBoxCheckOut
            // 
            textBoxCheckOut.Location = new Point(932, 731);
            textBoxCheckOut.Name = "textBoxCheckOut";
            textBoxCheckOut.Size = new Size(130, 27);
            textBoxCheckOut.TabIndex = 31;
            // 
            // VerHabitaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 844);
            Controls.Add(label7);
            Controls.Add(textBoxCheckOut);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxCheckIn);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxServiceId);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxRoomNumber);
            Controls.Add(textBoxName);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VerHabitaciones";
            Text = "VerHabitaciones";
            Load += VerHabitaciones_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxPrice.ResumeLayout(false);
            groupBoxPrice.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private RadioButton radioButtonTodas;
        private RadioButton radioButtonIndividual;
        private RadioButton radioButtonDoble;
        private Button buttonBuscar;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioButtonPriceAll;
        private RadioButton radioButtonPrice300;
        private RadioButton radioButtonPrice100;
        private GroupBox groupBox5;
        private DataGridView dataGridViewSeaarchResult;
        private RadioButton radioButtonSuite;
        private RadioButton radioButtonFamiliar;
        private DataGridView dataGridView1;
        private Button button1;
        private GroupBox groupBoxPrice;
        private DataGridView dataGridViewAllServices;
        private TextBox textBoxName;
        private TextBox textBoxRoomNumber;
        private TextBox textBoxServiceId;
        private TextBox textBoxEmail;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        private TextBox textBoxCheckIn;
        private Label label7;
        private TextBox textBoxCheckOut;
    }
}