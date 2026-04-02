namespace Polimorphism
{
    public class Bidak
    {
        public string Name { get; set; }

        public virtual void Berjalan()
        {
            Console.WriteLine("Pion bergerak.");
        }

        public virtual void Makan() 
        {
            Console.WriteLine("Pion memakan bidak lawan.");
        }
    }

    public class Benteng : Bidak
    {
        public Benteng()
        {
            Name = "Benteng";
        }
        public override void Berjalan()
        {
            Console.WriteLine("Benteng bergerak secara horizontal atau vertikal.");
        }
        public override void Makan()
        {
            Console.WriteLine("Benteng memakan bidak lawan dengan cara yang sama seperti berjalan.");
        }
    }

    public class Menteri : Bidak
    {
        public Menteri()
        {
            Name = "Menteri";
        }

        public override void Berjalan()
        {
            Console.WriteLine("Menteri bergerak secara diagonal.");
        }

        public override void Makan()
        {
            Console.WriteLine("Menteri memakan bidak lawan dengan cara yang sama seperti berjalan.");
        }
    }

    public class Kuda : Bidak
    {
        public Kuda()
        {
            Name = "Kuda";
        }
        public override void Berjalan()
        {
            Console.WriteLine("Kuda bergerak dalam pola L (dua langkah ke satu arah dan satu langkah ke arah lain).");
        }
        public override void Makan()
        {
            Console.WriteLine("Kuda memakan bidak lawan dengan cara yang sama seperti berjalan.");
        }
    }

    public class Raja : Bidak
    {
        public Raja()
        {
            Name = "Raja";
        }

        public override void Berjalan()
        {
            Console.WriteLine("Raja bergerak satu langkah ke segala arah.");
        }

        public override void Makan()
        {
            Console.WriteLine("Raja memakan bidak lawan dengan cara yang sama seperti berjalan.");
        }

    }

    public class Ratu : Bidak
    {
        public Ratu()
        {
            Name = "Ratu";
        }

        public override void Berjalan()
        {
            Console.WriteLine("Ratu bergerak secara horizontal, vertikal, atau diagonal.");
        }

        public override void Makan()
        {
            Console.WriteLine("Ratu memakan bidak lawan dengan cara yang sama seperti berjalan.");
        }

    }

    public class Pion: Bidak
    {
        public Pion()
        {
            Name = "Pion";
        }
        public override void Berjalan()
        {
            Console.WriteLine("Pion bergerak satu langkah ke depan, tetapi pada langkah pertama bisa bergerak dua langkah.");
        }
        public override void Makan()
        {
            Console.WriteLine("Pion memakan bidak lawan secara diagonal ke depan dan kesamping.");
        }
    }

}
