namespace PRO1;

public class GasContainer : Container, IHazardNotifier
{
    private float pressure;
    
    public GasContainer(float capacity, float ownMass, float height, float depth, float pressure)
        : base("G", capacity, ownMass, height, depth)
    {
        this.pressure = pressure;
    }

    public void empty()
    {
        loadedWeight = 0.05f * loadedWeight;
    }

    public void load(float mass)
    {
        base.load(mass);
    }
    
    public void Notify(string notification)
    {
        Console.WriteLine($"Notify: [{serialNumber}]: {notification}");
    }
}