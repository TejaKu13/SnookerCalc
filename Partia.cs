using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerCalc1
{
    public class Partia
    {
        public int reds;

        public Partia(int myReds)
        {
            reds = myReds;
            Console.WriteLine("Ilość czerwonych bil na stole:"+reds);
        }

        public int ObliczPunkty(int numberOfReds)
        {
            reds = numberOfReds;
            int points = 0;
            if (numberOfReds == 15)
            {
                points = 147;
            }else if (numberOfReds > 0 && numberOfReds < 15)
            {
                Console.WriteLine("czy była ostatnio wbijana czerwona bila? (t=tak,n=nie)");
                ConsoleKeyInfo redkey = Console.ReadKey();
                if (redkey.Key == ConsoleKey.T)
                {
                    points = numberOfReds * 8+7 + 27;
                }else if (redkey.Key == ConsoleKey.N)
                {
                    points = numberOfReds * 8 + 27;
                }
                else
                {
                    Console.WriteLine("Niewłaściwa wartość");
                }
            } else if(numberOfReds==0) {
                Console.WriteLine("czy była ostatnio wbijana czerwona bila? (t=tak,n=nie)");
                ConsoleKeyInfo redKey = Console.ReadKey();
                if (redKey.Key == ConsoleKey.T)
                {
                    points = numberOfReds * 8 + 7 + 27;
                }
                else if (redKey.Key == ConsoleKey.N)
                {
                    Console.WriteLine("Podaj ilość kolorowych bil na stole");
                    int numberOfColors= int.Parse(Console.ReadLine());

                    switch (numberOfColors)
                    {
                        case 0:
                            points = 0;
                            Console.WriteLine("Koniec partii.");
                            break;
                        case 1:
                            points = 7;
                            break;
                        case 2:
                            points = 13;
                            break;
                        case 3:
                            points = 18;
                            break;
                        case 4:
                            points = 22;
                            break;
                        case 5:
                            points = 25;
                            break;
                        case 6:
                            points = 27;
                            break;
                        default:
                            Console.WriteLine("Niewłaściwa wartość");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Niewłaściwa wartość");
                }
            }
            Console.WriteLine("Ilość punktów na stole:"+points);
            return 0;
        }
    }
}
