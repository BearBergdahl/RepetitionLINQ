using System.ComponentModel;

namespace RepetitionLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kund> kunderTillForetaget = new List<Kund>();
            kunderTillForetaget.Add(new Kund("ljugsrg", "hgsdrg"));
            kunderTillForetaget.Add(new Kund("Alligator", "Krokodil"));
            kunderTillForetaget.Add(new Kund("Alligator", "Kajman"));
            kunderTillForetaget.Add(new Kund("Alligator", "Sköldpadda"));
            var Something = kunderTillForetaget
                .Where(kund => kund.Name == "Alligator")
                .Select(kund => kund.Description)
                .Where(description => description == "Sköldpadda").ToList();

            List<Kund> resultOfWhere = new List<Kund>();   

            foreach (Kund kund in kunderTillForetaget) 
            {
                if (kund.Name == "Alligator")
                {
                    resultOfWhere.Add(kund);
                }
            }

            List<string> descr = new List<string>();

            foreach (Kund kund in resultOfWhere)
            { 
                descr.Add(kund.Description);
            }

            List<string> filterDescr = new List<string>();

            foreach(string description in descr)
            {
                if (description == "Sköldpadda")
                {
                    filterDescr.Add(description);
                }
            }

            if (Something[0].Equals(filterDescr[0]))
            {
                Console.WriteLine("Success!");
            }

        }
    }
}
