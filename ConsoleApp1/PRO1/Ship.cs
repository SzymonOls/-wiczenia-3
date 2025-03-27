namespace PRO1;

public class Ship
{

    public float maxSpeed;
    public int maxContainerAmount;
    public float maxWeight;
    public List<Container> Containers;
    
    public Ship(float maxSpeed, int maxContainerAmount, float maxWeight)
    {
        this.maxSpeed = maxSpeed;
        this.maxContainerAmount = maxContainerAmount;
        this.maxWeight = maxWeight;
        this.Containers = new List<Container>();
    }

    public void LoadContainer(Container container)
    {
        if (Container.numberCounter >= maxContainerAmount)
        {
            throw new Exception("Cant load container, containerCounter is greater than maxContainerAmount");
        }

        float totalWeight = GetTotalWeight() + container.ownMass + container.loadedWeight;

        if (totalWeight > maxWeight)
        {
            throw new Exception("Cant load container, ship already has maximal weight");
        }
        Containers.Add(container);
    }
    
    
    public void RemoveContainer(string serialNumber)
    {
        Containers.RemoveAll(c => c.serialNumber == serialNumber);
    }
    
    public void ReplaceContainer(string serialNumber, Container newContainer)
    {
        RemoveContainer(serialNumber);
        LoadContainer(newContainer);
    }
    
    public void TransferContainer(Ship targetShip, string serialNumber)
    {
        var container = Containers.Find(c => c.serialNumber == serialNumber);
        if (container == null)
            throw new InvalidOperationException("Container not found on this ship.");
        
        RemoveContainer(serialNumber);
        targetShip.LoadContainer(container);
    }
    
    public float GetTotalWeight()
    {
        float totalWeight = 0;
        foreach (var container in Containers)
        {
            totalWeight += container.ownMass + container.loadedWeight;
        }
        return totalWeight;
    }
    
    public override string ToString()
    {
        return $"Container Ship: MaxSpeed={maxSpeed} knots, MaxContainers={maxContainerAmount}, MaxWeight={maxWeight}, CurrentContainers={Containers.Count}";
    }
}