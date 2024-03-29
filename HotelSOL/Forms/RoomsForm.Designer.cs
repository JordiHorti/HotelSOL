
namespace HotelSOL
{
    partial class RoomsForm
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
        /// 


        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            radioButtonAvailability = new RadioButton();
            radioButtonType = new RadioButton();
            radioButtonIdentity = new RadioButton();
            buttonSearch = new Button();
            label1 = new Label();
            textBoxSearch = new TextBox();
            groupBox5 = new GroupBox();
            dataGridViewSeaarchResult = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewAllRooms = new DataGridView();
            groupBox3 = new GroupBox();
            buttonImportData = new Button();
            buttonExport = new Button();
            textRoomDescription = new Label();
            textRoomSeason = new Label();
            textRoomCapacity = new Label();
            textBoxRoomDescription = new TextBox();
            textBoxRoomSeason = new TextBox();
            textBoxRoomCapacity = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBoxRoomBooked = new TextBox();
            textBoxRoomPrice = new TextBox();
            buttonInsertCust = new Button();
            buttonUpdateRoom = new Button();
            buttonDeleteRoom = new Button();
            textBoxRoomType = new TextBox();
            textBoxRommNo = new TextBox();
            textBoxRoomId = new TextBox();
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
            groupBox1.Location = new Point(11, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1328, 212);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Rooms";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonAvailability);
            groupBox4.Controls.Add(radioButtonType);
            groupBox4.Controls.Add(radioButtonIdentity);
            groupBox4.Location = new Point(35, 132);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1097, 72);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search by";
            // 
            // radioButtonAvailability
            // 
            radioButtonAvailability.AutoSize = true;
            radioButtonAvailability.Location = new Point(869, 28);
            radioButtonAvailability.Name = "radioButtonAvailability";
            radioButtonAvailability.Size = new Size(122, 24);
            radioButtonAvailability.TabIndex = 3;
            radioButtonAvailability.TabStop = true;
            radioButtonAvailability.Text = "By availability";
            radioButtonAvailability.UseVisualStyleBackColor = true;
            // 
            // radioButtonType
            // 
            radioButtonType.AutoSize = true;
            radioButtonType.Location = new Point(560, 27);
            radioButtonType.Name = "radioButtonType";
            radioButtonType.Size = new Size(79, 24);
            radioButtonType.TabIndex = 1;
            radioButtonType.TabStop = true;
            radioButtonType.Text = "By type";
            radioButtonType.UseVisualStyleBackColor = true;
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
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(385, 31);
            label1.TabIndex = 1;
            label1.Text = "Search room by type and availability";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(34, 88);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(1276, 38);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewSeaarchResult);
            groupBox5.Location = new Point(47, 229);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(624, 269);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search Results";
            groupBox5.Enter += groupBox5_Enter;
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
            groupBox2.Location = new Point(699, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 269);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "All Rooms";
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
            groupBox3.Controls.Add(buttonImportData);
            groupBox3.Controls.Add(buttonExport);
            groupBox3.Controls.Add(textRoomDescription);
            groupBox3.Controls.Add(textRoomSeason);
            groupBox3.Controls.Add(textRoomCapacity);
            groupBox3.Controls.Add(textBoxRoomDescription);
            groupBox3.Controls.Add(textBoxRoomSeason);
            groupBox3.Controls.Add(textBoxRoomCapacity);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBoxRoomBooked);
            groupBox3.Controls.Add(textBoxRoomPrice);
            groupBox3.Controls.Add(buttonInsertCust);
            groupBox3.Controls.Add(buttonUpdateRoom);
            groupBox3.Controls.Add(buttonDeleteRoom);
            groupBox3.Controls.Add(textBoxRoomType);
            groupBox3.Controls.Add(textBoxRommNo);
            groupBox3.Controls.Add(textBoxRoomId);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 13.8F);
            groupBox3.Location = new Point(47, 515);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1274, 471);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Room Details";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // buttonImportData
            // 
            buttonImportData.BackColor = SystemColors.ActiveCaption;
            buttonImportData.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonImportData.Location = new Point(266, 407);
            buttonImportData.Name = "buttonImportData";
            buttonImportData.Size = new Size(148, 46);
            buttonImportData.TabIndex = 20;
            buttonImportData.Text = "ImportData";
            buttonImportData.UseVisualStyleBackColor = false;
            buttonImportData.Click += buttonImportData_Click;
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
            buttonExport.Click += buttonExport_Click;
            // 
            // textRoomDescription
            // 
            textRoomDescription.AutoSize = true;
            textRoomDescription.Font = new Font("Segoe UI", 13.8F);
            textRoomDescription.Location = new Point(9, 348);
            textRoomDescription.Name = "textRoomDescription";
            textRoomDescription.Size = new Size(196, 31);
            textRoomDescription.TabIndex = 18;
            textRoomDescription.Text = "Room Description";
            // 
            // textRoomSeason
            // 
            textRoomSeason.AutoSize = true;
            textRoomSeason.Font = new Font("Segoe UI", 13.8F);
            textRoomSeason.Location = new Point(9, 308);
            textRoomSeason.Name = "textRoomSeason";
            textRoomSeason.Size = new Size(151, 31);
            textRoomSeason.TabIndex = 14;
            textRoomSeason.Text = "Room Season";
            textRoomSeason.Click += textRoomSeason_Click;
            // 
            // textRoomCapacity
            // 
            textRoomCapacity.AutoSize = true;
            textRoomCapacity.Font = new Font("Segoe UI", 13.8F);
            textRoomCapacity.Location = new Point(5, 264);
            textRoomCapacity.Name = "textRoomCapacity";
            textRoomCapacity.Size = new Size(102, 31);
            textRoomCapacity.TabIndex = 17;
            textRoomCapacity.Text = "Capacity";
            // 
            // textBoxRoomDescription
            // 
            textBoxRoomDescription.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomDescription.Location = new Point(204, 345);
            textBoxRoomDescription.Name = "textBoxRoomDescription";
            textBoxRoomDescription.Size = new Size(1049, 38);
            textBoxRoomDescription.TabIndex = 16;
            // 
            // textBoxRoomSeason
            // 
            textBoxRoomSeason.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomSeason.Location = new Point(204, 301);
            textBoxRoomSeason.Name = "textBoxRoomSeason";
            textBoxRoomSeason.Size = new Size(1050, 38);
            textBoxRoomSeason.TabIndex = 15;
            // 
            // textBoxRoomCapacity
            // 
            textBoxRoomCapacity.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomCapacity.Location = new Point(204, 257);
            textBoxRoomCapacity.Name = "textBoxRoomCapacity";
            textBoxRoomCapacity.Size = new Size(1050, 38);
            textBoxRoomCapacity.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.Location = new Point(6, 216);
            label7.Name = "label7";
            label7.Size = new Size(90, 31);
            label7.TabIndex = 13;
            label7.Text = "Booked";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(9, 176);
            label6.Name = "label6";
            label6.Size = new Size(64, 31);
            label6.TabIndex = 12;
            label6.Text = "Price";
            // 
            // textBoxRoomBooked
            // 
            textBoxRoomBooked.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomBooked.Location = new Point(204, 213);
            textBoxRoomBooked.Name = "textBoxRoomBooked";
            textBoxRoomBooked.Size = new Size(1050, 38);
            textBoxRoomBooked.TabIndex = 11;
            // 
            // textBoxRoomPrice
            // 
            textBoxRoomPrice.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomPrice.Location = new Point(204, 169);
            textBoxRoomPrice.Name = "textBoxRoomPrice";
            textBoxRoomPrice.Size = new Size(1050, 38);
            textBoxRoomPrice.TabIndex = 10;
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
            buttonInsertCust.Click += buttonInsertRoom_Click;
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
            buttonUpdateRoom.Click += buttonUpdateRoom_Click;
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
            buttonDeleteRoom.Click += buttonDeleteRoom_Click;
            // 
            // textBoxRoomType
            // 
            textBoxRoomType.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomType.Location = new Point(204, 125);
            textBoxRoomType.Name = "textBoxRoomType";
            textBoxRoomType.Size = new Size(1050, 38);
            textBoxRoomType.TabIndex = 6;
            // 
            // textBoxRommNo
            // 
            textBoxRommNo.Font = new Font("Segoe UI", 13.8F);
            textBoxRommNo.Location = new Point(204, 84);
            textBoxRommNo.Name = "textBoxRommNo";
            textBoxRommNo.Size = new Size(1050, 38);
            textBoxRommNo.TabIndex = 5;
            // 
            // textBoxRoomId
            // 
            textBoxRoomId.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomId.Location = new Point(204, 37);
            textBoxRoomId.Name = "textBoxRoomId";
            textBoxRoomId.Size = new Size(1050, 38);
            textBoxRoomId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(9, 132);
            label4.Name = "label4";
            label4.Size = new Size(131, 31);
            label4.TabIndex = 2;
            label4.Text = "Romm type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(163, 31);
            label3.TabIndex = 1;
            label3.Text = "Room Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(101, 31);
            label2.TabIndex = 0;
            label2.Text = "Room ID";
            // 
            // RoomsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 998);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Name = "RoomsForm";
            Text = "RoomsForm";
            Load += RoomsForm_Load;
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
        private RadioButton radioButtonAvailability;
        private RadioButton radioButtonType;
        private RadioButton radioButtonIdentity;
        private Button buttonSearch;
        private Label label1;
        private TextBox textBoxSearch;
        private GroupBox groupBox5;
        private DataGridView dataGridViewSeaarchResult;
        private GroupBox groupBox2;
        private DataGridView dataGridViewAllRooms;
        private GroupBox groupBox3;
        private Button buttonInsertCust;
        private Button buttonUpdateRoom;
        private Button buttonDeleteRoom;
        private TextBox textBoxRoomType;
        private TextBox textBoxRommNo;
        private TextBox textBoxRoomId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private TextBox textBoxRoomBooked;
        private TextBox textBoxRoomPrice;
        private TextBox textBoxRoomDescription;
        private TextBox textBoxRoomSeason;
        private TextBox textBoxRoomCapacity;
        private Label textRoomDescription;
        private Label textRoomSeason;
        private Label textRoomCapacity;
        private Button buttonExport;
        private Button buttonImportData;
    }
    
}