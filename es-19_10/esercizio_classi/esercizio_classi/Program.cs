using esercizio_classi;

public class Program
{
    public static void Main()
    {
        
        Televisore tv1 = new Televisore("Samsung", "Smart TV", 100, 0, 20, true);
        Televisore tv2 = new Televisore("Sony", "LCD TV", 200, 0, 100, true);
        Televisore tv3 = new Televisore("Panasonic", "TV LED ULTRA", 18, 0, 80, true);
        
        tv1.ON();

        bool acceso1 = tv1.accesa();
        Console.WriteLine("la tv1 è accesa? " + (acceso1 ?  " si" : "no"));
        

        tv1.Incrementa_canale();
        tv1.AlzaVolume(1);
        Console.WriteLine("informazioni tv1: " +tv1.informazioni());

        tv2.ON();

        bool acceso2 = tv2.accesa();
        Console.WriteLine("la tv2 è accesa? " + (acceso2 ? " si" : "no"));
         

        tv2.decrementa_canale();
        tv2.AbbassaVolume(5);
        Console.WriteLine("informazioni tv2: " + tv2.informazioni());


        tv3.ON();

        bool acceso3 = tv3.accesa();
        Console.WriteLine("la tv3 è accesa? " + (acceso3 ? " si" : "no"));
        tv3.Volumeattuale();

        tv3.Canaleattuale();

        Console.WriteLine("informazioni tv3: " + tv3.informazioni());

    }
}

