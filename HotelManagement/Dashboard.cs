﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Dashboard : Form
    {
        
        bool isFormOpen = false;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            foreach (Form openformGuestForm in Application.OpenForms)
            {
                if (openformGuestForm.Name == "GuestForm") // Replace with the actual form name
                {
                    isFormOpen = true;
                    openformGuestForm.BringToFront();
                    openformGuestForm.Activate();
                    break;
                }
            }

            if (!isFormOpen)
            {
                GuestForm guestForm = new GuestForm();
                guestForm.Show();
            }
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            foreach (Form openformLogin in Application.OpenForms)
            {
                if (openformLogin.Name == "Login") // Replace with the actual form name
                {
                    isFormOpen = true;
                    openformLogin.BringToFront();
                    openformLogin.Activate();
                    break;
                }
            }

            if (!isFormOpen)
            {
                Login login = new Login();
                login.Show();
            }
            
        }
    }
}
