using System;



namespace tidtagare
    {
        class Program
        {
            static void Main(string[] args)
            {
                int startNum = 0,
                    startH = 0,
                    startM = 0,
                    startS = 0,
                    startTidisek = 0,
                    slutH = 0,
                    slutM = 0,
                    slutS = 0,
                    slutTid = 0,
                    slutTidisek = 0,
                    vinnareSluth = 0,
                    vinnareSlutm = 0,
                    vinnareSluts = 0,
                    vinnareNum = 0,
                    vinnareT = int.MaxValue,
                    antalRunner = 0;



                while (true)
                {


                    Console.Write("Ange startnummer:  ");
                startNum = int.Parse(Console.ReadLine());

                    if (startNum < 1)
                    {
                        break;
                    }

                    Console.Write("Ange timme för start:  ");
                    startH = int.Parse(Console.ReadLine());

                    Console.Write("Ange minut för start:  ");
                    startM = int.Parse(Console.ReadLine());

                    Console.Write("Ange sekund för start:  ");
                    startS = int.Parse(Console.ReadLine());

                    // Finish
                    Console.Write("Ange timme för mål:  ");
                    slutH = int.Parse(Console.ReadLine());

                    Console.Write("Ange minut för mål:  ");
                    slutM = int.Parse(Console.ReadLine());

                    Console.Write("Ange sekund för mål:  ");
                    slutS = int.Parse(Console.ReadLine());




                    startTidisek = startH * 3600 + startM * 60 + startS;
                    slutTidisek = slutH * 3600 + slutM * 60 + slutS;

                    slutTidisek = slutTidisek - startTidisek;

                    if (slutTidisek < 0)
                    {
                        slutTidisek += 24 * 3600;
                    }

                    if (slutTidisek < vinnareT)
                    {
                        vinnareNum = startNum;
                        vinnareT = slutTidisek;

                    }

                    antalRunner++;

                    Console.WriteLine($"Startnummer {vinnareNum} är vinnaren");

                    vinnareSluth = (int)Math.Floor((decimal)vinnareT / 3600);
                    vinnareSlutm = (int)Math.Floor((decimal)vinnareT / 60) - vinnareSluth * 60;
                    vinnareSluts = vinnareT % 60;

                    Console.WriteLine($"Vinnande sluttid: {vinnareSluth} timmar {vinnareSlutm} minuter {vinnareSluts} sekunder");
                    Console.WriteLine($"Antal tävlande: {antalRunner}");

                }
            }
        }
    }


