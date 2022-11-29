using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class Register : Form
    {
        TcpClient tcpClient;
        StreamWriter streamWriter;
        public Register()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            /*StartPage startPage = new StartPage();
            startPage.Show();*/
            /*this.Hide();*/
            MessageBox.Show("Please select your Gender!!");

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (Validation.Valid_UserName(txtUsername.Text))
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    if (Validation.Valid_password(txtPassword.Text))
                    {
                        
                            if (comGender.Text != "")
                            {
                                tcpClient = new TcpClient();
                                tcpClient.Connect("127.0.0.1", 5000);
                                NetworkStream networkStream = tcpClient.GetStream();
                                streamWriter = new StreamWriter(networkStream);
                                StreamReader streamReader = new StreamReader(networkStream);
                                streamWriter.AutoFlush = true;
                                await streamWriter.WriteLineAsync("Register" + "&" + txtUsername.Text + "&" + txtPassword.Text + "&" + comGender.Text);
                                string confirm = await streamReader.ReadLineAsync();
                                if (confirm == "True")
                                {
                                    MainPage mainPage = new MainPage(tcpClient);
                                    mainPage.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show(confirm);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please select your Gender!!");
                            }
                        
                    }
                    else
                    {
                        MessageBox.Show("Password should contains more than 8 characters consists of lower and upper case letters and digits !!");
                    }
                }
                else
                {
                    MessageBox.Show("Password doesn't match !!");
                }
            }
            else
            {
                MessageBox.Show("Username should contains more than 4 characters !!");
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
