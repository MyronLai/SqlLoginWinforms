﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlWindowsFormsBankLogin
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
            BankAcountPage acountPage = new BankAcountPage();
            acountPage.Show();
        }

    
    }
}
