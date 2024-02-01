using Models;

namespace Kartotek
{
    public class Varekartotek
    {
        List<Vare> vareListe = new List<Vare>();        
        
        Varekartotek () 
        {
            vareListe.Add(new Vare() { VareNr = 1, Navn = "Mango", Antal = 2, Pris = 5.49 });
            vareListe.Add(new Vare() { VareNr = 2, Navn = "Æble", Antal = 5, Pris = 4.94 });
            vareListe.Add(new Vare() { VareNr = 3, Navn = "Kiwi", Antal = 50, Pris = 10.50 });
            vareListe.Add(new Vare() { VareNr = 4, Navn = "Pære", Antal = 10, Pris = 3.50 });
        }
        
        public bool indset (Vare vare)
        {
            vare.VareNr = vareListe.Max(vare => vare.VareNr) + 1;
            vareListe.Add(vare);
            return true;
        }

        public List<Vare> Get()
        {
            return vareListe;
        }

        public bool delete(int vareNr)
        {
            Vare fundenVare = vareListe.FirstOrDefault(vare => vare.VareNr == vareNr);

            if (fundenVare != null)
            {
                vareListe.Remove(fundenVare);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintVare(Vare vare)
        {
            Console.WriteLine($"VareNr: {vare.VareNr}, Varenavn: {vare.Navn}, Pris: {vare.Pris}, Antal: {vare.Antal}");
        }

        public double beregnVerdi()
        {
            return vareListe.Sum(vare => vare.Antal * vare.Pris);
        }
       
    }
}