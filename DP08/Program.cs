using static System.Console;
namespace DP08;

public class Program
{
    static void Main(string[] args)
    {
        var oven = new Oven();
        while(true)
        {
            WriteLine("Выберите действие:");
            WriteLine("1. Показать состояние духовки");
            WriteLine("2. Включить духовку");
            WriteLine("3. Включить духовку с таймером");
            WriteLine("4. Выключить духовку");
            WriteLine("5. Выйти");

            var choice = ReadLine();

            switch (choice)
            {
                case "1":
                    oven.DisplayState();
                    break;
                case "2":
                    Write("Введите температуру (180-240°C): ");
                    var temperature = int.Parse(ReadLine()!);
                    oven.TurnOn(temperature);
                    break;
                case "3":
                    Write("Введите температуру (180-240°C): ");
                    temperature = int.Parse(ReadLine()!);
                    oven.TurnOn(temperature);
                    Write("Введите время в минутах: ");
                    var minutes = int.Parse(ReadLine()!);
                    oven.SetTimer(minutes);

                    WriteLine($"Духовка выключится через {minutes} минут.");
                    System.Threading.Thread.Sleep(minutes  * 1000);
                    WriteLine($"Духовка была выключена по истечению {minutes} минут.");
                    oven.TurnOff();
                    break;
                case "4":
                    oven.TurnOff();
                    break;
                case "5":
                    return;
                default:
                    WriteLine("Неверный выбор");
                    break;
            }

            WriteLine();
        }


    }
}
