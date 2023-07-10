using BumbleBikesLibrary;
using ObserverExample;

var logisticsSubject = new LogisticSubject();

var exFed = new ExFedObserver();
logisticsSubject.Attach(exFed);

var pickupOrder = new List<Bicycle>();

for(var i=0; i<99; i++)
{
    var bike = new MountainBike();
    Thread.Sleep(3000);
    Console.WriteLine(bike.ToString());
    pickupOrder.Add(bike);

    if(pickupOrder.Count > 9)
    {
        logisticsSubject.NotifyAvailable();
        pickupOrder.Clear();
    }
}

logisticsSubject.Detach(exFed);
