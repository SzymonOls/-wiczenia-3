// See https://aka.ms/new-console-template for more information

namespace PRO1;


class Programs
{
    static void Main(string[] args)
    {
        Ship ship1 = new Ship(100, 5, 300);
        Ship ship2 = new Ship(100, 5, 300);
        LiquidContainer lc = new LiquidContainer(10, 10, 20, 10, true);
        GasContainer gc = new GasContainer(10, 10, 20, 10, 10);
        ColdContainer cc = new ColdContainer(10, 10, 10, 10, "bananas", 20);
        
        Console.WriteLine(lc);
        Console.WriteLine(gc);
        Console.WriteLine(cc);
        
        lc.load(5);
        gc.load(2);
        cc.load(2, "bananas");
        Console.WriteLine(lc);
        Console.WriteLine(gc);
        Console.WriteLine(cc);
        
        ship1.LoadContainer(lc);
        ship1.LoadContainer(gc);
        ship1.LoadContainer(cc);
        Console.WriteLine(ship1);
        
        ship1.RemoveContainer("KON-L-1");
        Console.WriteLine(ship1);
        
        lc.empty();
        Console.WriteLine(lc);
        
        ship1.ReplaceContainer("KON-L-1",gc);
        
        ship1.TransferContainer(ship2, "KON-C-3");
        Console.WriteLine(ship2);
    }
}