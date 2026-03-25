namespace abpd_cw2_s33489;

public class Projector : Sprzet {
    private double brightness { get; }
    private bool hdmi { get; }

    public Projector(string name, bool dostep, int[] resolution, double brightness, bool hdmi) : base(name, dostep, resolution) {
        this.brightness = brightness;
        this.hdmi = hdmi;
    }
    public Projector(string name, int[] resolution, double brightness, bool hdmi) : base(name, resolution) {
        this.brightness = brightness;
        this.hdmi = hdmi;
    }

    public override string ToString() {
        return base.ToString() + $"Brightness: {brightness} " +
               $"Czy ma hdmi: {hdmi}\tProjektor";
    }
}