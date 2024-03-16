namespace HotelSOL.Cliente
{
    partial class RoomsCliente
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
            groupBox2 = new GroupBox();
            ButtonMisReservas = new Button();
            groupBox3 = new GroupBox();
            ButtonVerHabitaciones = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ButtonMisReservas);
            groupBox2.Location = new Point(145, 251);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(466, 105);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ver Mis Reservas";
            // 
            // ButtonMisReservas
            // 
            ButtonMisReservas.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonMisReservas.Location = new Point(14, 40);
            ButtonMisReservas.Margin = new Padding(3, 2, 3, 2);
            ButtonMisReservas.Name = "ButtonMisReservas";
            ButtonMisReservas.Size = new Size(438, 32);
            ButtonMisReservas.TabIndex = 0;
            ButtonMisReservas.Text = "Mis Reservas";
            ButtonMisReservas.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ButtonVerHabitaciones);
            groupBox3.Location = new Point(145, 102);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(466, 105);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ver Habitaciones";
            // 
            // ButtonVerHabitaciones
            // 
            ButtonVerHabitaciones.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonVerHabitaciones.Location = new Point(14, 40);
            ButtonVerHabitaciones.Margin = new Padding(3, 2, 3, 2);
            ButtonVerHabitaciones.Name = "ButtonVerHabitaciones";
            ButtonVerHabitaciones.Size = new Size(438, 32);
            ButtonVerHabitaciones.TabIndex = 0;
            ButtonVerHabitaciones.Text = "Ver Habitaciones";
            ButtonVerHabitaciones.UseVisualStyleBackColor = true;
            // 
            // RoomsCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 512);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "RoomsCliente";
            Text = "RoomsCliente";
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button ButtonAlquilarHabitacion;
        private GroupBox groupBox2;
        private Button ButtonMisReservas;
        private GroupBox groupBox3;
        private Button ButtonVerHabitaciones;
    }
}