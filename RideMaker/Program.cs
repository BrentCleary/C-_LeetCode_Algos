Dog Harley = new Dog("Harley", "French Bulldog", "Brown");

Ride Honda = new Ride("Honda", 4, "blue", true, 100);
Ride MountainBike = new Ride("Bike", 1, "white", false, 50);
Ride Plane = new Ride("Skates", 2, "green", true, 1000);
Ride Unicycle = new Ride("Unicycle", 1, "red", true, 100);

Harley._Name = "puppy";


System.Console.WriteLine(Harley._Name);

// Honda
Honda.ShowInfo();
Honda.Travel(50);

MountainBike.ShowInfo();
MountainBike.Travel(100);

List<Ride> rideList = new List<Ride>();
rideList.Add(Honda);
rideList.Add(MountainBike);
rideList.Add(Plane);
rideList.Add(Unicycle);

foreach(Ride vehicle in rideList)
{
  vehicle.ShowInfo();
}

MountainBike.Travel(100);