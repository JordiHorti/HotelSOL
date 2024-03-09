﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HotelSOL
{
    public partial class RoomsForm : Form
    {
        private string CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();

        public RoomsForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            showDataRooms();
        }

        private void showDataRooms()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("SELECT * FROM rooms", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllCustomers.DataSource = dt;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            bool idSearchSlected = radioButtonIdentity.Checked;
            bool typeSearchSelected = radioButtonType.Checked;
            bool availabilitySearchSelected = radioButtonAvailability.Checked;
            string textToSearch = textBoxSearch.Text;


            if (idSearchSlected)
            {
                MessageBox.Show("Identity search selected");
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM rooms WHERE IdentityNo = @IdentityNo", conn);
                    cmd.Parameters.AddWithValue("@IdentityNo", textToSearch);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        adpt.Fill(dt);
                        dataGridViewSeaarchResult.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        string errorMessage = $"Connection Error: {ex.Message}";
                        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (typeSearchSelected)
            {
                MessageBox.Show("Type search selected");
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM rooms WHERE type = @type", conn);
                    cmd.Parameters.AddWithValue("@type", textToSearch);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        adpt.Fill(dt);
                        dataGridViewSeaarchResult.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        string errorMessage = $"Connection Error: {ex.Message}";
                        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (availabilitySearchSelected)
            {
                MessageBox.Show("Availability search selected");
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM rooms WHERE booked = @booked", conn);

                    int bookedValue = textToSearch.ToLower() == "true" ? 1 : 0;

                    cmd.Parameters.AddWithValue("@booked", bookedValue);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        adpt.Fill(dt);
                        dataGridViewSeaarchResult.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        string errorMessage = $"Connection Error: {ex.Message}";
                        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonInsertCust_Click(object sender, EventArgs e)
        {
            string roomId = textBoxRoomId.Text;
            string roomNo = textBoxRommNo.Text;
            string roomType = textBoxRoomType.Text;
            double price;
            bool booked;


            // Convertir el valor de price a double
            if (!double.TryParse(textBoxRoomPrice.Text, out price))
            {
                // Si el valor ingresado no es un número válido, salta mensaje de error
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir el valor de booked a bool
            if (!bool.TryParse(textBoxRoomBooked.Text, out booked))
            {
                // Si el valor ingresado no es "true" o "false",salta mensaje error
                MessageBox.Show("El valor de 'booked' debe ser 'true' o 'false'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(roomId) || String.IsNullOrEmpty(roomNo) || String.IsNullOrEmpty(roomType))
            {
                MessageBox.Show("No empty fields allowed except email address of the customer");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();


                    // Verificar si la tabla rooms existe, y si no existe, crearla
                    SqlCommand createTableCmd = new SqlCommand("IF OBJECT_ID('dbo.rooms', 'U') IS NULL CREATE TABLE rooms (IdentityNo VARCHAR(20), roomNumber INT, type VARCHAR(100), price DECIMAL,booked bit)", conn);
                    createTableCmd.ExecuteNonQuery();

                    // Insertar la habitacion en la tabla rooms
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO rooms (IdentityNo, roomNumber, type, price, booked) VALUES (@IdentityNo, @roomNo, @roomType, @price, @booked)", conn);
                    insertCmd.Parameters.AddWithValue("@IdentityNo", roomId);
                    insertCmd.Parameters.AddWithValue("@roomNo", roomNo);
                    insertCmd.Parameters.AddWithValue("@roomType", roomType);
                    insertCmd.Parameters.AddWithValue("@price", price);
                    insertCmd.Parameters.AddWithValue("@booked", booked);

                    insertCmd.ExecuteNonQuery();

                    showDataRooms();
                    MessageBox.Show("Room added successfully");
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Connection Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void buttonUpdateRoom_Click(object sender, EventArgs e)
        {
            string roomId = textBoxRoomId.Text;
            string roomNo = textBoxRommNo.Text;
            string roomType = textBoxRoomType.Text;
            double price;
            bool booked;
            if (!double.TryParse(textBoxRoomPrice.Text, out price))
            {
                // Si el valor ingresado no es un número válido, salta mensaje de error
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir el valor de booked a bool
            if (!bool.TryParse(textBoxRoomBooked.Text, out booked))
            {
                // Si el valor ingresado no es "true" o "false",salta mensaje error
                MessageBox.Show("El valor de 'booked' debe ser 'true' o 'false'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(roomId) || String.IsNullOrEmpty(roomNo) || String.IsNullOrEmpty(roomType))
            {
                MessageBox.Show("No empty fields allowed except email address of the customer");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    SqlCommand updateCmd = new SqlCommand("UPDATE rooms SET  roomNumber = @roomNo, type = @roomType,price= @price,booked = @booked WHERE IdentityNo = @roomId", conn);
                    updateCmd.Parameters.AddWithValue("@roomNo", roomNo);
                    updateCmd.Parameters.AddWithValue("@roomType", roomType);
                    updateCmd.Parameters.AddWithValue("@price", price);
                    updateCmd.Parameters.AddWithValue("@booked", booked);
                    updateCmd.Parameters.AddWithValue("@roomId", roomId);

                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Customer updated successfully!");

                    showDataRooms();

                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Connection Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteCust_Click(object sender, EventArgs e)
        {
            string room_identityNo = textBoxRoomId.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();

                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM rooms WHERE IdentityNo = @room_identityNo", conn);

                    deleteCmd.Parameters.AddWithValue("@room_identityNo", room_identityNo);
                    deleteCmd.ExecuteNonQuery();

                    MessageBox.Show("Room deleted successfully!");

                    showDataRooms();

                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Connection Error: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
