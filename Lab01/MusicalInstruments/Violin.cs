namespace MusicalInstruments
{
    public class Violin : MusicalInstrument
    {
        public Violin()
            : base("Скрипка", "Чотириструнний смичковий інструмент найвищого регістру")
        {
        }

        public Violin(string features)
            : base("Скрипка", features)
        {
        }

        public Violin(string title, string features)
            : base(title, features)
        {
        }

        public Violin(Violin other)
            : base(other)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Звучання: тонкий, пісенний, високий тембр");
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
            Console.WriteLine("Історія: сучасний вигляд скрипка отримала в XVI ст. у Північній Італії; найвідоміші майстри — Аматі, Гварнері, Страдіварі.");
        }
    }
}
