using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace vbuckscam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                Random random = new Random();

                int timeConnection = random.Next(1000, 3000);

                disableConnectButton(false);
                Thread.Sleep(timeConnection);
                MessageBox.Show("Email: " + textBox1.Text + " has been successfully connected!");
                MessageBox.Show("Password: " + textBox2.Text + " has been successfully connected!");
                float connectionEstablish = (float)timeConnection / 1000;
                MessageBox.Show("Connection established within: " + connectionEstablish + " seconds!");
                enableGeneration(true);
            }
            else
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Please enter an email address and password!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Please enter an password!");
                }
                else if(textBox1.Text == "")
                {
                    MessageBox.Show("Please enter an email address!");
                }
            }
        

        }           

        public void disableConnectButton(bool onOff)
        {
            button1.Enabled = onOff;
        }

        public void enableGeneration(bool e)
        {
            checkBox1.Visible = e;
            checkBox2.Visible = e;
            checkBox3.Visible = e;
            button2.Visible = e;
            button3.Visible = e;
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int vbucks = 5000;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;
            MessageBox.Show("Your V-Bucks amount has been assigned!");
   

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button1.Enabled == false && button2.Enabled == false)
            {
                Random GenRandom = new Random();
                int timeGeneration = GenRandom.Next(2000, 3500);
                Thread.Sleep(timeGeneration);
                MessageBox.Show("You have generated your V-Bucks... V-Bucks may take 1 minute to show up in-game");
                float procTime = (float)timeGeneration / 1000;
                MessageBox.Show("Process took " + timeGeneration + " seconds!");
            }
            else
            {
                MessageBox.Show("Please make sure you have selected your amount of V-Bucks or entered your email and password!");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int vbucks = 10000;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int vbucks = 12;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Password visible for 3 seconds!");
            textBox2.UseSystemPasswordChar = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
