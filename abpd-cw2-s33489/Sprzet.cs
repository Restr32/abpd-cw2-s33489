namespace abpd_cw2_s33489;

public class Sprzet {
    private static int previousId;
    private int id { get; }
    private string name { get; set; }
    private bool dostep { get; set; } = true;
    private int[] resolution { get; }

    public Sprzet(string name, bool dostep, int[] resolution) {
        this.name = name;
        this.dostep = dostep;
        this.resolution = resolution;
        id = previousId;
        previousId++;
    }

    public Sprzet(string name, int[] resolution) {
        this.name = name;
        this.resolution = resolution;
        id = previousId;
        previousId++;
    }
}