namespace BANK_TEST
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount UserAccount = new BankAccount();
            string UserName;
            string UserPassword;
            decimal amount;
            string Message;

            Console.Write("Name: ");
            UserName = Console.ReadLine();
            Console.Write("password: ");
            UserPassword = Console.ReadLine();

            Console.WriteLine();
            Console.Write("login in progress.......");

            UserAccount = UserAccount.Login(UserName, UserPassword);
            Console.WriteLine();

            if (UserAccount != null)
            {
                Console.WriteLine("welcome back " + UserAccount.Name);
                Console.WriteLine();

                Console.Write("Balance: " + UserAccount.Balance.ToString("C"));
            }
            else 
            {
                Console.WriteLine("error");
            }

            Console.WriteLine();

            Console.Write("amount:");
            amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            Message = UserAccount.Deposit(amount);
            Console.WriteLine(Message);

            
        }
    }
}