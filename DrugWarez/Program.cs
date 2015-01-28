using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugWarez
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize object
            DrugPrice drgPrice = new DrugPrice();
            string input;
            int amount;
            int i = 1;

            //Loops the program 30 times
            while (i <= 30 || drgPrice.bankTotal >= 0)
            {
                Console.WriteLine("You have $" + drgPrice.bankTotal + " in the bank\n" + "Weed on hand: " + drgPrice.WeedAmount + "\n Crack on hand: " + drgPrice.CrackAmount );
                Console.WriteLine("What Burrow do you want to visit\n 1) Uptown\n 2) Midtown\n 3) Downtown");
                input = Console.ReadLine();

                if (input == "1")
                {
                    drgPrice.BurrowLocation();
                    //int weedPrice = drgPrice.WeedPriceGenerator();
                    //int crackPrice = drgPrice.CrackPriceGenerator();
                    //Console.WriteLine("You have entered Uptown...\n Do you want to? \n 1) buy Drugs \n 2) Sell Drugs");
                    //input = Console.ReadLine();

                    /*******************BUY***********************/
                    //Buy Drugs 
                    if (input == "1")                                                                                                                                                                                                                                                                                                       
                    {
                        Console.WriteLine("What drugs do you want to buy?\n 1) Weed {0}\n 2) Crack {1}", drgPrice.WeedPrice, drgPrice.CrackPrice);
                        input = Console.ReadLine();

                        //How Much Weed you want to buy
                        if (input == "1")
                        {
                            Console.WriteLine("How much Weed do you want to buy? ");
                            input = Console.ReadLine();
                            amount = Convert.ToInt32(input);
                            //drgPrice.WeedAmount = amount;
                            amount = drgPrice.WeedStashCalculator(amount);
                            Console.WriteLine("You bought: " + input + " of weed for a total of: " + amount + "and have: " + drgPrice.WeedAmount);
                        }
                        //How much Crack you want to buy
                        else if (input == "2")
                        {
                            Console.WriteLine("How much Crack do you want to buy? ");
                            input = Console.ReadLine();
                            amount = Convert.ToInt32(input);
                            //drgPrice.CrackAmount = amount;
                            amount = drgPrice.CrackStashCalulator(amount);
                            Console.WriteLine("You bought: " + input + " of crack for a total of: " + amount + "and have: " + drgPrice.CrackAmount);
                        }
                    }

                    /*******************SELL***********************/
                    //Sell Drugs
                    else if (input == "2")
                    {
                        /*weedPrice =*/ drgPrice.WeedPriceGenerator();
                        /*crackPrice =*/ drgPrice.CrackPriceGenerator();
                        Console.WriteLine("What drugs do you want to sell? \n 1) Weed {0}\n 2) Crack {1}", drgPrice.WeedPrice, drgPrice.CrackPrice);
                        input = Console.ReadLine();
                        drgPrice.sellInput = input;


                        //Sell Weed
                        if (input == "1")
                        {
                            Console.WriteLine("How much weed do you want to sell?");                           
                            input = Console.ReadLine();
                            amount = Convert.ToInt32(input);
                            drgPrice.bankTotal = drgPrice.SellDrugs(amount);
                            Console.WriteLine("You bought: " + input + " of weed for a total of: " + amount + "and have: " + drgPrice.WeedAmount);
                            
                        }

                        //Sell Crack
                        if (input == "2")
                        {
                            Console.WriteLine("How much crack do you want to sell?");
                            input = Console.ReadLine();
                            amount = Convert.ToInt32(input);
                            drgPrice.bankTotal = drgPrice.SellDrugs(amount);
                            Console.WriteLine("You bought: " + input + " of weed for a total of: " + amount + "and have: " + drgPrice.CrackAmount);

                        }
                    }
                }


                i++;  
            }//EndWhile Loop
        }
    }
}
