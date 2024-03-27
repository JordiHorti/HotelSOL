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
            textRoomSeason = new Label();
            textRoomCapacity = new Label();
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
            label3 = new Label();
            label5 = new Label();
            groupBox6 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox7 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllRooms).BeginInit();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            groupBox1.Text = "Search booking";
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
            radioButtonRoomId.Size = new Size(114, 24);
            radioButtonRoomId.TabIndex = 3;
            radioButtonRoomId.TabStop = true;
            radioButtonRoomId.Text = "By Service Id";
            radioButtonRoomId.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomerType
            // 
            radioButtonCustomerType.AutoSize = true;
            radioButtonCustomerType.Location = new Point(560, 27);
            radioButtonCustomerType.Name = "radioButtonCustomerType";
            radioButtonCustomerType.Size = new Size(144, 24);
            radioButtonCustomerType.TabIndex = 1;
            radioButtonCustomerType.TabStop = true;
            radioButtonCustomerType.Text = "By RoomNumber";
            radioButtonCustomerType.UseVisualStyleBackColor = true;
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
            label1.Size = new Size(410, 31);
            label1.TabIndex = 1;
            label1.Text = "Search Booking by email, room, service";
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
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllRooms);
            groupBox2.Location = new Point(686, 221);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 242);
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
            dataGridViewAllRooms.Size = new Size(566, 115);
            dataGridViewAllRooms.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(buttonExport);
            groupBox3.Controls.Add(textRoomSeason);
            groupBox3.Controls.Add(textRoomCapacity);
            groupBox3.Controls.Add(label3);
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
            groupBox3.Font = new Font("Segoe UI", 13.8F);
            groupBox3.Location = new Point(23, 664);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1274, 373);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Room Details";
            // 
            // buttonExport
            // 
            buttonExport.BackColor = SystemColors.ActiveCaption;
            buttonExport.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExport.Location = new Point(26, 325);
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
            buttonInsertCust.Location = new Point(825, 325);
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
            buttonUpdateRoom.Location = new Point(977, 326);
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
            buttonDeleteRoom.Location = new Point(1114, 326);
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
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridView1);
            groupBox6.Location = new Point(680, 377);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(617, 148);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "All Rooms";
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.OutlineButton;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(566, 104);
            dataGridView1.TabIndex = 2;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dataGridView2);
            groupBox7.Location = new Point(674, 520);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(617, 159);
            groupBox7.TabIndex = 11;
            groupBox7.TabStop = false;
            groupBox7.Text = "All Services";
            // 
            // dataGridView2
            // 
            dataGridView2.AccessibleRole = AccessibleRole.OutlineButton;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(37, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(566, 101);
            dataGridView2.TabIndex = 2;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 1049);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllRooms).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Label textRoomSeason;
        private Label textRoomCapacity;
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
        private Label label3;
        private Label label5;
        private GroupBox groupBox6;
        private DataGridView dataGridView1;
        private GroupBox groupBox7;
        private DataGridView dataGridView2;
    }
}