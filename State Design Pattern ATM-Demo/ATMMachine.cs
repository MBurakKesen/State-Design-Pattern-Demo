namespace State_Design_Pattern_ATM_Demo
{
    public class ATMMachine
    {
        ATMState state = new NoCard();
        public ATMState State { set { state = value; } }


        public int CashInMachine { get; set; } = 2000;
        public bool CorrectPinEntered { get; set; } = false;


        public void InsertCard() => state.InsertCard(this);
        public void EjectCard() => state.EjectCard(this);
        public void InsertPin(int pin) => state.InsertPin(this, pin);
        public void RequestCash(int cashToWithdraw) => state.RequestCash(cashToWithdraw, this);
    }
}
