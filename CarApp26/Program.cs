using CarApp26;

Console.WriteLine("Hello, World!");


Car myCar1 = new Car("Skoda", "Octavia", 2020, "AB 232323", true);
Console.WriteLine($"  {myCar1.Brand}  {myCar1.Model} {myCar1.Year} {myCar1.RegNo} {myCar1.TrackReady}");

myCar1.RegNo = "ZZ343434";
Console.WriteLine($"  {myCar1.Brand}  {myCar1.Model} {myCar1.Year} {myCar1.RegNo} {myCar1.TrackReady}");
Car myCar2 = new Car("Lada", "Riva", 2010, "DD 266712", false);
Console.WriteLine($"  {myCar2.Brand}  {myCar2.Model} {myCar2.Year} {myCar2.RegNo} {myCar2.TrackReady}");
myCar2.TrackReady = true;

myCar2.Drive();

Car myCar3 = new Car();
Console.WriteLine($"  {myCar3.Brand}  {myCar3.Model} {myCar3.Year} {myCar3.RegNo} {myCar3.TrackReady}");
myCar3.TrackReady = true;

myCar1 = myCar3;
myCar3.RegNo = "AB123123";


Console.WriteLine("Her udskriv al information om bilerne");

myCar1.PrintAllINformation();
myCar2.PrintAllINformation();
myCar3.PrintAllINformation();
