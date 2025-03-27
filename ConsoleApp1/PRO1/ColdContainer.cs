namespace PRO1;

public class ColdContainer : Container
{
    public string type;
    public float temperature;
    public ColdContainer(float capacity, float ownMass, float height, float depth, string type, float temperature)
        : base("C", capacity, ownMass, height, depth)
    {
        this.type = type;
        this.temperature = temperature;
    }

    public void empty()
    {
        base.empty();
    }

    public void load(float mass, string productType)
    {
        if (productType != this.type)
        {
            throw new ArgumentException("Invalid product type");
        }
        base.load(mass);
    }
}