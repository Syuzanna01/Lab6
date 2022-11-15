using Lab6;

Account account1 = new Account("Syuzanna", "Manukyan", DateTime.MaxValue);
Account.count = 1;
Console.Write(Account.GetSum(5435466536, 2, AccountState.Gold) + "  ");
account1.Report();
Console.WriteLine();

Account account2 = new Account("Vane", "mirzoyan", DateTime.Now);
Account.count = 1;
Console.Write(Account.GetSum(54354646, 5, AccountState.Premium) + " ");
account2.Report();
Console.WriteLine();

Account account3 = new Account("Xachik", "Xalatyan", DateTime.MaxValue);
Account.count = 1;
Console.Write(Account.GetSum(646, 2, AccountState.Standard) + " ");
account3.Report();
Console.WriteLine();

Account account4 = new Account("Taguhi", "Nersisyan", DateTime.UtcNow);
Account.count = 1;
Console.Write(Account.GetSum(3446254254546, 8, AccountState.Premium) + " ");
account4.Report();