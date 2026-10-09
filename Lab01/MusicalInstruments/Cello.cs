namespace MusicalInstruments
{
    public class Cello : MusicalInstrument
    {
        public Cello()
            : base("Віолончель", "Великий смичковий інструмент басово-тенорового регістру, на якому грають сидячи")
        {
        }

        public Cello(string features)
            : base("Віолончель", features)
        {
        }

        public Cello(string title, string features)
            : base(title, features)
        {
        }

        public Cello(Cello other)
            : base(other)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Звучання: глибокий, оксамитовий, співучий тембр");
        }

        public override void Show()
        {
            Console.WriteLine($"Інструмент: {Title}");
        }

        public override void Desc()
        {
            Console.WriteLine($"Характеристики: {Features}");
        }

        public override void History()
        {
            Console.WriteLine("Історія: сформувалася в Італії на початку XVI ст.; як сольний інструмент утвердилася в XVIII ст.");
        }
    }
}
