namespace State_Design_Pattern_ATM_Demo
{
    public class HasCard : ATMState
    {
        public override void EjectCard(ATMMachine context)
        {
            Console.WriteLine("Kart Çıkartınız");
            context.State = new NoCard();
        }

        public override void InsertCard(ATMMachine context)
        {
            Console.WriteLine("Birden fazla kart ile işlem yapılamaz");
        }

        public override void InsertPin(ATMMachine context, int pin)
        {
            if (pin==123)
            {
                Console.WriteLine("pin doğru");
                context.CorrectPinEntered = true;
                context.State = new HasPin();
            }
        }

        public override void RequestCash(int cashToWithdraw, ATMMachine context) => Console.WriteLine("Lütfen önce pin giriniz");

    }
}