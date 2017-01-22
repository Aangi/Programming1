using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming1
{
    class SendviaEmail
    {
        private String emailAddr;

        public SendviaEmail() { }

        public SendviaEmail(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public void setEmailAddr(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public String getEmailAddr()
        {
            return emailAddr;
        }

        public void sendEmailSubscribe()
        {
            MessageBox.Show("Congratulations!" + emailAddr + "Your email address has been added for subscription ");
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendEmailSubscribe;
        }

        public void sendEmailUnSubscribe()
        {
            MessageBox.Show("Your email address " + emailAddr + "has been removed from subscription");
        }

        public void UnSubscribe(Publisher pub)
        {
            pub.publishmsg -= sendEmailUnSubscribe;
        }
    }
}
