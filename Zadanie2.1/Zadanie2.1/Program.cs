using Zadanie2._1;

Container container = new Container(5000, 300, 2000, 800, 9000);
GasContainer gasContainer = new GasContainer(2000, 300, 2000, 800, 9000);
ContainerShip containerShip = new ContainerShip("DDDD",30,200, 50);
ContainerShip containerShip1 = new ContainerShip("XXXX",30,200, 50);

containerShip.addContainer(container);

///
void allAboutShip(ContainerShip containerShip)
{
    Console.WriteLine(containerShip.ToString());
    Console.WriteLine();
    containerShip.showAllContainers();
    
}
allAboutShip(containerShip);

///
void allAboutContainer(Container container)
{
    Console.WriteLine(container.ToString());
}
Console.WriteLine();
allAboutContainer(container);


///
void changeShip(ContainerShip containerShip1, ContainerShip containerShip2, Container container)
{
    containerShip1.removeContainer(container);
    containerShip2.addContainer(container);
}
changeShip(containerShip,containerShip1, container);
Console.WriteLine("########");
allAboutShip(containerShip);
Console.WriteLine("########");
allAboutShip(containerShip1);

///
void containerReplace(ContainerShip containerShip, Container container, string s)
{
    containerShip.replace(container, s);
}
containerReplace(containerShip1,gasContainer,"KON-C-1");
Console.WriteLine("########");
allAboutShip(containerShip1);

///
void unloadContainer(Container container)
{
    container.unloadingContainer();
}
Console.WriteLine("########");
unloadContainer(gasContainer);
allAboutContainer(gasContainer);

void removeContainer(ContainerShip containerShip, Container container)
{
    containerShip.removeContainer(container);
}
Console.WriteLine("########");
removeContainer(containerShip1,gasContainer);
allAboutShip(containerShip1);

void addListofContainers(ContainerShip containerShip, List<Container> lista)
{
    foreach (Container container in lista)
    {
        containerShip.addContainer(container);
    }
}
List<Container> listaC = new List<Container>();
listaC.Add(container);
listaC.Add(gasContainer);
addListofContainers(containerShip1, listaC);
Console.WriteLine("########");
allAboutShip(containerShip1);

void addContainer(ContainerShip containerShip, Container container)
{
    containerShip.addContainer(container);
}

void loadContainer(Container container, double weight)
{
    container.loadingContainer(weight);
}

Container makeContainer(double weight, double height, double containerWeight, double depth,
    double maxAcceptableWeight)
{
    Container container = new Container(weight, height, containerWeight, depth, maxAcceptableWeight);
    return container;
}



