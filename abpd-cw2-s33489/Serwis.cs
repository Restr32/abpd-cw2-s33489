using System.Collections;
using System.Security.AccessControl;

namespace abpd_cw2_s33489;

public class Serwis {
    public List<Wypozyczenie> wypoz { get; }
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
    
    

    public void wypozyczenie(int czloId, int sprzeId) {
        bool isExist = false;
        Czlowiek typ = user[0];
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
        Sprzet tmp = sprzet[0];
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

        if (!tmp.dostep)
        {
            throw new Exception("Sprzęt niedostępny");
        }

        int count = wypoz.Count(wypozyczenie1 => wypozyczenie1.kto.id == czloId && !wypozyczenie1.zwrotTermin);

        if (count >= (typ.typ == uzytkownik.Student?Reduly.student:Reduly.employ))
        {
            throw new Exception("Przekroczono limit");
        }

        tmp.dostep = false;
        wypoz.Add(new Wypozyczenie(typ, tmp));
    }

    public double returnSprzet(int sprzeid) {
        bool isExist = false;
        Wypozyczenie tmp = wypoz[0];
        foreach (var spr in wypoz)
        {
            if (spr.co.id == sprzeid)
            {
                isExist = !isExist;
                tmp = spr;
            }
        }

        if (!isExist)
        {
            throw new Exception("Nie został wydany");
        }

        tmp.zwrotTermin = true;
        int ind = (DateTime.Now - tmp.kiedy).Days;
        if (!tmp.isOnTime(ind))
        {
            return (90 - ind) * Reduly.dailyKoszt;
        }
        return 0;
    }

    public void setUszkodzone(int sprzeid) {
        bool isExist = false;
        Sprzet tmp = sprzet[0];
        foreach (var spr in sprzet)
        {
            if (spr.id == sprzeid)
            {
                spr.dostep = false;
            }
        }
    }

    public void wysAktUzyt(int czloid) {
        foreach (var wal in wypoz)
        {
            if (wal.kto.id == czloid && !wal.zwrotTermin)
            {
                Console.WriteLine(wal.ToString());
            }
        }
    }

    public void wysZaUzyt() {
        foreach (var wal in wypoz)
        {
            if (!wal.zwrotTermin && !wal.isOnTime((DateTime.Now-wal.kiedy).Days))
            {
                Console.WriteLine(wal.ToString());
            }
        }
    }

    public void raport() {
        Console.WriteLine("Aktywnych wypożyczeń:");
        foreach (var val in user)
        {
            wysAktUzyt(val.id);
        }
        Console.WriteLine("Przeterminowane wypożyczenia:");
        wysZaUzyt();
        Console.WriteLine("Wszystkie urządzenia:");
        getMeSprzet();
        Console.WriteLine("Z tego dostępnych");
        getMeOpen();
    }
}