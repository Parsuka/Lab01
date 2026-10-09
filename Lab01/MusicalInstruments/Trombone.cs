namespace MusicalInstruments
{
    public class Trombone : MusicalInstrument
    {
        public Trombone()
            : base("Тромбон", "Мідний духовий інструмент тенорового регістру з висувною кулісою")
        {
        }

        public Trombone(string features)
            : base("Тромбон", features)
        {
        }

        public Trombone(string title, string features)
            : base(title, features)
        {
        }

        public Trombone(Trombone other)
            : base(other)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Звучання: густий, потужний, трохи гудучий звук");
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
            Console.WriteLine("Історія: виник у XV ст. у Європі з кулісної труби; у середньовіччі мав назву «сакбут».");
        }
    }
}
