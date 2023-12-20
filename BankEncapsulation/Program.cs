namespace BankEncapsulation
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            var account = new BankAccount();

            double input;
                                  

            Console.WriteLine("Welcome to Bank of Kim.  Press 1 for Depost.  Press 2 for Withdrawl.");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 2)
            {
                Console.WriteLine("Withdrawls are not accepted at this time, there is no money in the account.");

            }else if (userChoice == 1)
            {
                Console.WriteLine("Enter amount to deposit");
                input = double.Parse(Console.ReadLine());
                account.Deposit(input);
                
                Console.WriteLine($"Deposit accepted, your new balance is {account.GetBalance()}");


            }else
            {
                Console.WriteLine("Invalid Entry, Please Try Again.");
            }



            
            
           
        }
    }
}
