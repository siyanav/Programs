using System.Security.Principal;

class Program
{
    public double balance;
    public void Deposit(double amount)
    {
        if (amount > 0)
        balance += amount;
    }
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        balance -= amount;
    }
    public double GetBalance()
    {
        return balance;
    }
}

class GFG
{
    static void Main()
    {
        
        Program acc = new Program();
        acc.Deposit(500);
        acc.Withdraw(200);
        Console.WriteLine("Balance: " + acc.GetBalance());

    }
}


 

