namespace Zadanie2._1;

public class ContainerShip
{
    public string id;
    public double maxSpeed;
    public int maxNumofContainers;
    public double maxContainersWeight;
    public ContainerShip(string id, double maxSpeed, int maxNumofContainers, double maxContainersWeight)
    {
        this.maxNumofContainers = maxNumofContainers;
        this.maxSpeed = maxSpeed;
        this.id = id;
        this.maxContainersWeight = maxContainersWeight;
        List<Container> lista = new List<Container>();
    }
}