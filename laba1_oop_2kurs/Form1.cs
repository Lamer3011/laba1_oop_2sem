using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1_oop_2kurs
{
    public partial class Form1 : Form
    {
        int countPass = 3;
        string username, pass;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = logBox.Text;
            pass = passBox.Text;

            if (username == "Kireev" && pass == "pass111")
            {
                button1.BackColor = Color.Green;
                MessageBox.Show($"Welcome {username}. Your password is right",
                    "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                countPass--;
                MessageBox.Show($"Incorrect password for {username}" +
                    $"{countPass}",
                    "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.BackColor = Color.Red;
                if(countPass == 0) button1.Enabled = false;
            }

            
        }
    }
}
