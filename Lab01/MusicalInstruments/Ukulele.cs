namespace MusicalInstruments
{
    public class Ukulele : MusicalInstrument
    {
        public Ukulele()
            : base("Укулеле", "Невелика чотириструнна щипкова гітара")
        {
        }

        public Ukulele(string features)
            : base("Укулеле", features)
        {
        }

        public Ukulele(string title, string features)
            : base(title, features)
        {
        }

        public Ukulele(Ukulele other)
            : base(other)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Звучання: легкий, світлий, дзвінкий звук");
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
            Console.WriteLine("Історія: з'явилася на Гаваях у 1880-х роках на основі португальської гітари кавакіньо.");
        }
    }
}
