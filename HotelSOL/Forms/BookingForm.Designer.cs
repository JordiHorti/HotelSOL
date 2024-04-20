namespace HotelSOL.Forms
{
    partial class BookingForm
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
            radioButtonBookingService = new RadioButton();
            radioButtonRoomNumber = new RadioButton();
            radioButtonIdentity = new RadioButton();
            buttonSearch = new Button();
            label1 = new Label();
            textBoxSearch = new TextBox();
            groupBox5 = new GroupBox();
            dataGridViewSeaarchResult = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewAllBooking = new DataGridView();
            groupBox3 = new GroupBox();
            buttonImportData = new Button();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            buttonExport = new Button();
            textRoomSeason = new Label();
            textRoomCapacity = new Label();
            label3 = new Label();
            textBoxCheckOut = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBoxChekIn = new TextBox();
            textBoxRoomNumber = new TextBox();
            buttonInsertCust = new Button();
            buttonUpdateRoom = new Button();
            buttonDeleteRoom = new Button();
            textBoxCustomerEmail = new TextBox();
            textBoxCustomerName = new TextBox();
            textBoxBookingId = new TextBox();
            groupBox6 = new GroupBox();
            dataGridViewBookingRooms = new DataGridView();
            groupBox7 = new GroupBox();
            dataGridViewBookingServices = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllBooking).BeginInit();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookingRooms).BeginInit();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookingServices).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1328, 194);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search booking";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonBookingService);
            groupBox4.Controls.Add(radioButtonRoomNumber);
            groupBox4.Controls.Add(radioButtonIdentity);
            groupBox4.Location = new Point(34, 101);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1097, 72);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search by";
            // 
            // radioButtonBookingService
            // 
            radioButtonBookingService.AutoSize = true;
            radioButtonBookingService.Location = new Point(869, 28);
            radioButtonBookingService.Name = "radioButtonBookingService";
            radioButtonBookingService.Size = new Size(114, 24);
            radioButtonBookingService.TabIndex = 3;
            radioButtonBookingService.TabStop = true;
            radioButtonBookingService.Text = "By Service Id";
            radioButtonBookingService.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoomNumber
            // 
            radioButtonRoomNumber.AutoSize = true;
            radioButtonRoomNumber.Location = new Point(560, 27);
            radioButtonRoomNumber.Name = "radioButtonRoomNumber";
            radioButtonRoomNumber.Size = new Size(144, 24);
            radioButtonRoomNumber.TabIndex = 1;
            radioButtonRoomNumber.TabStop = true;
            radioButtonRoomNumber.Text = "By RoomNumber";
            radioButtonRoomNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonIdentity
            // 
            radioButtonIdentity.AutoSize = true;
            radioButtonIdentity.Location = new Point(187, 28);
            radioButtonIdentity.Name = "radioButtonIdentity";
            radioButtonIdentity.Size = new Size(87, 24);
            radioButtonIdentity.TabIndex = 0;
            radioButtonIdentity.TabStop = true;
            radioButtonIdentity.Text = "By Email";
            radioButtonIdentity.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.ActiveCaption;
            buttonSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(1170, 115);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(131, 45);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(410, 31);
            label1.TabIndex = 1;
            label1.Text = "Search Booking by email, room, service";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(34, 57);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(1276, 38);
            textBoxSearch.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewSeaarchResult);
            groupBox5.Location = new Point(14, 203);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(624, 416);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search Results";
            // 
            // dataGridViewSeaarchResult
            // 
            dataGridViewSeaarchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSeaarchResult.Location = new Point(29, 35);
            dataGridViewSeaarchResult.Name = "dataGridViewSeaarchResult";
            dataGridViewSeaarchResult.RowHeadersWidth = 51;
            dataGridViewSeaarchResult.Size = new Size(569, 391);
            dataGridViewSeaarchResult.TabIndex = 1;
            dataGridViewSeaarchResult.CellContentClick += dataGridViewSeaarchResult_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllBooking);
            groupBox2.Location = new Point(644, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(845, 160);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "All Bookings";
            // 
            // dataGridViewAllBooking
            // 
            dataGridViewAllBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllBooking.Location = new Point(27, 35);
            dataGridViewAllBooking.Name = "dataGridViewAllBooking";
            dataGridViewAllBooking.RowHeadersWidth = 51;
            dataGridViewAllBooking.Size = new Size(795, 115);
            dataGridViewAllBooking.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonImportData);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(buttonExport);
            groupBox3.Controls.Add(textRoomSeason);
            groupBox3.Controls.Add(textRoomCapacity);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBoxCheckOut);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBoxChekIn);
            groupBox3.Controls.Add(textBoxRoomNumber);
            groupBox3.Controls.Add(buttonInsertCust);
            groupBox3.Controls.Add(buttonUpdateRoom);
            groupBox3.Controls.Add(buttonDeleteRoom);
            groupBox3.Controls.Add(textBoxCustomerEmail);
            groupBox3.Controls.Add(textBoxCustomerName);
            groupBox3.Controls.Add(textBoxBookingId);
            groupBox3.Font = new Font("Segoe UI", 13.8F);
            groupBox3.Location = new Point(37, 647);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1452, 396);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Booking Details";
            // 
            // buttonImportData
            // 
            buttonImportData.BackColor = SystemColors.ActiveCaption;
            buttonImportData.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonImportData.Location = new Point(404, 350);
            buttonImportData.Name = "buttonImportData";
            buttonImportData.Size = new Size(157, 46);
            buttonImportData.TabIndex = 24;
            buttonImportData.Text = "ImportData";
            buttonImportData.UseVisualStyleBackColor = false;
            buttonImportData.Click += buttonImportData_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1161, 311);
            label4.Name = "label4";
            label4.Size = new Size(255, 23);
            label4.TabIndex = 23;
            label4.Text = "Rellenar solo en caso de DELETE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(18, 301);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 22;
            label2.Text = "Booking Id";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F);
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(204, 301);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(951, 38);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(18, 132);
            label5.Name = "label5";
            label5.Size = new Size(174, 31);
            label5.TabIndex = 20;
            label5.Text = "Customer Email";
            // 
            // buttonExport
            // 
            buttonExport.BackColor = SystemColors.ActiveCaption;
            buttonExport.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExport.Location = new Point(204, 350);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(131, 46);
            buttonExport.TabIndex = 19;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // textRoomSeason
            // 
            textRoomSeason.AutoSize = true;
            textRoomSeason.Font = new Font("Segoe UI", 13.8F);
            textRoomSeason.Location = new Point(18, 257);
            textRoomSeason.Name = "textRoomSeason";
            textRoomSeason.Size = new Size(119, 31);
            textRoomSeason.TabIndex = 14;
            textRoomSeason.Text = "Check Out";
            // 
            // textRoomCapacity
            // 
            textRoomCapacity.AutoSize = true;
            textRoomCapacity.Font = new Font("Segoe UI", 13.8F);
            textRoomCapacity.Location = new Point(18, 216);
            textRoomCapacity.Name = "textRoomCapacity";
            textRoomCapacity.Size = new Size(100, 31);
            textRoomCapacity.TabIndex = 17;
            textRoomCapacity.Text = "Check In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(18, 87);
            label3.Name = "label3";
            label3.Size = new Size(179, 31);
            label3.TabIndex = 1;
            label3.Text = "Customer Name";
            // 
            // textBoxCheckOut
            // 
            textBoxCheckOut.Font = new Font("Segoe UI", 13.8F);
            textBoxCheckOut.Location = new Point(204, 257);
            textBoxCheckOut.Name = "textBoxCheckOut";
            textBoxCheckOut.Size = new Size(1212, 38);
            textBoxCheckOut.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.Location = new Point(18, 176);
            label7.Name = "label7";
            label7.Size = new Size(163, 31);
            label7.TabIndex = 13;
            label7.Text = "Room Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(18, 44);
            label6.Name = "label6";
            label6.Size = new Size(110, 31);
            label6.TabIndex = 12;
            label6.Text = "service Id";
            // 
            // textBoxChekIn
            // 
            textBoxChekIn.Font = new Font("Segoe UI", 13.8F);
            textBoxChekIn.Location = new Point(204, 213);
            textBoxChekIn.Name = "textBoxChekIn";
            textBoxChekIn.Size = new Size(1212, 38);
            textBoxChekIn.TabIndex = 11;
            // 
            // textBoxRoomNumber
            // 
            textBoxRoomNumber.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomNumber.Location = new Point(204, 169);
            textBoxRoomNumber.Name = "textBoxRoomNumber";
            textBoxRoomNumber.Size = new Size(1212, 38);
            textBoxRoomNumber.TabIndex = 10;
            // 
            // buttonInsertCust
            // 
            buttonInsertCust.BackColor = SystemColors.ActiveCaption;
            buttonInsertCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInsertCust.Location = new Point(975, 345);
            buttonInsertCust.Name = "buttonInsertCust";
            buttonInsertCust.Size = new Size(131, 45);
            buttonInsertCust.TabIndex = 9;
            buttonInsertCust.Text = "Insert";
            buttonInsertCust.UseVisualStyleBackColor = false;
            buttonInsertCust.Click += buttonInsertCust_Click;
            // 
            // buttonUpdateRoom
            // 
            buttonUpdateRoom.BackColor = SystemColors.ActiveCaption;
            buttonUpdateRoom.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdateRoom.Location = new Point(1130, 345);
            buttonUpdateRoom.Name = "buttonUpdateRoom";
            buttonUpdateRoom.Size = new Size(131, 45);
            buttonUpdateRoom.TabIndex = 8;
            buttonUpdateRoom.Text = "Update";
            buttonUpdateRoom.UseVisualStyleBackColor = false;
            buttonUpdateRoom.Click += buttonUpdateRoom_Click;
            // 
            // buttonDeleteRoom
            // 
            buttonDeleteRoom.BackColor = SystemColors.ActiveCaption;
            buttonDeleteRoom.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteRoom.Location = new Point(1279, 345);
            buttonDeleteRoom.Name = "buttonDeleteRoom";
            buttonDeleteRoom.Size = new Size(137, 45);
            buttonDeleteRoom.TabIndex = 3;
            buttonDeleteRoom.Text = "Delete";
            buttonDeleteRoom.UseVisualStyleBackColor = false;
            buttonDeleteRoom.Click += buttonDeleteRoom_Click;
            // 
            // textBoxCustomerEmail
            // 
            textBoxCustomerEmail.Font = new Font("Segoe UI", 13.8F);
            textBoxCustomerEmail.Location = new Point(204, 125);
            textBoxCustomerEmail.Name = "textBoxCustomerEmail";
            textBoxCustomerEmail.Size = new Size(1212, 38);
            textBoxCustomerEmail.TabIndex = 6;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Font = new Font("Segoe UI", 13.8F);
            textBoxCustomerName.Location = new Point(204, 84);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(1212, 38);
            textBoxCustomerName.TabIndex = 5;
            // 
            // textBoxBookingId
            // 
            textBoxBookingId.Font = new Font("Segoe UI", 13.8F);
            textBoxBookingId.Location = new Point(204, 37);
            textBoxBookingId.Name = "textBoxBookingId";
            textBoxBookingId.Size = new Size(1212, 38);
            textBoxBookingId.TabIndex = 4;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridViewBookingRooms);
            groupBox6.Location = new Point(644, 359);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(845, 149);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "All Rooms";
            // 
            // dataGridViewBookingRooms
            // 
            dataGridViewBookingRooms.AccessibleRole = AccessibleRole.OutlineButton;
            dataGridViewBookingRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookingRooms.Location = new Point(33, 33);
            dataGridViewBookingRooms.Name = "dataGridViewBookingRooms";
            dataGridViewBookingRooms.RowHeadersWidth = 51;
            dataGridViewBookingRooms.Size = new Size(789, 104);
            dataGridViewBookingRooms.TabIndex = 2;
            dataGridViewBookingRooms.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dataGridViewBookingServices);
            groupBox7.Location = new Point(644, 514);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(845, 147);
            groupBox7.TabIndex = 11;
            groupBox7.TabStop = false;
            groupBox7.Text = "All Services";
            // 
            // dataGridViewBookingServices
            // 
            dataGridViewBookingServices.AccessibleRole = AccessibleRole.OutlineButton;
            dataGridViewBookingServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookingServices.Location = new Point(37, 26);
            dataGridViewBookingServices.Name = "dataGridViewBookingServices";
            dataGridViewBookingServices.RowHeadersWidth = 51;
            dataGridViewBookingServices.Size = new Size(785, 101);
            dataGridViewBookingServices.TabIndex = 2;
            dataGridViewBookingServices.CellContentClick += dataGridView2_CellContentClick;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1522, 1073);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Name = "BookingForm";
            Text = "BookingForm";
            Load += BookingForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllBooking).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookingRooms).EndInit();
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookingServices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private RadioButton radioButtonRoomId;
        private RadioButton radioButtonCustomerType;
        private RadioButton radioButtonIdentity;
        private Button buttonSearch;
        private Label label1;
        private TextBox textBoxSearch;
        private GroupBox groupBox5;
        private DataGridView dataGridViewSeaarchResult;
        private GroupBox groupBox2;
        private DataGridView dataGridViewAllBooking;
        private GroupBox groupBox3;
        private Button buttonExport;
        private Label textRoomSeason;
        private Label textRoomCapacity;
        private TextBox textBoxCheckOut;
        private Label label7;
        private Label label6;
        private TextBox textBoxChekIn;
        private TextBox textBoxRoomNumber;
        private Button buttonInsertCust;
        private Button buttonUpdateRoom;
        private Button buttonDeleteRoom;
        private TextBox textBoxCustomerEmail;
        private TextBox textBoxCustomerName;
        private TextBox textBoxBookingId;
        private Label label3;
        private Label label5;
        private GroupBox groupBox6;
        private DataGridView dataGridViewBookingRooms;
        private GroupBox groupBox7;
        private DataGridView dataGridViewBookingServices;
        private RadioButton radioButtonBookingService;
        private RadioButton radioButtonRoomNumber;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private Button buttonImportData;
    }
}