namespace PRO1;

public class Container
{
    public float height; 
    public float ownMass; // waga kontenera
    public float depth;
    public float capacity; // ładowność kontenera
    public float loadedWeight;
    public string serialNumber;
    public string containerType;

    public static int numberCounter = 1;

    
    public Container(string containerType, float capacity, float ownMass, float height, float depth)
    {
        this.containerType = containerType;
        this.capacity = capacity;
        this.ownMass = ownMass;
        this.height = height;
        this.depth = depth;
        this.serialNumber = $"KON-{containerType}-{numberCounter}";
        this.loadedWeight = 0;
        numberCounter++;
    }

    public void empty()
    {
        loadedWeight = 0;
    }

    public void load(float mass)
    {
        loadedWeight = mass;
        if (loadedWeight > capacity)
        {
            loadedWeight = 0;
            throw new OverfillException("cant load container, weight is greater than capacity");
        }
        
    }
    
    
    public override string ToString()
    {
        return $"Container {serialNumber}: Type={containerType}, Capacity={capacity}kg, LoadedWeight={loadedWeight}kg";
    }
}