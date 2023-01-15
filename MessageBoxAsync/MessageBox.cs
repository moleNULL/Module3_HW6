namespace MessageBoxAsync
{
    internal class MessageBox
    {
        public MessageBox()
        {
            NotifyWindowsClosed += ConfirmWindowClosed;
        }

        public event Action<State> NotifyWindowsClosed;

        public async Task Open()
        {
            Console.WriteLine("The window is open");
            await Task.Delay(3000);
            Console.WriteLine("The window was closed by user");

            NotifyWindowsClosed?.Invoke(StateGenerator.GenerateRandomState());
        }

        public void ConfirmWindowClosed(State state)
        {
            switch (state)
            {
                case State.Ok:
                    Console.WriteLine("The operation has been confirmed");
                    break;
                case State.Cancel:
                    Console.WriteLine("The operation has been canceled");
                    break;
                default:
                    throw new ArgumentException();
            }

            Console.WriteLine();
        }
    }
}
