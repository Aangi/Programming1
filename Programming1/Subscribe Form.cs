using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming1
{
    public partial class Subscribe_Form : Form
    {
        List<string> listEmail;
        List<string> listMobile;

        public Subscribe_Form()
        {
            InitializeComponent();
            listEmail = new List<string>();
            listMobile = new List<string>();
        }

        Publisher publish = new Publisher();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate() == false)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                if (listEmail.Contains(textBox1.Text) || listMobile.Contains(textBox2.Text))
                {
                    MessageBox.Show(textBox1.Text + " " + textBox2.Text + "has been subscribed");
                }
                else
                {
                    if (checkBox1.Checked == false && checkBox2.Checked == false)
                    {
                        MessageBox.Show("Select any one");
                    }
                    else
                    {
                        SendviaEmail sendEmail = new SendviaEmail(textBox1.Text);
                        SendviaMobile sendPhone = new SendviaMobile(textBox2.Text);

                        sendEmail.Subscribe(publish);
                        sendPhone.Subscribe(publish);
                        publish.PublishMessage();
                        listEmail.Add(textBox1.Text);
                        listMobile.Add(textBox2.Text);
                    }
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validate() == false)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                if (listEmail.Contains(textBox1.Text) || listMobile.Contains(textBox2.Text))
                {
                    SendviaEmail sendEmail = new SendviaEmail(textBox1.Text);
                    SendviaMobile sendPhone = new SendviaMobile(textBox2.Text);

                    sendEmail.UnSubscribe(publish);
                    sendPhone.UnSubscribe(publish);
                    publish.PublishMessage();
                    listEmail.Remove(textBox1.Text);
                    listMobile.Remove(textBox2.Text);
                }
                else
                {
                    MessageBox.Show(textBox1.Text + " " + textBox2.Text + " has not been subscribed");
                }
            }
        }

        public bool validate()
        {
            System.Text.RegularExpressions.Regex mobileValidate = new System.Text.RegularExpressions.Regex(@"^([0-9]{3}[\-][0-9]{3}[\-][0-9]{4})$");
            System.Text.RegularExpressions.Regex emailValidate = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (checkBox1.Checked && !emailValidate.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Write your correct email address");
                return false;
            }

            else if (checkBox2.Checked && !mobileValidate.IsMatch(textBox2.Text))
            {
                MessageBox.Show("Write your correct mobile number");
                return false;

            }
            else
            {
                return true;
            }

        }
    }
}
        
