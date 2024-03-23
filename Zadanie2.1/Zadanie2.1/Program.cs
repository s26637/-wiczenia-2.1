using Zadanie2._1;

Container container = new Container(5000, 200, 1000, 500, "C", 4000);

Console.WriteLine(container.ToString());

container.unloadingContainer();

Console.WriteLine(container.ToString());

container.loadingContainer(5000);

Console.WriteLine(container.ToString());

