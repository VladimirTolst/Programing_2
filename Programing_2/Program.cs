using System;
static bool password_test(string pass_inpt, string password)
{
    if (pass_inpt == password)
    {
        return true;
    }
    else
    {
        return false;
    }
}
string password = "8976";
int bal = 2000;

Console.WriteLine("Output - 1, input - 2");
string inpt = Console.ReadLine();
switch (inpt)
{
    case "1":
        {
            Console.WriteLine("PIN: ");
            string pass_inpt = Console.ReadLine();
            if (password_test(pass_inpt, password))
            {
                Console.WriteLine("Balance is " + bal);
                int bal_out = Convert.ToInt32(Console.ReadLine());
                if (bal - bal_out >= 0)
                {
                    bal -= bal_out;
                    Console.WriteLine("Balance = " + bal);
                }
                else
                {
                    Console.WriteLine("Not enough");
                }
            }
            else
            {
                Console.WriteLine("wrong pin");
                break;
            }
            break;
        }

    case "2":
        {
            Console.WriteLine("PIN: ");
            string pass_inpt = Console.ReadLine();
            if (password_test(pass_inpt, password))
            {
                Console.WriteLine("input: ");
                int bal_in = Convert.ToInt32(Console.ReadLine());
                bal += bal_in;
                Console.WriteLine("balance " + bal);
            }
            else
            {
                Console.WriteLine("wrong pin");
                break;
            }
            break;
        }
    default:
        {
            Console.WriteLine("incorrect input");
            break;
        }
}