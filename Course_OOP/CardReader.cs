using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP
{
    //Картоприймач
    class Cardreader
    {
        byte status; //стан картоприймача (є чи нема картки)
        PayCard payCardCurr;

        public string Name { get { return payCardCurr.Name; } } //назва картки        

        public string Credits { get { return payCardCurr.intPart.ToString() + "," + payCardCurr.decPart.ToString(); } }
        public int Status { get { return status; } }

        //Якщо одиниці на карточці закінчилися
        public event EventHandler moneySpent;
        public Cardreader()
        {
            payCardCurr = null;
            status = 3;
        }
        
        //Вставити картку
        public void Push(PayCard payCard)
        {
            payCardCurr = payCard;
            if (payCard.Damaged)
            {
                status = 2; //пошкоджена картка
                return;
            }
            if (payCard.decPart == 0 && payCard.intPart == 0)
            {
                status = 1;//немає одиниць
                return;
            }
            status = 0;//Normal

        }
        public void Decrement()
        {
            if (payCardCurr.decPart != 0)
                payCardCurr.decPart--;
            else
                if (payCardCurr.intPart != 0)
                {
                    payCardCurr.intPart--;
                    payCardCurr.decPart = 9;
                }
            if (payCardCurr.intPart == 0 && payCardCurr.decPart == 0)
            {
                status = 1;//немає одиниць
                moneySpent(this, new EventArgs());
            }
        }
        //Видалити картку з картоприймача
        public void Pop() 
        { 
            payCardCurr = null;
            status = 3;//немає картки
        }

    }

    /*Картка. Створюється при натисненні на кнопку*/
    class PayCard
    {
        bool damaged_;

        string name_;
        public int intPart { get; set; }
        public int decPart { get; set; }

        public string Name { get { return name_; } }
        public bool Damaged { get { return damaged_; } }
 
        //Якщо не пошкоджена:
        public PayCard(int intP, int decP, string name)
        {
            intPart = intP; decPart = decP;
            name_ = name;
            damaged_ = false;
        }
        public PayCard()
        {
            damaged_ = true;
            intPart = -1; decPart = 0;
            name_ = "#####";
        }
    }

    class CardNamer
    {
        int i;
        public CardNamer() { i = 0; }
        public string GetNameOfCard()
        {
            i++;
            return "Card #" + i.ToString();
        }

    }

}
