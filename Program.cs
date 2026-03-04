using System.Text.Json;

namespace hegyekCLI1
{

    public class Hegycsus
    {
       public string csucsNev {  get; private set; }
       public string hegyseg { get; private set; }
       public int magassag { get; private set; }

        public Hegycsus(string csucsNev, string hegyseg, int magassag)
        {
            this.csucsNev = csucsNev;
            this.hegyseg = hegyseg;
            this.magassag = magassag;
        }

        public Hegycsus(string sor)
        {
            this.csucsNev = sor.Split(';')[0];
            this.hegyseg = sor.Split(';')[1];
            this.magassag = int.Parse(sor.Split(';')[2]);
        }
    }
    public class Program
    {
        public static List<Hegycsus> Hegycsucsok = new List<Hegycsus>();
        static void Main(string[] args)
        {
            
            var Adatok = File.ReadAllLines("hegyek.csv").Skip(1);
            foreach(var line in Adatok)
            {
                Hegycsucsok.Add(new Hegycsus(line));
            }

            MagasabbMint950();

            //11.feladat
            Console.WriteLine("Kérem a keresett szót:");
            string bekert = Console.ReadLine();
            Console.WriteLine("......");
            foreach(var item in Hegycsucsok)
            {
                if(tartalmaz(bekert, item.csucsNev, item.hegyseg))
                {
                    Console.WriteLine(item.csucsNev);
                }
            }

        }

        private static void MagasabbMint950()
        {
            foreach (var hegycsucs in Hegycsucsok)
            {
                if (hegycsucs.magassag>950)
                {
                    Console.WriteLine($"{hegycsucs.csucsNev} {hegycsucs.hegyseg} {hegycsucs.magassag}");
                }
            }
        }

        public static bool tartalmaz(string beirtSzo, string hegyCsucsNeve, string hegysegNeve)
        {
            if (hegysegNeve.Contains(beirtSzo) || hegyCsucsNeve.Contains(beirtSzo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
