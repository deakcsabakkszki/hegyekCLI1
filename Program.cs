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
        static void Main(string[] args)
        {
            
        }
    }
}
