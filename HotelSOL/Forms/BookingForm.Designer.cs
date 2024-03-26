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
            radioButtonRoomId = new RadioButton();
            radioButtonCustomerType = new RadioButton();
            radioButtonIdentity = new RadioButton();
            buttonSearch = new Button();
            label1 = new Label();
            textBoxSearch = new TextBox();
            groupBox5 = new GroupBox();
            dataGridViewSeaarchResult = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewAllRooms = new DataGridView();
            groupBox3 = new GroupBox();
            buttonExport = new Button();
            textRoomDescription = new Label();
            textRoomSeason = new Label();
            textRoomCapacity = new Label();
            textBoxTotalPrice = new TextBox();
            textBoxCheckOut = new TextBox();
            textBoxCheckIn = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBoxNumberDays = new TextBox();
            textBoxSeviceId = new TextBox();
            buttonInsertCust = new Button();
            buttonUpdateRoom = new Button();
            buttonDeleteRoom = new Button();
            textBoxRoomId = new TextBox();
            textBoxCustomerId = new TextBox();
            textBoxBookingId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllRooms).BeginInit();
            groupBox3.SuspendLayout();
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
            groupBox1.Size = new Size(1328, 212);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Rooms";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonRoomId);
            groupBox4.Controls.Add(radioButtonCustomerType);
            groupBox4.Controls.Add(radioButtonIdentity);
            groupBox4.Location = new Point(35, 132);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1097, 72);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search by";
            // 
            // radioButtonRoomId
            // 
            radioButtonRoomId.AutoSize = true;
            radioButtonRoomId.Location = new Point(869, 28);
            radioButtonRoomId.Name = "radioButtonRoomId";
            radioButtonRoomId.Size = new Size(103, 24);
            radioButtonRoomId.TabIndex = 3;
            radioButtonRoomId.TabStop = true;
            radioButtonRoomId.Text = "By room Id";
            radioButtonRoomId.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomerType
            // 
            radioButtonCustomerType.AutoSize = true;
            radioButtonCustomerType.Location = new Point(560, 27);
            radioButtonCustomerType.Name = "radioButtonCustomerType";
            radioButtonCustomerType.Size = new Size(128, 24);
            radioButtonCustomerType.TabIndex = 1;
            radioButtonCustomerType.TabStop = true;
            radioButtonCustomerType.Text = "By customer Id";
            radioButtonCustomerType.UseVisualStyleBackColor = true;
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
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.ActiveCaption;
            buttonSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(1173, 145);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(131, 45);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(485, 31);
            label1.TabIndex = 1;
            label1.Text = "Search Booking by id,customer id and room id";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(34, 88);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(1276, 38);
            textBoxSearch.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewSeaarchResult);
            groupBox5.Location = new Point(12, 221);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(624, 269);
            groupBox5.TabIndex = 7;
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
            groupBox2.Controls.Add(dataGridViewAllRooms);
            groupBox2.Location = new Point(686, 221);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 269);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "All Bookings";
            // 
            // dataGridViewAllRooms
            // 
            dataGridViewAllRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllRooms.Location = new Point(27, 35);
            dataGridViewAllRooms.Name = "dataGridViewAllRooms";
            dataGridViewAllRooms.RowHeadersWidth = 51;
            dataGridViewAllRooms.Size = new Size(566, 207);
            dataGridViewAllRooms.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonExport);
            groupBox3.Controls.Add(textRoomDescription);
            groupBox3.Controls.Add(textRoomSeason);
            groupBox3.Controls.Add(textRoomCapacity);
            groupBox3.Controls.Add(textBoxTotalPrice);
            groupBox3.Controls.Add(textBoxCheckOut);
            groupBox3.Controls.Add(textBoxCheckIn);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBoxNumberDays);
            groupBox3.Controls.Add(textBoxSeviceId);
            groupBox3.Controls.Add(buttonInsertCust);
            groupBox3.Controls.Add(buttonUpdateRoom);
            groupBox3.Controls.Add(buttonDeleteRoom);
            groupBox3.Controls.Add(textBoxRoomId);
            groupBox3.Controls.Add(textBoxCustomerId);
            groupBox3.Controls.Add(textBoxBookingId);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 13.8F);
            groupBox3.Location = new Point(12, 496);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1274, 471);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Room Details";
            // 
            // buttonExport
            // 
            buttonExport.BackColor = SystemColors.ActiveCaption;
            buttonExport.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExport.Location = new Point(38, 406);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(131, 46);
            buttonExport.TabIndex = 19;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = false;
            // 
            // textRoomDescription
            // 
            textRoomDescription.AutoSize = true;
            textRoomDescription.Font = new Font("Segoe UI", 13.8F);
            textRoomDescription.Location = new Point(9, 348);
            textRoomDescription.Name = "textRoomDescription";
            textRoomDescription.Size = new Size(119, 31);
            textRoomDescription.TabIndex = 18;
            textRoomDescription.Text = "Total Price";
            // 
            // textRoomSeason
            // 
            textRoomSeason.AutoSize = true;
            textRoomSeason.Font = new Font("Segoe UI", 13.8F);
            textRoomSeason.Location = new Point(9, 308);
            textRoomSeason.Name = "textRoomSeason";
            textRoomSeason.Size = new Size(119, 31);
            textRoomSeason.TabIndex = 14;
            textRoomSeason.Text = "Check Out";
            // 
            // textRoomCapacity
            // 
            textRoomCapacity.AutoSize = true;
            textRoomCapacity.Font = new Font("Segoe UI", 13.8F);
            textRoomCapacity.Location = new Point(9, 260);
            textRoomCapacity.Name = "textRoomCapacity";
            textRoomCapacity.Size = new Size(100, 31);
            textRoomCapacity.TabIndex = 17;
            textRoomCapacity.Text = "Check In";
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Font = new Font("Segoe UI", 13.8F);
            textBoxTotalPrice.Location = new Point(204, 345);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.Size = new Size(1049, 38);
            textBoxTotalPrice.TabIndex = 16;
            // 
            // textBoxCheckOut
            // 
            textBoxCheckOut.Font = new Font("Segoe UI", 13.8F);
            textBoxCheckOut.Location = new Point(204, 301);
            textBoxCheckOut.Name = "textBoxCheckOut";
            textBoxCheckOut.Size = new Size(1050, 38);
            textBoxCheckOut.TabIndex = 15;
            // 
            // textBoxCheckIn
            // 
            textBoxCheckIn.Font = new Font("Segoe UI", 13.8F);
            textBoxCheckIn.Location = new Point(204, 257);
            textBoxCheckIn.Name = "textBoxCheckIn";
            textBoxCheckIn.Size = new Size(1050, 38);
            textBoxCheckIn.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.Location = new Point(6, 216);
            label7.Name = "label7";
            label7.Size = new Size(153, 31);
            label7.TabIndex = 13;
            label7.Text = "Number Days";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(9, 176);
            label6.Name = "label6";
            label6.Size = new Size(110, 31);
            label6.TabIndex = 12;
            label6.Text = "service Id";
            // 
            // textBoxNumberDays
            // 
            textBoxNumberDays.Font = new Font("Segoe UI", 13.8F);
            textBoxNumberDays.Location = new Point(204, 213);
            textBoxNumberDays.Name = "textBoxNumberDays";
            textBoxNumberDays.Size = new Size(1050, 38);
            textBoxNumberDays.TabIndex = 11;
            // 
            // textBoxSeviceId
            // 
            textBoxSeviceId.Font = new Font("Segoe UI", 13.8F);
            textBoxSeviceId.Location = new Point(204, 169);
            textBoxSeviceId.Name = "textBoxSeviceId";
            textBoxSeviceId.Size = new Size(1050, 38);
            textBoxSeviceId.TabIndex = 10;
            // 
            // buttonInsertCust
            // 
            buttonInsertCust.BackColor = SystemColors.ActiveCaption;
            buttonInsertCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInsertCust.Location = new Point(825, 407);
            buttonInsertCust.Name = "buttonInsertCust";
            buttonInsertCust.Size = new Size(131, 45);
            buttonInsertCust.TabIndex = 9;
            buttonInsertCust.Text = "Insert";
            buttonInsertCust.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateRoom
            // 
            buttonUpdateRoom.BackColor = SystemColors.ActiveCaption;
            buttonUpdateRoom.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdateRoom.Location = new Point(977, 407);
            buttonUpdateRoom.Name = "buttonUpdateRoom";
            buttonUpdateRoom.Size = new Size(131, 45);
            buttonUpdateRoom.TabIndex = 8;
            buttonUpdateRoom.Text = "Update";
            buttonUpdateRoom.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteRoom
            // 
            buttonDeleteRoom.BackColor = SystemColors.ActiveCaption;
            buttonDeleteRoom.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteRoom.Location = new Point(1123, 407);
            buttonDeleteRoom.Name = "buttonDeleteRoom";
            buttonDeleteRoom.Size = new Size(131, 45);
            buttonDeleteRoom.TabIndex = 3;
            buttonDeleteRoom.Text = "Delete";
            buttonDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // textBoxRoomId
            // 
            textBoxRoomId.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomId.Location = new Point(204, 125);
            textBoxRoomId.Name = "textBoxRoomId";
            textBoxRoomId.Size = new Size(1050, 38);
            textBoxRoomId.TabIndex = 6;
            // 
            // textBoxCustomerId
            // 
            textBoxCustomerId.Font = new Font("Segoe UI", 13.8F);
            textBoxCustomerId.Location = new Point(204, 84);
            textBoxCustomerId.Name = "textBoxCustomerId";
            textBoxCustomerId.Size = new Size(1050, 38);
            textBoxCustomerId.TabIndex = 5;
            // 
            // textBoxBookingId
            // 
            textBoxBookingId.Font = new Font("Segoe UI", 13.8F);
            textBoxBookingId.Location = new Point(204, 37);
            textBoxBookingId.Name = "textBoxBookingId";
            textBoxBookingId.Size = new Size(1050, 38);
            textBoxBookingId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(9, 132);
            label4.Name = "label4";
            label4.Size = new Size(106, 31);
            label4.TabIndex = 2;
            label4.Text = "Romm Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(138, 31);
            label3.TabIndex = 1;
            label3.Text = "Customer Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(125, 31);
            label2.TabIndex = 0;
            label2.Text = "Booking ID";
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 982);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllRooms).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private DataGridView dataGridViewAllRooms;
        private GroupBox groupBox3;
        private Button buttonExport;
        private Label textRoomDescription;
        private Label textRoomSeason;
        private Label textRoomCapacity;
        private TextBox textBoxTotalPrice;
        private TextBox textBoxCheckOut;
        private TextBox textBoxCheckIn;
        private Label label7;
        private Label label6;
        private TextBox textBoxNumberDays;
        private TextBox textBoxSeviceId;
        private Button buttonInsertCust;
        private Button buttonUpdateRoom;
        private Button buttonDeleteRoom;
        private TextBox textBoxRoomId;
        private TextBox textBoxCustomerId;
        private TextBox textBoxBookingId;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}