﻿using HotelSOL.Models;
using NHibernate;
using System.Collections.Generic;
using System.Data;

namespace HotelSOL.DAO
{
    public class InvoiceDAO
    {
        private ISession _session;

        public InvoiceDAO(ISession session)
        {
            _session = session;
        }

        public DataTable GetInvoicesForCustomer(string customerName, string customerEmail)
        {
            // Crear la consulta HQL para obtener las facturas del cliente dado por su nombre y correo electrónico
            var query = @"FROM Invoice WHERE customerName = :customerName AND customerEmail = :customerEmail";

            // Ejecutar la consulta utilizando NHibernate
            var invoices = _session.CreateQuery(query)
                                  .SetParameter("customerName", customerName)
                                  .SetParameter("customerEmail", customerEmail)
                                  .List<Invoice>();

            // Convertir la lista de facturas a un DataTable para enlazarlo al DataGridView
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Invoice ID");
            dataTable.Columns.Add("Customer Name");
            dataTable.Columns.Add("Customer Email");
            dataTable.Columns.Add("Service");
            dataTable.Columns.Add("Room Number");
            dataTable.Columns.Add("Room Capacity");
            dataTable.Columns.Add("CheckIn");
            dataTable.Columns.Add("CheckOut");
            dataTable.Columns.Add("Days");
            dataTable.Columns.Add("Total Price");






            foreach (var invoice in invoices)
            {
                dataTable.Rows.Add(invoice.invoices_id, invoice.customerName, invoice.customerEmail,invoice.service,invoice.roomNumber,invoice.roomCapacity,invoice.checkIn,invoice.checkOut,invoice.days,invoice.totalPrice);
            }

            return dataTable;
        }
    }
}
