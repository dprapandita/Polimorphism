using Polimorphism;

Raja raja = new Raja();
Console.WriteLine($"Catur: {raja.Name}");
raja.Berjalan();
raja.Makan();

Ratu ratu = new Ratu();
Console.WriteLine($"\nCatur: {ratu.Name}");
ratu.Berjalan();
ratu.Makan();

Benteng benteng = new Benteng();
Console.WriteLine($"\nCatur: {benteng.Name}");
benteng.Berjalan();
benteng.Makan();

Pion pion = new Pion();
Console.WriteLine($"\nCatur: {pion.Name}");
pion.Berjalan();
pion.Makan();

Menteri menteri = new Menteri();
Console.WriteLine($"\nCatur: {menteri.Name}");
menteri.Berjalan();
menteri.Makan();

Kuda kuda = new Kuda();
Console.WriteLine($"\nCatur: {kuda.Name}");
kuda.Berjalan();
kuda.Makan();