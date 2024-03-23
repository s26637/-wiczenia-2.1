namespace Zadanie2._1;

public class ContainerShip
{
    public string id;
    public double maxSpeed;
    public int maxNumofContainers;
    public double maxContainersWeight;
    public List<Container> lista = new List<Container>();
    public ContainerShip(string id, double maxSpeed, int maxNumofContainers, double maxContainersWeight)
    {
        this.maxNumofContainers = maxNumofContainers;
        this.maxSpeed = maxSpeed;
        this.id = id;
        this.maxContainersWeight = maxContainersWeight;
        
    }

    public void showAllContainers()
    {
        foreach (var c in lista)
        {
            Console.WriteLine(c.ToString());
        }

    }
    
    public override string ToString()
    {
        return "Id: " + id + "\nMaksymalna prędkość: " + maxSpeed + "\nMaksymalna ilość kontenerów: " + maxNumofContainers + "\nMaksmalna waga łaczna kontenerów: " + maxContainersWeight;
        
    }

    public void addContainer(Container container)
    {
        lista.Add(container);
    }

    public void removeContainer(Container container)
    {
        if (lista.Contains(container))
        {
            lista.Remove(container);
        }
    }

    public void replace(Container container, string s)
    {
        foreach (Container c in lista)
        {
            if (c.serialNumber.Equals(s))
            {
                lista.Remove(c);
                lista.Add(container);
                Console.WriteLine("Zamieniono pomyślnie");
                break;
            }
            else
            {
                Console.WriteLine("Nie udało sie zamienić");
            }
            
        }
        
    }
}