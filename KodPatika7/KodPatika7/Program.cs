﻿using System;

namespace KodPatika7
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız!");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayındasınız!");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayındasınız!");
                    break;
                case 3:
                    Console.WriteLine("Mert Ayındasınız!");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girdiniz!");
                    break;

                    switch (month)
                    {
                        case 12:
                        case 1:
                        case 2:
                        Console.WriteLine("Kış Ayındasınız!");
                            break;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("İlkbahar Ayındasınız!");
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("Yaz Ayındasınız!");
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("Yaz Ayındasınız!");
                            break;


                        default:

                            break;
                    }
            }
            
        }
    }
}
