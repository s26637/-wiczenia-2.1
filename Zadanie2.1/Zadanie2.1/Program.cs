using Zadanie2._1;

// Container container = new Container(5000, 200, 1000, 500, 4000);
//
// Console.WriteLine(container.ToString());
//
// container.unloadingContainer();
//
// Console.WriteLine(container.ToString());
//
// container.loadingContainer(4000);
//
// Console.WriteLine(container.ToString());


Console.WriteLine("\n####################################\n");

LiquidContainer liquidContainer = new LiquidContainer(3000, 200, 1000, 500, 4000, true);

liquidContainer.unloadingContainer();

Console.WriteLine(liquidContainer.ToString());

liquidContainer.loadingContainer(1900);

Console.WriteLine(liquidContainer.ToString());



