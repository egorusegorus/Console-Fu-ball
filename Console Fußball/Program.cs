using System;

namespace Console_Fußball
{
    class Fußballer
    {
        public string Vorname;
        public string Name;
        public string Verein;
        public DateTime Geburtstag;
        public int RückNummer;

        public Fußballer(string Vorname1, string Name1, string Verein1, DateTime Geburtstag1, int RückNummer1)
        {
            Vorname = Vorname1;
            Name = Name1;
            Verein = Verein1;
            Geburtstag = Geburtstag1;
            RückNummer = RückNummer1;
        }

        public int Alter()
        {
            DateTime dtNow = DateTime.Now;
            DateTime dtGeb = Geburtstag;
            int nAlter = dtNow.Year - dtGeb.Year;
            if ((dtGeb.Month > dtNow.Month) ||
                ((dtGeb.Month == dtNow.Month) && (dtGeb.Day > dtNow.Day)))
            {
                nAlter--;
            }
            return nAlter;
        }

        public override string ToString()
        {
            string str = "";
            str += "\nVorname: " + Vorname;
            str += "\nName: " + Name;
            str += "\nVerein: " + Verein;
            str += "\nGeburtstag: " + Geburtstag.ToShortDateString();
            str += "\nRückennummer: " + RückNummer;
            str += "\nAlter: " + Alter();

            return str;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Fußballer fußballer = new Fußballer("Marta", "Keinlust", "FCEgal", new DateTime(1998, 3, 2), 23);
            Console.WriteLine(fußballer.ToString());
            Console.ReadLine();
        }
    }
}
