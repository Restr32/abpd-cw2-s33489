namespace abpd_cw2_s33489;

public class Puppeteer {
    private Serwis serwo;

    public Puppeteer() {
        serwo = new Serwis();
        serwo.addSprzet(new Laptop("ASUS", new []{1080, 1920}, 32, 128));
        serwo.getMeSprzet();
    }
    
}