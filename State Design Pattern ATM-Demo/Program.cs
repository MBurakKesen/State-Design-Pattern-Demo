using State_Design_Pattern_ATM_Demo;

ATMMachine machine = new ATMMachine();
machine.InsertCard();
machine.InsertPin(123);
machine.EjectCard();
Console.WriteLine("------------------");
machine.InsertCard();
machine.InsertPin(123);
machine.RequestCash(1000);
Console.WriteLine("---------------");
machine.InsertCard();
machine.InsertPin(123);
machine.RequestCash(1500);
Console.WriteLine("-----------------");
machine.InsertCard();
machine.InsertPin(123);
machine.RequestCash(1000);
Console.WriteLine("-----------------");
machine.InsertCard();
machine.InsertPin(123);
machine.RequestCash(1);

