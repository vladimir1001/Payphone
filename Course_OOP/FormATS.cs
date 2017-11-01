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
    public partial class FormATS : Form
    {
        string number;
        int countToLeave, countNumber;
        Timer tmrShow;
        bool isCalling;
        public int Count { get; set; }

        public event EventHandler IsAlready;//Якщо АТС готова для прийняття номеру

        public FormATS()
        {            
            InitializeComponent();
            bSend.Enabled = false;
            tmrShow = new Timer(); // новий таймер
            tmrShow.Enabled = false;
            tmrShow.Tick += SignalHandSet;
            bTake.Enabled = false;

            //Подія, коли натиснули "Прийняти"
            bTake.Click += (sender_, e_) =>
                {
                    /*Дозволити вводити Дані в трубці та в АТС*/
                    StartSpendingMoney(sender_, e_);
                    bTake.Enabled = false;
                };

        }

        public void MakeEnabled()
        {
            bSend.Enabled = true;
        }

        public void MakeDisabled()
        {
            bSend.Enabled = false;
        }

        public string getNumber { get { return textBoxNumber.Text; } }

        //Набор номера
        public void addNumberOfButton(string N)
        {
            if (!this.Visible)
                return;           
            number += N;
            textBoxNumber.Text = number;
            countNumber++;
            if (countNumber == 7)
            {
                NumberIsEntered(this, new EventArgs());
                Calling();
                //return;
            }
        }

        void Calling()
        {
            //4 секунди почекати, чи зайнятий адресат
            bIsBusyLine.Visible = true;//Кнопка зайнято видима
            bIsBusyLine.Text = "Лінія зайнята? (4)";
            countToLeave = 3;
            isCalling = true; //відбувся набор номера
            tmrShow.Enabled = true;
            
        }

        //Коли форма приховалась або відкрилась
        private void FormATS_Shown(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                bSend.Enabled = false;//кнопка передати
                bTake.Enabled = false; //кнопка прийняти
                textAnswer.Clear();
                textSend.Clear();
                isCalling = false;//Набору номера не відбувається
                bIsBusyLine.Visible = true;//Кнопка зайнято видима
                bIsBusyLine.Text = "Лінія зайнята? (5)";
                countToLeave = 4;
                textBoxNumber.Clear();
                number = String.Empty;
                countNumber = 0;
                tmrShow.Interval = 1000; // інтервал виконання події через 1 секунду                
                tmrShow.Enabled = true;// увімкнути таймер
                return;
            }
            //Якщо форма стала невидимою
            tmrShow.Enabled = false;  
        }

        //Через кожну секунду
        private void SignalHandSet(object sender, EventArgs e)
        {
            //Коли пройшло 5 секунд
            if (countToLeave == -1)
            {
                tmrShow.Enabled = false;//Зупинити таймер
                bIsBusyLine.Visible = false;//Кнопка "Зайнято" невидима
                if (isCalling)//якщо був набор номера
                {
                    bTake.Enabled = true; //кнопка прийняти активна
                    WaitingAbonent(this, e); //подія очікування абонента
                }
                else
                    IsAlready(this, e);  //Передати подію "Тон"
                return;
            }
            bIsBusyLine.Text = "Лінія зайнята? (" + countToLeave.ToString() + ")";
            countToLeave--;
        }

        public event EventHandler WaitingAbonent;//довгі гудки
        public event EventHandler StartSpendingMoney;//перервати довгі гудки, почати витрачати кошти
        public event EventHandler LineIsBusy;//подія "зайнято"
        public event EventHandler NumberIsEntered;//коли номер введено
        public event EventHandler<EventArgsMessage> MessageSend;//відправлення даних

        //Якщо лінія зайнята
        private void bIsBusyLine_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LineIsBusy(sender, e);
        }

        //Надіслати дані у трубку
        private void bSend_Click(object sender, EventArgs e)
        {
            MessageSend(this, new EventArgsMessage(textSend.Text.ToString()));
            textSend.Clear();
        }

        //Отримати дані з трубки
        public void textBoxReceiving(object sender, EventArgsMessage e)
        {
            textAnswer.Text = e.Message;
        }
    }
}
