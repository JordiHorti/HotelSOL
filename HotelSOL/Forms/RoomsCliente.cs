﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSOL.Cliente
{
    public partial class RoomsCliente : Form
    {
        public RoomsCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonVerHabitaciones_Click(object sender, EventArgs e)
        {
            VerHabitaciones verHabitaciones = new VerHabitaciones();
            verHabitaciones.Show();
        }
    }
}
