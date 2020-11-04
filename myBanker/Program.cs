using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myBanker {
    class Program
    {

        static void Main(string[] args)
        {
            

            Gui gui = new Gui();

            gui.PrintGui();
            bool start = false;
            

            while (!start)
            {

                int userChooseCard = int.Parse(Console.ReadLine());
                int cardType = userChooseCard;
                switch (userChooseCard)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Insert full name: ");
                    string userName = Console.ReadLine();
                    Console.Clear();
                    Card card = new CardMaker().CreateCard(userChooseCard,userName,cardType);
                    Console.WriteLine(card.ToString());
                    Thread.Sleep(5000);
                    Console.Clear(); 
                    gui.PrintGui();
                        break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Insert full name: ");
                    cardType = userChooseCard;
                    string userName2 = Console.ReadLine();
                    Card card2 = new CardMaker().CreateCard(userChooseCard, userName2, cardType);
                    Console.WriteLine(card2.ToString());
                    Thread.Sleep(5000);
                    Console.Clear();
                    gui.PrintGui();
                        break;


                case 3:
                        // Need more time to implement the rest of the cards
                        break;


                case 4:
                        // Need more time to implement the rest of the cards
                        break;


                case 5:
                        // Need more time to implement the rest of the cards
                        break;


                case 6:
                    start = true;
                    break;


                default:
                    Console.WriteLine("Please enter a valid number ");
                    break;
            }

            }
        }
    }
}
