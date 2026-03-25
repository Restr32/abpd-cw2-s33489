namespace abpd_cw2_s33489;

public class Camera : Sprzet{
    private string producent { get; }
    private bool usb { get; }
    public Camera(string name, bool dostep, int[] resolution, string producent, bool usb) : base(name, dostep, resolution) {
        this.producent = producent;
        this.usb = usb;
    }
    public Camera(string name, int[] resolution, string producent, bool usb) : base(name, resolution) {
        this.producent = producent;
        this.usb = usb;
    }

    public override string ToString() {
        return base.ToString() + $"Producent: {producent} " +
               $"Czy ma usb: {usb}\tCamera";
    }
}