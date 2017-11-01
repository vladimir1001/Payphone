using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Course_OOP
{
    
    public partial class FormHandSet : Form
    {
        public FormHandSet()
        {
            InitializeComponent();
            pictureSend.Parent = pictureMainTheme;
            VisibleChanged += VChanged;
            pictureSend.Enabled = false;
            FormClosing += (sender, e) =>
            {
                e.Cancel = true;
                Visible = false;
            };
        }

        void VChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
                MakeDisabled();
        }

        public event EventHandler<EventArgsMessage> MessageSend;
        //Надіслати дані на АТС
        private void pictureSend_Click(object sender, EventArgs e)
        {
            MessageSend(this, new EventArgsMessage(textSend.Text.ToString()));
            textSend.Clear();
        }

        //Отримати дані з АТС
        public void textReceiving(object sender, EventArgsMessage e)
        {
            textReceive.Text = e.Message;
        }

        public void MakeEnabled()
        {
            pictureSend.Enabled = true;
        }
        public void MakeDisabled()
        {
            pictureSend.Enabled = false;
            textReceive.Clear();
            textSend.Clear();
        }
        public void ClearReceivingText()
        {
            textReceive.Clear();
        }

    }    
}