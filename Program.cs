using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IsmetlesNelkuliRandom
{
    class Program
    {
        static List<Beolvas> BeolvList;
        static List<int> IsmetlesNElkulList;
        static List<Nyeremeny> NyeremenyList;
        static Random rnd = new Random();
        static int j;
        static int Hanyadik;
        static int dbF;
        static int dbK;
        static int dbT;
        
        static void Main(string[] args)
        {
            VeletlenSzamGenerelas();
            //Console.WriteLine("\n--------------------------\n");
            BeolvasasKiiratas();
           // Console.WriteLine("\n--------------------------\n");
            BeovasasNyeremeny();
            //Console.WriteLine("\n--------------------------\n");
            SikeresKiiratas();
            Console.WriteLine("\n--------------------------\n");
            
            Console.ReadKey();
        }

        

        private static void SikeresKiiratas()
        {   /*
            Console.WriteLine("Írja ki a megfelelő kérdést sorszám szerint");
            foreach (var a in IsmetlesNElkulList)
            {
                foreach (var b in BeolvList)
                {
                    if (a ==b.Sorszam)
                    {
                        Console.WriteLine("\n{0}\t{1}\n\n{2}\t{3}\t{4}\t{5}", b.Sorszam, b.Kerdes, b.ALehetoseg,b.ALehetoseg, b.CLehetoseg, b.DLehetoseg );
                    }
                }
               
            }
            */
            int ny = 0;
            j = 0;
            dbF = 0;
            dbK = 0;
            dbT = 0;
            foreach (var b in BeolvList)
            {
                
                Hanyadik= IsmetlesNElkulList[j];
                if (Hanyadik == b.Sorszam)
                {
                    NyeremenyKiir();
                    Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, b.ALehetoseg, b.BLehetoseg, b.CLehetoseg, b.DLehetoseg);
                    eleje:
                    Console.WriteLine("\nFelhasználható lehetőségek Válaszok: A, B, C, D, Segítségek: T/telefonos, K/közönség, F/felezés");
                    Console.Write("\nKérem adja meg válaszát vagy kérjen segítséget: ");
                    string FelhasznaloValasz = Console.ReadLine().ToUpper();
                    if (FelhasznaloValasz == b.Valasz)
                    {
                        Console.WriteLine("Ügyes vagy jó válasz");
                        j++;
                        Console.Clear();
                        PillanatnyiNyeremeny();
                    }

                    if (FelhasznaloValasz == "F")
                    {
                        if (dbF == 0)
                        {
                            dbF++;
                            if (b.Valasz == "A")
                            {
                                Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, b.ALehetoseg, " ", b.CLehetoseg, " ");

                                goto eleje;
                            }
                            if (b.Valasz == "B")
                            {

                                Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, b.ALehetoseg, b.BLehetoseg, " ", " ");

                                goto eleje;
                            }
                            if (b.Valasz == "C")
                            {

                                Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, " ", b.BLehetoseg, b.CLehetoseg, " ");

                                goto eleje;
                            }
                            if (b.Valasz == "D")
                            {
                                Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, " ", b.BLehetoseg, " ", b.DLehetoseg);

                                goto eleje;
                            }
                            dbF++;
                        }
                        if (dbF != 0)
                        {

                            Console.WriteLine("Sajnos ezt a segítséget nem használhatja többet");
                            goto eleje;
                        }
                    }

                    if (FelhasznaloValasz == "K")
                    {

                        if (dbK == 0)
                        {
                            dbK++;
                            if (b.Valasz == "A")
                            {
                                int AValszin = rnd.Next(75, 82);
                                int BValszin = rnd.Next(0, 6);
                                int CValszin = rnd.Next(0, 6);
                                int DValszin = 100 - AValszin - BValszin - CValszin;
                                Console.WriteLine("\n\nA válasz volószínüsége : {0}\nB válasz volószínüsége : {1}\nC válasz volószínüsége : {2}\nD válasz volószínüsége : {3}", AValszin, BValszin, CValszin, DValszin);
                               //Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, b.ALehetoseg, b.BLehetoseg, b.CLehetoseg, b.DLehetoseg);
                                goto eleje;

                            }
                            if (b.Valasz == "B")
                            {
                                int BValszin = rnd.Next(75, 82);
                                int AValszin = rnd.Next(0, 6);
                                int CValszin = rnd.Next(0, 6);
                                int DValszin = 100 - AValszin - BValszin - CValszin;
                                Console.WriteLine("\n\nA válasz volószínüsége : {0}\nB válasz volószínüsége : {1}\nC válasz volószínüsége : {2}\nD válasz volószínüsége : {3}", AValszin, BValszin, CValszin, DValszin);
                                //Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, b.ALehetoseg, b.BLehetoseg, b.CLehetoseg, b.DLehetoseg);
                                goto eleje;
                            }
                            if (b.Valasz == "C")
                            {
                                int CValszin = rnd.Next(75, 82);
                                int BValszin = rnd.Next(0, 6);
                                int AValszin = rnd.Next(0, 6);
                                int DValszin = 100 - AValszin - BValszin - CValszin;
                                Console.WriteLine("\n\nA válasz volószínüsége : {0}\nB válasz volószínüsége : {1}\nC válasz volószínüsége : {2}\nD válasz volószínüsége : {3}\t", AValszin, BValszin, CValszin, DValszin);
                               // Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, b.ALehetoseg, b.BLehetoseg, b.CLehetoseg, b.DLehetoseg);
                                goto eleje;
                            }
                            if (b.Valasz == "D")
                            {
                                int DValszin = rnd.Next(75, 82);
                                int BValszin = rnd.Next(0, 6);
                                int CValszin = rnd.Next(0, 6);
                                int AValszin = 100 - DValszin - BValszin - CValszin;
                                Console.WriteLine("\n\nA válasz volószínüsége : {0}\nB válasz volószínüsége : {1}\nC válasz volószínüsége : {2}\nD válasz volószínüsége : {3}\t", AValszin, BValszin, CValszin, DValszin);
                               // Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, b.ALehetoseg, b.BLehetoseg, b.CLehetoseg, b.DLehetoseg);
                                goto eleje;
                            }
                            dbK++;
                        }
                        if (dbK != 0)
                        {

                            Console.WriteLine("Sajnos ezt a segítséget nem használhatja többet");
                            goto eleje;
                        }
                    }
                    if (FelhasznaloValasz == "T")
                    {
                        if (dbT == 0)
                        {
                           
                            dbT++;
                            if (b.Valasz == "A")
                            {
                                int AValszin = rnd.Next(80, 100);
                                Console.WriteLine("\n\n{0} %-ban biztos vagyok benne, hogy az A válasz a helyes", AValszin);
                                //Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, b.ALehetoseg, b.BLehetoseg, b.CLehetoseg, b.DLehetoseg);
                                Console.Clear();
                                goto eleje;

                            }
                            if (b.Valasz == "B")
                            {
                                int BValszin = rnd.Next(80, 100);
                                Console.WriteLine("\n\n{0} %-ban biztos vagyok benne, hogy az B válasz a helyes", BValszin);
                               // Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, b.ALehetoseg, b.BLehetoseg, b.CLehetoseg, b.DLehetoseg);
                                goto eleje;
                            }
                            if (b.Valasz == "C")
                            {
                                int CValszin = rnd.Next(80, 100);
                                Console.WriteLine("\n\n{0} %-ban biztos vagyok benne, hogy az C válasz a helyes", CValszin);
                               // Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, b.ALehetoseg, b.BLehetoseg, b.CLehetoseg, b.DLehetoseg);
                                goto eleje;
                            }
                            if (b.Valasz == "D")
                            {
                                int DValszin = rnd.Next(80, 100);
                                Console.WriteLine("\n\n{0} %-ban biztos vagyok benne, hogy az D válasz a helyes", DValszin);
                               // Console.WriteLine("\n{0}\t{1,-20}\n\n{2, -20}\t{3, -20}\t{4, -20}\t{5, -20}", b.Sorszam, b.Kerdes, b.ALehetoseg, b.BLehetoseg, b.CLehetoseg, b.DLehetoseg);
                                goto eleje;
                            }
                            dbT++;
                        }
                        if (dbT != 0)
                        {
                            Console.WriteLine("Sajnos ezt a segítséget nem használhatja többet");
                            goto eleje;
                        }
                    }
                    if (FelhasznaloValasz!="A" || FelhasznaloValasz != "B" || FelhasznaloValasz != "C" || FelhasznaloValasz != "D" || FelhasznaloValasz != "F" || FelhasznaloValasz != "K"|| FelhasznaloValasz!="T" )
                    {
                        Console.WriteLine("\nVége a játéknak, béna vagy");
                        JatekVege();
                    }
                }
             }
        }

        private static void PillanatnyiNyeremeny()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            if(j<14)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("\nGratulálok Ön itt tart : {0}", NyeremenyList[14 - j].NyeremenyOsszeg);
            }            
            if (j == 14)
            {
                Console.WriteLine("Gratulálunk nyert 40'000'000-ot");
            }
        }

        private static void JatekVege()
        {
            if ((0 < j) && (j < 5))
            {
                Console.WriteLine("\n--------------------------\n");
                Console.WriteLine("Nyereménye: 5'000 Ft");
            }
            if ((6 <= j) && (j < 10))
            {
                Console.WriteLine("\n--------------------------\n");
                Console.WriteLine("Nyereménye: 100'000 Ft");
            }
            if ((10 <= j) && (j < 14))
            {
                Console.WriteLine("\n--------------------------\n");
                Console.WriteLine("Nyereménye: 1'500'000 Ft");
            }
            if(j == 14)
            {
                Console.WriteLine("\n--------------------------\n");
                Console.WriteLine("Gratulálunk nyert 40'000'000-ot");
            }
        }

        private static void NyeremenyKiir()
        {
            Console.WriteLine("\n--------------------------\n");
            for (int i = 0; i <=13; i++)
            {
                //Console.WriteLine("{0,-2}:\t{1}", NyeremenyList[i].NyeremenySorszam, NyeremenyList[i].NyeremenyOsszeg);
                if(NyeremenyList[i].NyeremenySorszam==j)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0,-2}:\t{1}", NyeremenyList[i].NyeremenySorszam, NyeremenyList[i].NyeremenyOsszeg);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("{0,-2}:\t{1}", NyeremenyList[i].NyeremenySorszam, NyeremenyList[i].NyeremenyOsszeg);
                }
            }
            Console.WriteLine("\n--------------------------\n");
        }

        private static void BeovasasNyeremeny()
        {
            NyeremenyList = new List<Nyeremeny>();
            var sr = new StreamReader(@"nyeremeny.txt", Encoding.UTF8);
            int db = 0;
            while (!sr.EndOfStream)
            {

                db++;
                NyeremenyList.Add(new Nyeremeny(sr.ReadLine()));
            }
            sr.Close();
            if (db > 0)
            {
             //  Console.WriteLine("\nBeolvasás sikeres");
            }
            else
            {
              // Console.WriteLine("Beolvasás sikertelen, béna vagy megint");
            }            
        }
        private static void BeolvasasKiiratas()
        {
            //Console.WriteLine("Kérdések beolvasása");
            BeolvList = new List<Beolvas>();
            var sr = new StreamReader(@"kerdesvalasz.txt", Encoding.UTF8);
            int db = 0;
            while(!sr.EndOfStream)
            {
                db++;
                BeolvList.Add(new Beolvas(sr.ReadLine()));
            }
            sr.Close();
            if(db>0)
            {
              //  Console.WriteLine("\nBeolvasás sikeres");
            }
            else
            {
              //  Console.WriteLine("Beolvasás sikertelen, béna vagy megint");
            }
        }

        private static void VeletlenSzamGenerelas()
        {
            //Console.WriteLine("Véletlen számok generálása listávba ismétlés nélkül");
            IsmetlesNElkulList = new List<int>();
            int szam = 0;
            do
            {
                szam = rnd.Next(1, 26);
                if (!IsmetlesNElkulList.Contains(szam))
                {
                    IsmetlesNElkulList.Add(szam);
                }
                
            }
            while (IsmetlesNElkulList.Count < 14);
            
            int db = 0;
            IsmetlesNElkulList.Sort();
            //IsmetlesNElkulList.Reverse();
            foreach (var il in IsmetlesNElkulList)
            {
                db++;
                //Console.WriteLine("{0, -2}. {1}", db, il);
            }
        }
        
    }
}
