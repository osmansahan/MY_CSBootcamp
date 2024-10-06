using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* Visual Studio (VS) IntelliSense is a code completion tool developed by Microsoft, 
            which assists in various tasks such as code completion, suggesting function and variable names, 
            and debugging. */

            #region Printing Commands
            //Console.WriteLine("***Food Categories***");
            //Console.WriteLine();
            //Console.WriteLine("1-Soups");
            //Console.WriteLine("2-Cold Appetizers");
            //Console.WriteLine("3-Salads");
            //Console.WriteLine("4-Desserts");
            //Console.WriteLine("5-Beverages");
            //Console.WriteLine();
            //Console.WriteLine("***Food Categories***");
            //Console.Read();
            #endregion

            #region String
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "John";
            //customerSurname = "Doe";
            //customerPhone = "123-456-7890";
            //customerEmail = "johndoe@gmail.com";
            //district = "Downtown";
            //city = "New York";

            //Console.WriteLine("*** Reservation Card ***");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            //Console.WriteLine("Contact: " + customerPhone);
            //Console.WriteLine("Email Address: " + customerEmail);
            //Console.WriteLine("Address: " + district + "/" + city);
            //Console.WriteLine("---------------------------");

            //customerName = "Emily";
            //customerSurname = "Smith";
            //customerPhone = "987-654-3210";
            //customerEmail = "emily.smith@example.com";
            //district = "Uptown";
            //city = "Los Angeles";

            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            //Console.WriteLine("Contact: " + customerPhone);
            //Console.WriteLine("Email Address: " + customerEmail);
            //Console.WriteLine("Address: " + district + "/" + city);
            //Console.WriteLine("---------------------------");
            #endregion

            #region Int

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("***Restaurant Menu Prices***");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("---Hamburger: " + "$" + hamburgerPrice);
            //Console.WriteLine("---Pizza: " + "$" + pizzaPrice);
            //Console.WriteLine("---Coke: " + "$" + cokePrice);
            //Console.WriteLine("---Lemonade: " + "$" + lemonadePrice);
            //Console.WriteLine("---Fries: " + "$" + friesPrice);
            //Console.WriteLine("---Water: " + "$" + waterPrice);
            //Console.WriteLine("---------------------------");
            //Console.WriteLine();

            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalCount;

            //int totalHamburperPrice;
            //int totalCokePrice;
            //int totalWaterPrice;
            //int totalFriesPrice;
            //int totalPizzaPrice;
            //int totalLemonadePrice;

            //int totalPrice;

            //hamburgerCount = 3;
            //cokeCount = 2;
            //waterCount = 3;
            //friesCount = 0;
            //pizzaCount = 0;
            //lemonadeCount = 3;

            //totalCount = hamburgerCount + cokeCount + waterCount + friesCount + pizzaCount + lemonadeCount;

            //totalHamburperPrice = hamburgerCount * hamburgerPrice;
            //totalCokePrice = cokeCount * cokePrice;
            //totalWaterPrice = waterCount * waterPrice;
            //totalFriesPrice = friesCount * friesPrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;

            //totalPrice = totalHamburperPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            //Console.WriteLine("***Total Amount Due***");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Total Hamburger Amount: " + hamburgerCount + "x" + hamburgerPrice + " = " + "$" + totalHamburperPrice);
            //Console.WriteLine("Total Coke Amount: " + cokeCount + "x" + cokePrice + " = " + "$" + totalCokePrice);
            //Console.WriteLine("Total Water Amount: " + waterCount + "x" + waterPrice + " = " + "$" + totalWaterPrice);
            //Console.WriteLine("Total Fries Amount: " + friesCount + "x" + friesPrice + " = " + "$" + totalFriesPrice);
            //Console.WriteLine("Total Pizza Amount: " + pizzaCount + "x" + pizzaPrice + " = " + "$" + totalPizzaPrice);
            //Console.WriteLine("Total Lemonade Amount: " + lemonadeCount + "x" + lemonadePrice + " = " + "$" + totalLemonadePrice);
            //Console.WriteLine();
            //Console.WriteLine("Total Quantity of Items Purchased: " + totalCount);
            //Console.WriteLine("Total Amount: " + "$" + totalPrice);
            //Console.WriteLine("---------------------------");

            #endregion

            #region Double

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 0.75;
            //orangePrice = 0.80;
            //strawberryPrice = 3.00;
            //potatoPrice = 0.50;
            //tomatoPrice = 0.60;

            //Console.WriteLine("***** Price List *****");
            //Console.WriteLine();
            //Console.WriteLine("---- Apple Unit Price: $" + applePrice);
            //Console.WriteLine("---- Orange Unit Price: $" + orangePrice);
            //Console.WriteLine("---- Strawberry Unit Price: $" + strawberryPrice);
            //Console.WriteLine("---- Potato Unit Price: $" + potatoPrice);
            //Console.WriteLine("---- Tomato Unit Price: $" + tomatoPrice);

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Purchased Product: Apple - Unit Price: $" + applePrice + " - Weight: " + appleGram + " - Total Amount: $" + appleTotalPrice);
            //Console.WriteLine("Purchased Product: Orange - Unit Price: $" + orangePrice + " - Weight: " + orangeGram + " - Total Amount: $" + orangeTotalPrice);
            //Console.WriteLine("Purchased Product: Strawberry - Unit Price: $" + strawberryPrice + " - Weight: " + strawberryGram + " - Total Amount: $" + strawberryTotalPrice);
            //Console.WriteLine("Purchased Product: Potato - Unit Price: $" + potatoPrice + " - Weight: " + potatoGram + " - Total Amount: $" + potatoTotalPrice);
            //Console.WriteLine("Purchased Product: Tomato - Unit Price: $" + tomatoPrice + " - Weight: " + tomatoGram + " - Total Amount: $" + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("Total Shopping Amount: $" + shoppingTotalPrice);

            #endregion

            #region Char

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //"  ' 

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Inputting Data from the Keyboard into String Variables

            //Console.WriteLine("**** MY Airlines Passenger Information ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Passenger Name: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Passenger Surname: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("District Information: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("City Information: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Passenger Age: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Passenger ID Number: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Passenger ID Number: " + passengerIdentityNumber);
            //Console.WriteLine("Passenger Full Name: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("District: " + passengerDistrict);
            //Console.WriteLine("City: " + passengerCity);
            //Console.WriteLine("Age: " + passengerAge);
            //Console.WriteLine("-----------------------");

            #endregion

            #region Integer Input from Keyboard and Conversions

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Please enter the number of shoes purchased: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number of computers purchased: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number of chairs purchased: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number of televisions purchased: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Total Amount Due: $" + totalPrice);

            #endregion

            #region Floating-Point Number Operations from Keyboard Input

            //double exam1, exam2, exam3, result;

            //Console.Write("Please enter the score for Exam 1: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter the score for Exam 2: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter the score for Exam 3: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Your Exam Average: " + result);

            #endregion

            #region Character Input from Keyboard

            //char gender;
            //Console.Write("Please select your gender: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("You selected Gender: " + gender);

            #endregion
        }
    }
}
