namespace Zadanie2._1;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool isDangerCargoType = false;
    public  LiquidContainer(double weight, double height, double containerWeight, double depth, double maxAcceptableWeight, bool isDangerCargoType) : base(weight, height, containerWeight, depth, maxAcceptableWeight)
    {
        this.serialNumber = "KON-L-" + number;
        this.isDangerCargoType = isDangerCargoType;
    }


    public override string ToString()
    {
        if (isDangerCargoType)
        {
            return base.ToString() + "\niebezpieczna zawartość";
        }
        else
        {
            return base.ToString() + "\nbezpieczna zawartość";
        }
    }

    public override void loadingContainer(double weight)
    {
        if (isDangerCargoType)
        {
            if (weight > maxAcceptableWeight / 2)
            {
                dangerNotification(serialNumber);
            }
            else
            {
                base.loadingContainer(weight);
            }
        }
        else
        {
            if (weight > maxAcceptableWeight * 0.8)
            {
                dangerNotification(serialNumber);
            }
            else
            {
                base.loadingContainer(weight);
            }
            
        }
    }


    public void dangerNotification(string s)
    {
        Console.WriteLine("NIEBEZPIECZEŃSTWO NR KONTENERA: " + s);
    }
}