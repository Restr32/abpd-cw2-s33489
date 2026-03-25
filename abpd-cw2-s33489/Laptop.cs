namespace abpd_cw2_s33489;

public class Laptop : Sprzet{
    private int ram { get; set; }
    private int dyskGb { get; set; }

    public Laptop(string name, bool dostep, int[] resolution, int ram, int dyskGb) :base(name, dostep, resolution) {
        this.ram = ram;
        this.dyskGb = dyskGb;
    }
    public Laptop(string name, int[] resolution, int ram, int dyskGb) :base(name, resolution) {
        this.ram = ram;
        this.dyskGb = dyskGb;
    }
}