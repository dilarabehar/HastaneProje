﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProje
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doctor_Login doctor_Login = new Doctor_Login();

            doctor_Login.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Patient_Login patient_Login = new Patient_Login();

            patient_Login.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Secretary_Login secretary_Login = new Secretary_Login();

            secretary_Login.Show();
            this.Hide();
        }
    }
}
