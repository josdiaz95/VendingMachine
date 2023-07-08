namespace VendingMachine
{
    class Program
    { 
        public static Stack<string>? Drinks = new();

       public static void Main(string[] args)
       {
           char answer;

            do
            { 
              Console.WriteLine("Do you want to:\nA.Add Item\nB.Buy Item\nE.End");
              answer  = Convert.ToChar(Console.ReadLine().ToUpper()[0]);


              if (answer == 'A')
              {
                  AddSoda();
              }
              else if (answer == 'B')
              {
                  RemoveSoda();
              }
              else if (answer == 'E')
              {
                   Console.WriteLine("Thank you for using this vending service,enjoy!");
              }
              else
              {
                  Console.WriteLine("Invalid entry,try again.");
              }


            } while (answer != 'E');

       }

        public static void AddSoda()
        {
            
            Console.WriteLine("Which item would you like to add: ");
            Console.WriteLine("1.Coke");
            Console.WriteLine("2.Sprite");
            Console.WriteLine("3.Dr.Pepper");
            string drinkChoice = Console.ReadLine();

            if (drinkChoice == "1")
            {
                Drinks.Push("Coke");
                Console.WriteLine("You've added a Coke!");
                

            }
            else if (drinkChoice == "2")
            {
                Drinks.Push("Sprite");
                Console.WriteLine("You've added a Sprite!");
            }
            else if (drinkChoice == "3")
            {
                Drinks.Push("Dr.Pepper");
                Console.WriteLine("You've added a Dr. Pepper!");
            }
            else
            {
                Console.WriteLine("Invalid entry, try again.");
            }
        }

        public static void RemoveSoda()
        {
            if (Drinks.Count < 1)
            {
                Console.WriteLine("Sorry, there are no more drinks.");
            }
            else if (Drinks.Count > 0)
            {
                Console.WriteLine("You've purchased a:" + Drinks.Pop());
            }
        }
    }
}