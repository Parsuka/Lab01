namespace MusicalInstruments
{
    
    public abstract class MusicalInstrument
    {
        private string _title;
        private string _features;

       
        protected MusicalInstrument()
            : this("Невідомий інструмент", "Характеристики не задані")
        {
        }

        protected MusicalInstrument(string title)
            : this(title, "Характеристики не задані")
        {
        }

        protected MusicalInstrument(string title, string features)
        {
            _title = title;
            _features = features;
        }

        protected MusicalInstrument(MusicalInstrument source)
            : this(source._title, source._features)
        {
        }

        public string Title
        {
            get => _title;
            set => _title = string.IsNullOrWhiteSpace(value) ? "Без назви" : value;
        }

        public string Features
        {
            get => _features;
            set => _features = value ?? string.Empty;
        }

        public void SetTitle(string title) => Title = title;
        public string GetTitle() => Title;
        public void SetFeatures(string features) => Features = features;
        public string GetFeatures() => Features;

        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();

      
        public void ShowInfo()
        {
            Console.WriteLine(new string('-', 50));
            Show();
            Desc();
            Sound();
            History();
        }
    }
}
