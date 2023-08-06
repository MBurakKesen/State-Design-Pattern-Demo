namespace State_Design_Pattern_ATM_Demo
{
    public class HasPin : ATMState
    {
        public override void EjectCard(ATMMachine context)
        {
            Console.WriteLine("Kart çıkarıldı");
            context.State = new NoCard();
        }

        public override void InsertCard(ATMMachine context) => Console.WriteLine("Birden çok kart ile işlem yapılamaz");

        public override void InsertPin(ATMMachine context, int pin)
        {
            Console.WriteLine("Pin çoktan doğrulanmış");
        }

        public override void RequestCash(int cashToWithdraw, ATMMachine context)
        {
            if (cashToWithdraw>context.CashInMachine)
            {
                Console.WriteLine("ATM çekilmek istenilen tutarı temin edememektedir");
                Console.WriteLine("Kart çıkarılmıştır");
                context.State = new NoCard();
            }
            else
            {
                Console.WriteLine($"{cashToWithdraw} tutarında para çekilmiştir");
                context.CashInMachine -= cashToWithdraw;
                context.State = new NoCard();
                Console.WriteLine($"Atmde kalan para : {context.CashInMachine}");
                if (context.CashInMachine<=0)
                {
                    context.State = new NoCash();
                }
            }

        }
    }
}