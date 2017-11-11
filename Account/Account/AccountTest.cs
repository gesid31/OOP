using System;

namespace Account
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account myAccount1 = new Account(15.35M);
            Account myAccount2 = new Account(-1.35M);

            Console.WriteLine("you initial Balace in Account1 is {0:C}", myAccount1.Balance);
            Console.WriteLine("you initial Balace in Account2 is {0:C}\n", myAccount2.Balance);

            decimal depositAmount;

            Console.WriteLine("enter the amount to be credited into Account1");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Amount credited to your Account1 is {0:C}\n", depositAmount);
            myAccount1.Credit(depositAmount);

            Console.WriteLine("you initial Balace in Account1 is {0:C}", myAccount1.Balance);
            Console.WriteLine("you initial Balace in Account2 is {0:C}\n", myAccount2.Balance);


            Console.WriteLine("enter the amount to be credited into Account2");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Amount credited to your Account2 is {0:C}\n", depositAmount);
            myAccount2.Credit(depositAmount);

            Console.WriteLine("you initial Balace in Account1 is {0:C}", myAccount1.Balance);
            Console.WriteLine("you initial Balace in Account2 is {0:C}\n", myAccount2.Balance);

        }
    }
}
