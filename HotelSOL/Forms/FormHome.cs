using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSOL.DAO;
using HotelSOL.Models;
using HotelSOL.Nhibernate;
using NHibernate;
using HotelSOL.Forms;


namespace HotelSOL
{
    public partial class FormHome : Form
    {
        private IDAO<Customer> _customerDAO;
        private NhibernateUtils _nhibernateUtils;


        public FormHome()
        {
            InitializeComponent();
            _nhibernateUtils = new NhibernateUtils() ?? throw new ArgumentNullException(nameof(_nhibernateUtils));
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //open customers form

            CustomersForm customersForm = new CustomersForm();
            customersForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.Show();
        }

        private void button4AddUser_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
        }
    }
}
