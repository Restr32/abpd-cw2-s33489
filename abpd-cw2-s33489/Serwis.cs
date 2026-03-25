using System.Collections;

namespace abpd_cw2_s33489;

public class Serwis {
    private List<Wypozyczenie> wypoz;
    private List<Czlowiek> user;
    private List<Sprzet> sprzet { get; }

    public Serwis() {
        wypoz = new List<Wypozyczenie>();
        user = new List<Czlowiek>();
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

    public void addUser(Czlowiek czlo) {
        this.user.Add(czlo);
    }
    
    

    public void wypozyczenie(int czloId, int sprzeId, int dni) {
        bool isExist = false;
        Czlowiek typ;
        foreach (var czlos in user)
        {
            if (czlos.id == czloId)
            {
                isExist = !isExist;
                typ = czlos;
            }
        }

        if (!isExist)
        {
            throw new Exception("Nie ma takiego użytkownika");
        }

        isExist = false;
        Sprzet tmp;
        foreach (var spr in sprzet)
        {
            if (spr.id == sprzeId)
            {
                isExist = !isExist;
                tmp = spr;
            }
        }

        if (!isExist)
        {
            throw new Exception("Nie ma takiego sprzetu");
        }

        if (tmp.dostep)
        {
            throw new Exception("Sprzęt niedostępny");
        }

        int count = wypoz.Count(wypozyczenie1 => wypozyczenie1.kto.id == czloId && wypozyczenie1.zwrotTermin);

        if (count >= typ.typ == uzytkownik.Student?Reduly.student:Reduly.employ)
        {
            throw new Exception("Przekroczono limit");
        }

        tmp.dostep = false;
        wypoz.Add(new Wypozyczenie(typ, tmp));
    }
}