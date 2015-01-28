using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugWarez
{
    class DrugPrice
    {
        public int bankTotal = 5000;//Amount in bank
        public int cashOnHand;
        public int WeedPrice;
        public int WeedAmount = 0;
        public int CrackPrice;
        public int CrackAmount = 0;
        public string sellInput;
        public int coatPockets = 0;
        public string input;

        //Random price creator for each neighborhood
        public int WeedPriceGenerator()
        {
            Random numGenerator = new Random();
            WeedPrice = numGenerator.Next(5, 40);
            return WeedPrice;
        }
        //Random price creator for each neighborhood
        public int CrackPriceGenerator()
        {          
            Random numGenerator = new Random();
            CrackPrice = numGenerator.Next(12, 70);
            return CrackPrice;
        }
        //Calculates how much weed you have purchased and updates your bank account
        public int WeedStashCalculator(int input)
        {
            int amount = 0;
            amount = (WeedPrice * input);
            bankTotal = bankTotal - amount;
            WeedAmount = WeedAmount + input;
            return amount;
        }
        //Calculates how much crack you have purchased and updates your bank account
        public int CrackStashCalulator(int input)
        {
            int amount = 0;
            amount = (CrackPrice * input);
            bankTotal = bankTotal - amount;
            CrackAmount = CrackAmount + input;
            return amount;
        }
        //Calculates how much you sold and how much you made
        public int SellDrugs(int input)
        {
            if (sellInput == "1" )
            {
                bankTotal = bankTotal + (input * WeedPrice);
                WeedAmount = WeedAmount - input;
            }
            else
            {
                bankTotal = bankTotal + (input * CrackPrice);
                CrackAmount = CrackAmount - input;
            }

            return bankTotal;
        }

        //Bank total check
        public void MoneyBalanceCheck(int money)
        {
            if (money <= bankTotal)
            {
                Console.WriteLine("You are out of Money");
            }
            
        }

        //Burrow Location
        public void BurrowLocation()
        {
            int weedPrice = WeedPriceGenerator();
            int crackPrice = CrackPriceGenerator();
            Console.WriteLine("You have entered Uptown...\n Do you want to? \n 1) buy Drugs \n 2) Sell Drugs");
            input = Console.ReadLine();
        }

        
    }
}
