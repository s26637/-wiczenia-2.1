namespace Zadanie2._1;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double weight, double height, double containerWeight, double depth, double maxAcceptableWeight) : base(weight, height, containerWeight, depth, maxAcceptableWeight)
    {
        this.serialNumber = "KON-G-" + number;
    }


    public void dangerNotification(string s)
    {
        Console.WriteLine("NIEBEZPIECZEŃSTWO NR KONTENERA: " + s);
    }

    public override void unloadingContainer()
    {
        weight = weight * 0.05;
    }
    
    
    
}