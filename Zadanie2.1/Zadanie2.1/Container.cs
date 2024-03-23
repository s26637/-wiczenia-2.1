namespace Zadanie2._1;

public class Container

{
    public static int number = 0;


    public double weight;
    public double height;
    public double containerWeight;
    public double depth;
    public string serialNumber;
    public double maxAcceptableWeight;



    public Container(double weight, double height, double containerWeight, double depth,
        double maxAcceptableWeight)
    {

        this.weight = weight;
        this.height = height;
        this.containerWeight = containerWeight;
        this.depth = depth;
        this.serialNumber = makeSerialNumber();
        this.maxAcceptableWeight = maxAcceptableWeight;
        
    }


    public string makeSerialNumber()
    {   
        number += 1;
        return "KON-C-" + number;
    }
    
    public override string ToString()
    {
        return "Numer Seryjny : " + serialNumber
                                 + "\nWysokość kontenera : " + height
                                 + "\nMasa własna konterera : " + containerWeight
                                 + "\nGłębokość : " + depth
                                 + "\nMasa ładunku: " + weight
                                 + "\nMaksymalna akceptowalna waga : " + maxAcceptableWeight;

    }


    public virtual void unloadingContainer()
    {
        this.weight = 0;
    }

    public virtual void loadingContainer(double weight)
    {
        if (weight > this.maxAcceptableWeight)
        {
            throw new OverfillException("Zbyt duży ładunek");
        }
        else
        {
            this.weight = weight;
        }
    }
}