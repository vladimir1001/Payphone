using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
//using System.Threading;
using WMPLib;
using System.Windows.Media;


namespace Course_OOP
{
    public partial class FormPayphone : Form
    {
        GifImage gifImageObj;
        bool direction, isPhoneReadyToNumber = false, isCardPushed = false,
            isHandsetPut = true;//чи покладена трубка
            //isMemoryOverflow = false;
        string phoneNumber;
        Timer timer1,//таймер для анімації
            timer2;//таймер розмови

        int sec, min, hours;

        Cardreader cReader; //картоприймач
        CardNamer cNamer; //називає картку, якщо ім'я не задали
        FormATS fATS;
        FormHandSet handSet;
        MemoryOfPayphone memoryModule;
        public FormPayphone()
        {
            InitializeComponent();
            memoryModule = new MemoryOfPayphone(15); //створити модуль пам'яті об'ємом 15 записів
            handSet = new FormHandSet();//трубка
            fATS = new FormATS();//АТС
            fATS.IsAlready += (sender, e) => //Коли АТС готова для прийняття цифр
            {
                isPhoneReadyToNumber = true;
                PlayTonesLooping("PhoneIsReady.WAV");
            };
            fATS.LineIsBusy += (sender, e) =>//Коли АТС зайнята            
            {
                isPhoneReadyToNumber = false;
                PlayTonesLooping("LineIsBusy.WAV");
            };
            fATS.NumberIsEntered += (sender, e) => isPhoneReadyToNumber = false;//Коли номер набраний        
            fATS.WaitingAbonent += (sender, e) => PlayTonesLooping("WaitingAbonent.WAV");

            fATS.StartSpendingMoney += WhenTaken;//подія, коли знімаються гроші

            handSet.VisibleChanged += WhenHandsetClosed;//Подія, коли поклали трубку
            handSet.MessageSend += fATS.textBoxReceiving;//Передача даних в АТС
            fATS.MessageSend += handSet.textReceiving;//Передача даних у трубку

            pictureMemory.Parent = pictureMainTheme;
            Reseter.Parent = pictureMainTheme;

            Reseter.Visible = false;
            cReader = new Cardreader(); cNamer = new CardNamer();//називає картку, якщо користувач увів ім'я
            cReader.moneySpent += WhenMoneySpent;//обробник, коли одиниці витрачені
           
            timer1 = new Timer(); timer1.Enabled = false;//Таймер анімації           
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);//підписатися на Таймер 

            timer2 = new Timer(); timer2.Enabled = false; timer2.Interval = 1000;
            timer2.Tick += ShowSeconds;
        }

        //Для звукових ефектів
        public static void Play_wmp(object str)
        {
            //var wmp = new WindowsMediaPlayer();
            //wmp.URL = str as string;
            //wmp.controls.play();

            MediaPlayer mpUri = new MediaPlayer();
            mpUri.Open(new Uri(str as string, System.UriKind.Relative));
            mpUri.Play();
        }
        //Взяти трубку
        private void Handset_Click(object sender, EventArgs e)
        {
            System.Threading.Thread myThread = new System.Threading.Thread(Play_wmp);
            myThread.Start("Pick_up.mp3");

            memoryModule.Visible = false;

            if(isCardPushed)//якщо вставлено картку, підняли трубку, почати запис в пам'ять
                memoryModule.PutCard(cReader.Name, DateTime.Now);
      
            handSet.Visible = true;
            textScreen.BackColor = System.Drawing.Color.FromArgb(155, 196, 113); //Экран засветится
            mainHandSet.Visible = false; //Трубка стає невидимою
            Reseter.Visible = true;//Reseter видимий

            isHandsetPut = false; //трубка не покладена
            ShowInScreen(); //відновити екран Таксофона
            if (cReader.Status == 0)//Якщо є одиниці на картці, показати форму "АТС"
                fATS.Visible = true;           
        }        

        //Обробник, коли поклали трубку
        void WhenHandsetClosed(object sender, EventArgs e)
        {
            if (handSet.Visible == true)
                return;
            System.Threading.Thread myThread_ = new System.Threading.Thread(FormPayphone.Play_wmp);
            myThread_.Start("Put_down.mp3");

            phoneNumber = "";//буферний рядок "номер"
            
            if (timer2.Enabled)//NEW
                memoryModule.EndConv(DateTime.Now);

            timer2.Enabled = false;//Виключити таймер (6с)
            Reseter.Visible = false;
            mainHandSet.Visible = true; //Трубка стає видимою
            isHandsetPut = true;

            //Якщо картки немає, екран погасне
            if (!isCardPushed)
            {
                textScreen.Text = "";
                textScreen.BackColor = System.Drawing.Color.FromArgb(44, 60, 49);
            }
            else
                textScreen.Text = "Витягніть картку!";

            isPhoneReadyToNumber = false;//Таксофон не готовий до набору
            if (fATS.Visible)//Згорнути форму АТС, коли поклали трубку
                fATS.Visible = false;
            if (wmpTone != null)
            {
                wmpTone.controls.stop();
                wmpTone = null;
            }

        }

        void ShowInScreen()
        {
            //if (memoryModule.IsMemoryOverflow)//якщо пам'ять переповнена
            //{
            //    fATS.Visible = false;
            //    textScreen.Text = "Пам'ять заповнена!";
            //}
            //else
            switch (cReader.Status)
            {
                case 0: textScreen.Text = "Залишилось: " + cReader.Credits + " од.";
                    break;
                case 1:
                    textScreen.Text = "Немає одиниць!";
                    break;
                case 2:
                    textScreen.Text = "Картка пошкоджена!";
                    break;
                case 3:
                    textScreen.Text = "Вставте картку!";
                    break;
            }
        }

        //Reset
        private void Reseter_Click(object sender, EventArgs e)
        {
            System.Threading.Thread myThread = new System.Threading.Thread(Play_wmp);
            myThread.Start("Reset.mp3"); //Play_wmp("Reset.mp3");

            handSet.ClearReceivingText();
            phoneNumber = "";
            if (timer2.Enabled)
                memoryModule.EndConv(DateTime.Now);
            timer2.Enabled = false;
            isPhoneReadyToNumber = false;
            //Виключити гудок
            if (wmpTone != null)
            {
                wmpTone.controls.stop();
                wmpTone = null;
            }
            
            if (cReader.Status == 0 && !isHandsetPut)
            {
                fATS.Visible = false;
                fATS.Visible = true;
                textScreen.Text = "Залишилось: " + cReader.Credits + " од.";
            }
        }

        //Натиснули "Вставити картку"
        private void bPutTheCard_Click(object sender, EventArgs e)
        {
            buttonPutTheCard.Enabled = false; //Зробити дану кнопку неактивною
            numericAccount.Enabled =  //зробити Рахунок неактивним
            textBox_NameCard.Enabled =  //Поле Ім'я - неактивне
            checkBox_Damaged.Enabled = false; //CheckBox - неактивне

            memoryModule.Visible = false;

            System.Threading.Thread myThread = new System.Threading.Thread(Play_wmp);
            myThread.Start("Voice_card_SHH.mp3"); //Play_wmp("Voice_card_SHH.mp3");
            gifImageObj = new GifImage("Put_card_minimized.gif");//Включити анімацію, як вставляється картка
            direction = true;    //картка вставляється
                            
            timer1.Enabled = true;//увімкнути таймер

            PayCard currentCard;
            //Створюється картка, згідно з введеними даними            
            if (checkBox_Damaged.Checked)
                currentCard = new PayCard();
            else
            {
                string name = (textBox_NameCard.Text.ToString() == String.Empty) ? cNamer.GetNameOfCard() : textBox_NameCard.Text.ToString();

                string value_ = String.Format("{0:0.0}", numericAccount.Value);               
                var arr = value_.Split(',', '.');
                int val1 = Convert.ToInt32(arr[0]), val2 = Convert.ToInt32(arr[1]);
                currentCard = new PayCard(val1, val2, name);
            }
            cReader.Push(currentCard);
        }

        //Натиснути, щоб витягнути картку
        private void pictureCardReader_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled)
                memoryModule.EndConv(DateTime.Now);
            timer2.Enabled = false;
            phoneNumber = "";//рядок "номер"
            pictureCardReader.Enabled = false;
            System.Threading.Thread myThread = new System.Threading.Thread(Play_wmp);
            myThread.Start("Voice_card_Take.mp3"); //Play_wmp("Voice_card_Take.mp3");
            gifImageObj = new GifImage("Take_card_minimized.gif");
            direction = false;//картка виймається
            timer1.Enabled = true;//увімкнути таймер
            cReader.Pop();

            handSet.ClearReceivingText();

            if (!isHandsetPut)
                ShowInScreen();
            else
            {
                textScreen.Text = String.Empty;
                textScreen.BackColor = System.Drawing.Color.FromArgb(44, 60, 49);
            }
                
            if (fATS.Visible)
                fATS.Visible = false;

            //Виключити гудок, якщо він є
            if (wmpTone != null)
            {
                wmpTone.controls.stop();
                wmpTone = null;
            }
        }

        //На кожний тік таймера отримується кадр анімації
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureCardReader.Image = gifImageObj.GetNextFrame();
            }
            catch (ArgumentOutOfRangeException)
            {
                if (direction)//якщо вставили картку
                {
                    pictureCardReader.Image = Properties.Resources.Card_pushed;
                    pictureCardReader.Enabled = true;
                    //Якщо екран світиться:
                    if (textScreen.BackColor == System.Drawing.Color.FromArgb(155, 196, 113))
                            ShowInScreen();
                    isCardPushed = true;
  
                    //Показати АТС
                    if (!fATS.Visible && textScreen.BackColor == System.Drawing.Color.FromArgb(155, 196, 113)
                && cReader.Status == 0)
                            fATS.Visible = true;

                    if(!isHandsetPut)//NEW
                        memoryModule.PutCard(cReader.Name, DateTime.Now);
                }
                else//якщо витягнули картку
                {
                    pictureCardReader.Image = Properties.Resources.CardReader;
                    buttonPutTheCard.Enabled = true;
                    checkBox_Damaged.Enabled = true; //CheckBox - активне
                    isCardPushed = false;
                    if (!checkBox_Damaged.Checked)
                    {
                        numericAccount.Enabled = true; //Рахунок - активне
                        textBox_NameCard.Enabled = true; //Ім'я - активне
                    }

                    if (memoryModule.IsCurrentRecord)//NEW
                        memoryModule.TakeCard(DateTime.Now);
                }
                timer1.Enabled = false;
            }
        }

        //Якщо checkbox активований
        private void checkBox_Damaged_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Damaged.Checked == true)
            {
                numericAccount.Enabled = false;
                textBox_NameCard.Enabled = false;
                return;
            }
            numericAccount.Enabled = true;
            textBox_NameCard.Enabled = true;
        }

        //Набор номера
        private void Num_Click(object sender, EventArgs e)
        {
            System.Threading.Thread myThread = new System.Threading.Thread(Play_wmp);
            myThread.Start("button_.mp3");  //Play_wmp("button_.mp3");

            if (!isPhoneReadyToNumber) //якщо таксофон не готовий до набору
            {
                phoneNumber = "";
                return;
            }
            //Якщо почав набиратися номер, виключити гудок
            if (wmpTone != null)
            {
                wmpTone.controls.stop();
                wmpTone = null;
            }

            Button b = sender as Button;
            if (b.Name == "button_sharp" || b.Name == "button_asterisk")
                return;
            
            //button_1
            //    button_1
            //    button_2

            //Набор номера           
            fATS.addNumberOfButton(b.Text);
            phoneNumber += b.Text;
            textScreen.Text = phoneNumber;
        }

        private WindowsMediaPlayer wmpTone; 
        void PlayTonesLooping(string str)
        {
            wmpTone = new WindowsMediaPlayer();
            wmpTone.settings.setMode("loop", true);
            wmpTone.URL = str;
            wmpTone.controls.play();
        }

        //Коли АТС з'єднала
        void WhenTaken(object sender, EventArgs e)
        {
            if (wmpTone != null)
            {
                wmpTone.controls.stop();
                wmpTone = null;
            }
            fATS.MakeEnabled();
            handSet.MakeEnabled();
            memoryModule.StartConv(DateTime.Now, fATS.getNumber);
            sec = 0; min = 0; hours = 0;    
            timer2.Enabled = true;//Віднімає 0,1 одиницю за 6 секунд                     
        }


        void ShowSeconds(object sender, EventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                min++;
                sec = 0;
            }
            if(min == 60)
            {
                hours++;
                min = 0;
            }
            if (sec % 6 == 0)
                cReader.Decrement();//віднімати 0.1 одиницию за 6 секунд
            if (cReader.Status == 0)
            {
                textScreen.Text = "    " + (hours < 10 ? "0"+ hours.ToString() :  hours.ToString()) + 
                    ":" + (min < 10? "0"+min.ToString() :  min.ToString()) +
                    ":" + (sec < 10 ? "0" + sec.ToString() : sec.ToString());
                textScreen.Text += Environment.NewLine + "    " + cReader.Credits + " од.";
            }
        }

        //Обробник, коли одиниці витрачено
        void WhenMoneySpent(object sender, EventArgs e)
        {
            if (timer2.Enabled)//NEW
                memoryModule.EndConv(DateTime.Now);
            timer2.Enabled = false;
            textScreen.Clear();
            ShowInScreen();
            handSet.MakeDisabled();//виключити у трубці відправку даних
            fATS.MakeDisabled();//виключити у АТС відправку даних
            fATS.Visible = false;//приховати            
        }
                
        //Натиснути на область модулю пам'яті
        private void pictureMemory_Click(object sender, EventArgs e)
        {
            if(isHandsetPut && !isCardPushed)
                memoryModule.Visible = true;
        }
    }

}
