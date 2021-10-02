using System;
using System.Collections.Generic;

namespace flowershop
{
    class Program
    {
        static void Main(string[] args)
        {
            string decide = "y";
            int selectFlower;
            FlowerStore flowerStore = new FlowerStore();
            do
            {
                Console.WriteLine("Select number for buy flower :");
                foreach (string i in flowerStore.flowerList)
                {
                    Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + " ");
                    Console.WriteLine(i);
                }
                selectFlower = int.Parse(Console.ReadLine());
                if (selectFlower == 1)
                {
                    flowerStore.addToCart(flowerStore.flowerList[0]);
                    Console.WriteLine("Added " + flowerStore.flowerList[0]);
                }
                else if (selectFlower == 2)
                {
                    flowerStore.addToCart(flowerStore.flowerList[1]);
                    Console.WriteLine("Added " + flowerStore.flowerList[1]);
                }
                else
                {
                    Console.WriteLine("Not Added to cart. found select number of flower");
                }
                Console.WriteLine("You can stop this progress ?  exit for >>  exit << progress and pressany key for continue");
                decide = Console.ReadLine();
                if (decide == "exit")
                {
                    Console.WriteLine("Current my cart");
                    flowerStore.showCart();
                }
            }
            while (decide != "exit");
        }
    }
    class FlowerStore
    {
        public List<string> flowerList = new List<string>();
        List<string> cart = new List<string>();
        public FlowerStore()
        {
            flowerList.Add("Rose");
            flowerList.Add("Lotus");
        }
        public void addToCart(string name)
        {
            cart.Add(name);
        }
        public void showCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                Console.WriteLine("My Cart :");
                foreach (string i in cart)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
