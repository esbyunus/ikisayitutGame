namespace basicgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Oyuna hazir misin? (evet/hayir)");
                string oyun = Console.ReadLine().ToLower();

                if (oyun == "evet")
                {
                    Console.WriteLine("Bunu duyduguma sevindim. Seni yeneceğim!");
                    Random rnd = new Random();  
                    int oyuncusayi = rnd.Next(0, 5);
                    int oyuncusayi1 = rnd.Next(0, 5);  
                    int botsayi = rnd.Next(0, 5);
                    int botsayi1 = rnd.Next(0, 5);
                    int oyuncuToplam = oyuncusayi + oyuncusayi1;
                    int botToplam =  botsayi + botsayi1;
                    if (oyuncuToplam > botToplam)
                    {
                        Console.WriteLine($"Oyuncu = {oyuncuToplam}, Bot = {botToplam}");
                        Console.WriteLine("Oyuncu kazandi.");
                        Console.WriteLine("Bot: Bidahaki sefere ben kazanacagim!");
                       
                    }
                    else if (oyuncuToplam < botToplam)
                    {
                        Console.WriteLine($"Oyuncu = {oyuncuToplam}, Bot = {botToplam}");
                        Console.WriteLine("Bot kazandi.");
                        Console.WriteLine("Bot: Ben kazandim! Bir an olsun kendimden süphe etmedim.");
                      
                    }
                    else
                    {
                        Console.WriteLine($"Oyuncu = {oyuncuToplam}, Bot = {botToplam}");
                        Console.WriteLine("Oyuncu ve bot berabere kaldi");
                        Console.WriteLine("Bot: Berabere kaldik!");
                    }
                    Console.WriteLine("Tekrar Oynamak ister misin? (evet/hayir)");
                    string devam = Console.ReadLine().ToLower();
                    if (devam == "hayir")
                    {
                        Console.WriteLine("Oyun icin tesekkür ederim!");
                        break;
                    }
                    else if (devam == "evet")
                    {
                        Console.WriteLine("Bunu duyduguma sevindim!");
                    }
                    else
                    {
                        Console.WriteLine("Hatali yazim");
                        break;
                    }
                }
                else if (oyun == "hayir")
                {
                    Console.WriteLine("Ah! Oynamak cok istiyordum. ");
                    break; 
                }
                else 
                {
                    Console.WriteLine("Hatali yazim");
                    break;
                }

            }
        }
    }
}