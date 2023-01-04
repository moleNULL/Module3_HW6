namespace MessageBoxAsync
{
    internal class Starter
    {
        public static async Task RunAsync()
        {
            var messageBox = new MessageBox();

            int num = 5;
            Console.WriteLine($"\t{num} calls of MessageBox.Open():\n\n");

            for (int i = 0; i < num; i++)
            {
                await messageBox.Open();
            }
        }
    }
}
