using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming1
{
    class SendviaMobile
    {
        private String cellPhone;

        public SendviaMobile() { }

        public SendviaMobile(String phone)
        {
            cellPhone = phone;
        }

        public void setMobile(String phone)
        {
            cellPhone = phone;
        }

        public String getMobile()
        {
            return cellPhone;
        }

        private void sendMessageSubscribe()
        {
            MessageBox.Show(" Congratulations! " + cellPhone + "Your mobile number has been added for subscription ");
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendMessageSubscribe;
        }

        public void sendMessageUnSubscribe()
        {
            MessageBox.Show("Your mobile number " + cellPhone + "has been removed from subscription");
        }
        public void UnSubscribe(Publisher pub)
        {
            pub.publishmsg -= sendMessageUnSubscribe;
        }
    }
}
