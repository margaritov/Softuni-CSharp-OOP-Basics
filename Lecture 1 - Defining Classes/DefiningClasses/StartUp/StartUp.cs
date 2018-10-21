using System;
using System.Collections.Generic;

namespace BankAccount
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                int id = int.Parse(command[1]);

                
                switch (command[0])
                {
                    case "Create":

                        if (!accounts.ContainsKey(id))
                        {
                            accounts.Add(id, new BankAccount(id));
                        }
                        else
                        {
                            Console.WriteLine("Account already exists");
                        }
                        break;
                    case "Deposit":
                        if (!accounts.ContainsKey(id))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            accounts[id].Deposit(decimal.Parse(command[2]));
                        }
                        break;
                    case "Withdraw":
                        if (!accounts.ContainsKey(id))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            accounts[id].Withdraw(decimal.Parse(command[2]));
                        }
                        break;
                    case "Print":
                        if (!accounts.ContainsKey(id))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            Console.WriteLine(accounts[id]);
                        }
                        break;
                    default:
                        break;
                }


                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }

    }
}
