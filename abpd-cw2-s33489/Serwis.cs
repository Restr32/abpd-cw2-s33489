using System.Collections;

namespace abpd_cw2_s33489;

public class Serwis {
    private List<Wypozyczenie> wypoz;
    private List<Sprzet> sprzet { get; }

    public Serwis() {
        wypoz = new List<Wypozyczenie>();
        sprzet = new List<Sprzet>();
    }
    public void getMeSprzet() {
        foreach (var tmp in sprzet)
        {
            Console.WriteLine(tmp.ToString());
        }
    }

    public void getMeOpen() {
        foreach (Sprzet tmp in sprzet)
        {
            if (tmp.dostep)
            {
                Console.WriteLine(tmp.ToString());
            }
        }
    }

    public void addSprzet(Sprzet sprzet) {
        this.sprzet.Add(sprzet);
    }
    
}