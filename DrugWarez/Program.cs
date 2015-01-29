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

                    /*******************BUY***********************/
                    //Buy Drugs 
                    if (input == "1")                                                                                                                                                                                                                                                                                                       
                    {
                        Console.WriteLine("What drugs do you want to buy?\n 1) Weed {0}\n 2) Crack {1}", drgPrice.WeedPrice, drgPrice.CrackPrice);
                        input = Console.ReadLine();

                        //How Much Weed you want to buy
                        if (input == "1")
                        {
                            drgPrice.BuyWeed();
                        }
                        //How much Crack you want to buy
                        else if (input == "2")
                        {
                            drgPrice.BuyCrack();
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
                            drgPrice.SellWeed();                            
                        }

                        //Sell Crack
                        if (input == "2")
                        {
                            drgPrice.SellCrack();
                        }
                    }
                }


                i++;  
            }//EndWhile Loop
        }
    }
}
