using System.Text;

namespace MusicalInstruments
{
    internal class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            MusicalInstrument[] instruments = new MusicalInstrument[5];
            instruments[0] = new Violin();
            instruments[1] = new Trombone("Тенор-тромбон", "Мідний духовий інструмент із квартвентилем");
            instruments[2] = new Ukulele("Корпус з червоного дерева, нейлонові струни");
            instruments[3] = new Cello();

            Violin copy = new Violin((Violin)instruments[0]);
            copy.SetTitle("Скрипка (копія)");
            copy.SetFeatures("Копія скрипки зі зміненою назвою");
            instruments[4] = copy;

            foreach (MusicalInstrument instrument in instruments)
            {
                instrument.ShowInfo();
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Оригінал не змінився: {instruments[0].GetTitle()}");
            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
