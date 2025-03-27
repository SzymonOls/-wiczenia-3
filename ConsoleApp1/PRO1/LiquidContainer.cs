namespace PRO1;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool isSafe;

    public LiquidContainer(float capacity, float ownMass, float height, float depth, bool isSafe)
    : base("L", capacity, ownMass, height, depth)
    {
        this.isSafe = isSafe;
    }

    public void empty()
    {
        base.empty();
    }
    public void load(float mass)
    {
        float maxAllowedLoad;
        
        if (isSafe)
        { 
            maxAllowedLoad = capacity *0.9f;
        }
        else
        { 
            maxAllowedLoad = capacity* 0.5f;
        }
        
        if (mass > maxAllowedLoad)
        {
            Notify("Overloading a hazardous liquid container!");
            throw new OverfillException("Cannot load container, exceeds safety limits");
        }
        base.load(mass);
    }
    
    public void Notify(string notification)
    {
        Console.WriteLine($"Notify: [{serialNumber}]: {notification}");
    }
}


