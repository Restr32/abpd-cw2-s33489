namespace abpd_cw2_s33489;

public class Czlowiek {
    private int id { get; }
    private string name { get; set; }
    private string surname { get; set; }
    public uzytkownik typ { get; set; }

    public Czlowiek(int id, string name, string surname, uzytkownik typ) {
        this.id = id;
        this.name = name;
        this.surname = surname;
        this.typ = typ;
    }

    public override string ToString() {
        return $"{id}\tname: {name} {surname} typ: {typ}";
    }
}