using System;

namespace _44663
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            //var age = 0.0;
            //var canBuy = false;
            //var EXIT_CHAR = 'q';
            //var name = ""/String.Empty;
            //decimal unitCost = 0.0;// var unitCost = 0.0m;
            // var breed = "";





            while(true){
            //greet the user.....
            Console.WriteLine("Hello welcome to the avings app user!");


            //get their name...

           // while(name == ""){
           // Console.WriteLine($"Enter ur name");
            //name = Console.ReadLine();
            //}
           // Console.WriteLine($"Your name is{name}.")


            //get their age...

            // while(age == 0.0){
            //Console.WriteLine($"Enter ur age");
            //var ans = Console.ReadLine();
            //age = Convert.ToDouble(ans);
            //}
            //Console.WriteLine($"Your name is{age}.")



            //get the breed...

            //get the breed(switch)
            switch(){
                case "coach":
                    type = "Torte";
                    unitcost = 75.0m;
                    break;
                case "pom":
                    brees = "sling bag";
                    unitCost = 100m;
                    break;
                default:
                break;

            }
            //Console.WriteLine($"Your name is{breed}.")


            //add money to their savings....
            while(true){}

            Console.WriteLine("enter a number or enter q to quit");
            String str = Console.ReadLine();
            if(str =="q"){
              Console.WriteLine("Cya");  
              break;
            }
            Console.WriteLine($" you entered:{str} ");
            var i = Convert.ToInt32(str);
            sum+=i;
            Console.WriteLine($" Your sum is {sum}");
            }
        }
    }
}
