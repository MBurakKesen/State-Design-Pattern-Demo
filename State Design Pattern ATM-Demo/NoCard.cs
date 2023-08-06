namespace State_Design_Pattern_ATM_Demo
{
    public class NoCard : ATMState
    {
        public override void EjectCard(ATMMachine context) => Console.WriteLine("kartı takınız");
       

        public override void InsertCard(ATMMachine context)
        {
            Console.WriteLine("Lütfen pin giriniz.");
            context.State = new HasCard();
        }

        public override void InsertPin(ATMMachine context, int pin) => Console.WriteLine("Lütfen önce kartı takınız");


        public override void RequestCash(int cashToWithdraw, ATMMachine context) => Console.WriteLine("Lütfen önce kartı takınız");

    }
}