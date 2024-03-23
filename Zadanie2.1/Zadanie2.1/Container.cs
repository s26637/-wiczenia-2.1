namespace Zadanie2._1;

public class Container

{
    public static int number = 1;
        
    
    public double weight { get; set; }
    public double height { get; set; }
    public double containerWeight { get; set; }
    public double depth { get; set; }
    public string serialNumber { get; private set; }
    public double maxAcceptableWeight { get; set; }



    public Container(double weight, double height, double containerWeight, double depth, string type,
        double maxAcceptableWeight)
    {

        this.weight = weight;
        this.height = height;
        this.containerWeight = containerWeight;
        this.depth = depth;
        this.serialNumber = "KON-" + type + "-" + number;
        number += 1;
        this.maxAcceptableWeight = maxAcceptableWeight;
        
    }


    public override string ToString()
    {
        return "Masa ładunku : " + weight
                                 + "\nWysokość kontenera : " + height
                                 + "\nMasa własna konterera : " + containerWeight
                                 + "\nGłębokość : " + depth
                                 + "\nNumer Seryjny : " + serialNumber
                                 + "\nMaksymalna akceptowalna waga : " + maxAcceptableWeight;

    }


    public void unloadingContainer()
    {
        this.weight = 0;
    }

    public void loadingContainer(double weight)
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