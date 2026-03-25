namespace abpd_cw2_s33489;

public class Puppeteer {
    private Serwis serwo;

    public Puppeteer() {
        serwo = new Serwis();
        serwo.addUser(new Czlowiek(332,"Anna", "Kowalska", uzytkownik.Student));
        serwo.addUser(new Czlowiek(432,"Marek", "Nowak", uzytkownik.Dziekan));
        serwo.addUser(new Czlowiek(534,"Marcin", "Grup", uzytkownik.Bibliotekarz));
        serwo.addUser(new Czlowiek(632,"Alicja", "Kot", uzytkownik.Serwisant));
        serwo.addSprzet(new Laptop("ASUS", new []{1200, 1920}, 32, 128));
        serwo.addSprzet(new Laptop("Macbook Pro", new []{1080, 1920}, 8, 256));
        serwo.addSprzet(new Projector("Epson", new []{3600, 4300}, 60.9, true));
        serwo.addSprzet(new Camera("Air 32 pro", new []{6400, 9400}, "Amog", false));
        
        Console.WriteLine("wypożyczenia");
        serwo.wypozyczenie(332, 1);
        serwo.wypozyczenie(332, 2);
        try
        {
            serwo.wypozyczenie(332, 3);
            serwo.wypozyczenie(432, 1);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Błąd:(");
        }

        serwo.wypozyczenie(432, 3);
        serwo.wypozyczenie(632, 0);
        
        Console.WriteLine("zwrot");
        Console.WriteLine($"zwrócono sprzęt, kara: {serwo.returnSprzet(2)}");
        Console.WriteLine($"zwrócono sprzęt, kara: {serwo.returnSprzet(0)}");
        
        Console.WriteLine("raport");
        serwo.raport();
    }
    
}