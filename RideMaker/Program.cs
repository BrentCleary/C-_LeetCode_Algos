

Ride Honda = new Car("Gas", 10);
Ride MountainBike = new Bicycle("Legs", 10);
Ride Horse = new Horse("Hay", 10);

// Honda
Honda.ShowInfo();
Honda.Travel(50);

MountainBike.ShowInfo();
MountainBike.Travel(100);

Horse.ShowInfo();
Horse.Travel(200);

List<Ride> rideList = new List<Ride>();
rideList.Add(Honda);
rideList.Add(MountainBike);
rideList.Add(Horse);

List<INeedFuel> HungryVehicles = new List<INeedFuel>();

foreach(Ride ride in rideList)
{
  if(ride is INeedFuel needFuel)
  {
    HungryVehicles.Add(needFuel);
    needFuel.GiveFuel(10);
  }
}



foreach(Ride vehicle in rideList)
{
  vehicle.ShowInfo();
}

MountainBike.Travel(100);