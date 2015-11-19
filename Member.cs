using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS220GroupProject
{
    class Member : Account
    {
        private int cardNum;

        private double balance;

        private List<int> rentalsHeld;


        public int CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public List<int> RentalsHeld
        {
            get { return rentalsHeld; }
            set { rentalsHeld = value; }
        }
    }
}
