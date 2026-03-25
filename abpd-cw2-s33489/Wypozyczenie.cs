namespace abpd_cw2_s33489;

public class Wypozyczenie { //wyporzyczenie na 90 dni
    private static int prevId;
    public int id;
    private Czlowiek kto { get; }
    private Sprzet co { get; }
    private DateTime kiedy { get; }
    private int dni { get; }
    private bool zwrotTermin { get; }

    public Wypozyczenie(Czlowiek kto, Sprzet co, int dni) {
        this.kto = kto;
        this.co = co;
        kiedy = DateTime.Now;
        this.dni = dni;
        zwrotTermin = isOnTime();
        id = prevId;
        prevId++;
    }

    private bool isOnTime() {
        return kiedy.AddDays(dni) <= kiedy.AddDays(Reduly.days);
    }
}