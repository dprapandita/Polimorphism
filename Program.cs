using Polimorphism;

Raja raja = new Raja();
Console.WriteLine($"Catur: {raja.Name}");
raja.Berjalan();
raja.Makan();

Ratu ratu = new Ratu();
Console.WriteLine($"\nCatur: {ratu.Name}");
ratu.Berjalan();
ratu.Makan();