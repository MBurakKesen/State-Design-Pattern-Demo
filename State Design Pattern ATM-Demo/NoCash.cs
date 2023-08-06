namespace State_Design_Pattern_ATM_Demo
{
    public class NoCash : ATMState

    {
        public override void EjectCard(ATMMachine context) => Console.WriteLine("Para yok para :)");
        public override void InsertCard(ATMMachine context) => Console.WriteLine("Para yok para :)");
        public override void InsertPin(ATMMachine context, int pin) => Console.WriteLine("Para yok para :)");
        public override void RequestCash(int cashToWithdraw, ATMMachine context) => Console.WriteLine("Para yok para :)");
    }

}