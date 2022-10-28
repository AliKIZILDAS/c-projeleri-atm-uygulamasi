namespace atm_uygulamasi
{
    class kartSahib
    {
        private string cardNum;
        private int pin;
        private string firstName;
        private string lastName;
        private double balance;

        public string CardNum { get => cardNum; set => cardNum = value; }
        public int Pin { get => pin; set => pin = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Balance { get => balance; set => balance = value; }

        public kartSahib(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.CardNum = cardNum;
            this.Pin = pin;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Balance = balance;
        }

        public string getNum()
        {
            return CardNum;
        }

        public int getPin()
        {
            return Pin;
        }

        public string getFirstName()
        {
            return FirstName;
        }
         public string getLastName()
        {
            return LastName;
        }

         public double getBalance()
        {
            return Balance;
        }

        public void setNum(String newCardNum)
        {
            CardNum = newCardNum;
        }

         public void setPin(int newPin)
        {
            Pin = newPin;
        }

         public void setFirstName(String newFirstName)
        {
            FirstName = newFirstName;
        }

         public void setLastName(String newLastName)
        {
            LastName = newLastName;
        }

         public void setBalance(double newBalance)
        {
            Balance = newBalance;
        }
    }
}