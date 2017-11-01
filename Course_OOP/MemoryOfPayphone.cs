using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_OOP
{
    public partial class MemoryOfPayphone : Form
    {
        struct Convers
        {
            public DateTime Start { get; set; }
            public DateTime End { get; set; }

            public string Number { get; set; }
        }
        class Record
        {
            public Record(string nameCard)
            {
                NameCard = nameCard;
                listConv = new List<Convers>();
            }
            public void AddConversation(DateTime start, DateTime end, string phoneNumber)
            { listConv.Add(new Convers { Start = start, End = end, Number = phoneNumber}); }

            public string NameCard { get; set; }
            public DateTime Put { get; set; }
            public DateTime Took { get; set; }
            public List<Convers> listConv;//якщо з однієї картки не один раз розмовляли
    
            public Record DeepCopy()
            {
                Record copyRecord = new Record(NameCard);
                copyRecord.Put = Put; copyRecord.Took = Took;
                copyRecord.listConv = listConv;
                copyRecord.listConv = new List<Convers>(); 
                foreach (Convers x in listConv)
                {
                    copyRecord.listConv.Add(x);
                }

                return copyRecord;
            }
        }

        List<Record> listRecords;
        Record currentRecord;
        DateTime dStart;
        string phNumber;
        //int count;
        int Volume;
        //bool memOverflow;
        //public bool IsMemoryOverflow { get { return memOverflow; } }
        public MemoryOfPayphone(int volume)
        {
            InitializeComponent();
            Volume = volume;
            Visible = false;
            FormClosing += (sender, e) => { e.Cancel = true; Visible = false; };               
            listRecords = new List<Record>();
            currentRecord = null;
            //count = 0; memOverflow = false;
        }

        //Вставили картку
        public void PutCard(string nameCard, DateTime datePut)
        {
            currentRecord = new Record(nameCard);//створюємо об'єкт Запис
            currentRecord.Put = datePut;//запис дати, коли вставили
            //if (count == Volume) memOverflow = true;
            //count++;
        }
     
        //Почали передачу даних
        public void StartConv(DateTime dateStart, string phoneNumber)
        { 
            dStart = dateStart;
            phNumber = phoneNumber;
        }

        //Закінчили передачу даних
        public void EndConv(DateTime dateEnd)
        {
            //currentRecord.AddConversation(dStart, dateEnd);
            currentRecord.AddConversation(dStart, dateEnd, phNumber);       
        }

        //Коли витягли картку
        public void TakeCard(DateTime dateTook)
        {
            currentRecord.Took = dateTook;
            //if(!memOverflow)//записати, якщо пам'ять не заповнена
            listRecords.Add(currentRecord.DeepCopy());
            currentRecord = null;
            if (listRecords.Count == 101)
                listRecords.Clear();
        }

        //Чи є поточний запис
        public bool IsCurrentRecord { get { return currentRecord != null; } }

        private void MemoryOfPayphone_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible == true)
            {
                string result = String.Empty;
                foreach (Record x in listRecords)
                {
                    result += x.NameCard + ": " + x.Put.ToString("HH:mm:ss dd.MM.yyy") + " - "
                           + x.Took.ToString("HH:mm:ss dd.MM.yyy") + Environment.NewLine;
                    string resConvers = String.Empty;
                    foreach(Convers y in x.listConv)
                        resConvers += "Номер: "+ y.Number + ":" + Environment.NewLine + "Почато: " + 
                            y.Start + "  Закінчено: " + y.End + Environment.NewLine;
                    result += resConvers + Environment.NewLine;
                }
                textBoxMemory.Text = result;
            }
        }

        //Щоб зберегти
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxMemory.Text == String.Empty)
                return;
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Text files|*.txt";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(textBoxMemory.Text);
                    sw.Close();
                }
            }
            textBoxMemory.Clear();
            listRecords.Clear();
            //count = 0; memOverflow = false;
        }

        //Очистити
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (textBoxMemory.Text == String.Empty)
                return;
            textBoxMemory.Clear();
            listRecords.Clear();
            //count = 0; memOverflow = false;
        }
    }
}
