using Wheelchair_Project.Builders;

Console.WriteLine("Hello, World!  Let's make some Plano Wheelchairs");

var builder = new PlanoWheelchairBuilder();
var director = new WheelchairBuilderDirector(builder);

var planoWheelchair = director.Build();
planoWheelchair.DisplayCost();
planoWheelchair.DisplayWeight();