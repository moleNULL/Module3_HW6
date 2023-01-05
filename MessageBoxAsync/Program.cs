/*
                                                      Задача

класс MessageBox
    ○ Містить метод async Task Open()
        ■ Метод пише на екрані повідомлення з текстом, що відкрито вікно
        ■ потім чекає 3 секунди
        ■ Після чого пише повідомлення, що вікно було закрито користувачем
        ■ Викликаємо подію про те, що вікно закрите і як параметр передаємо випадкове значення State
    ○ Містить подію про те, що вікно було зачинено

enum: State = Ok | Cancel

в Starter викликати метод Open() і написати в консоль якщо State
    ○ Ok - операція була підтверджена
    ○ Cancel - операція була відхилена

 */

namespace MessageBoxAsync
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Starter.RunAsync();

            Console.Write("\nPress any key to continue . . .");
            Console.ReadLine();
        }
    }
}