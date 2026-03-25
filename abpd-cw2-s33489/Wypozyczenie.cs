namespace abpd_cw2_s33489;

public class Wypozyczenie { //wyporzyczenie na 90 dni
    private static int prevId;
    public int id;
    public Czlowiek kto { get; }
    public Sprzet co { get; }
    public DateTime kiedy { get; }
    public int dni { get; } = 30;
    public bool zwrotTermin { get; set; }

    public Wypozyczenie(Czlowiek kto, Sprzet co, int dni) {
        this.kto = kto;
        this.co = co;
        kiedy = DateTime.Now;
        this.dni = dni;
        zwrotTermin = isOnTime(dni);
        id = prevId;
        prevId++;
    }
    
    public Wypozyczenie(Czlowiek kto, Sprzet co) {
        this.kto = kto;
        this.co = co;
        kiedy = DateTime.Now;
        id = prevId;
        prevId++;
    }

    public bool isOnTime(int dni) {
        return kiedy.AddDays(dni) <= kiedy.AddDays(Reduly.days);
    }

    public override string ToString() {
        return kto.ToString() +" "+ co.ToString() +" "+kiedy.ToString() ;
    }
}