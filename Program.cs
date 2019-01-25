using System;

namespace _44663
{
    class Program
    {
        static void Main(string[] args)
        {
            // var sum = 0;

            var age = 0.0;
            var canBuy = false;
            var EXIT_CHAR = 'y';
            String type;
            var name = "";//String.Empty
            var unitCost = 0.0m;
            var brand = "";
            var total = 1200.0m;
            var amount = 0.0m;//money to give in the bank
            String str;
            var sum = 0.0m;

            //greet the user.....
            Console.WriteLine("Hello welcome to the savings app user!");
            Console.WriteLine($"Enter ur name");
            name = Console.ReadLine();
            // Console.WriteLine("try another brand or enter q to quit");
            // String str = Console.ReadLine();
            // if(char.Parse(str) == EXIT_CHAR){
            //   Console.WriteLine("Have a great day!");
            //   break;  
            // }
            //get their name...

            while (name == "")
            {
                Console.WriteLine($"Enter ur name");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Your name is{name}.");


            //get their age...

            while (age == 0.0)
            {
                Console.WriteLine($"Enter ur age");
                var ans = Console.ReadLine();
                age = Convert.ToDouble(ans);
            }
            Console.WriteLine($"Your name is{age}.");
            do
            {
                //taking the amount
                Console.WriteLine($"Enter the amount to keep in bank");
                amount = Decimal.Parse(Console.ReadLine());
                //value = Convert.ToDouble(amount);

                Console.WriteLine($"Your amount entered is{amount}.");
                add(amount);

                //add money to their savings....


                //to calculate the sum in savings
                decimal add(decimal amou)
                {

                    sum = sum + amou;
                    return sum;
                }
                //get the brand...
                Console.WriteLine($"enter the brand name");

                String[] handbags = { "Coach", "Tory Burch" };
                for (int i = 0; i < handbags.Length; i++)
                {
                    Console.WriteLine(handbags[i]);
                }

                brand = Console.ReadLine();


                //get the brand(switch)
                switch (brand.ToUpper())
                {
                    case "COACH":
                        type = "Torte";
                        unitCost = 75.0m;
                        break;
                    case "TORY BURCH":
                        type = "sling bag";
                        unitCost = 100m;
                        break;
                    default:
                        Console.WriteLine("Provide correct details");
                        break;

                }
                Console.WriteLine($"Your brand name is{brand}.");

                if (sum > unitCost)
                {
                    canBuy = true;
                    Console.WriteLine("The amount to buy {0} is acquired, now you can buy", brand);
                    break;

                }

                Console.WriteLine("Do you want to continue to add some more money (y/n) ?");
                str = Console.ReadLine();
                if (char.Parse(str) == EXIT_CHAR)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Total savings are {sum}");
                    Console.WriteLine("Have a great day!");
                    break;
                }


            } while (true);
        }
    }
}