namespace MessageBoxAsync
{
    internal class StateGenerator
    {
        public static State GenerateRandomState()
        {
            // Get the maxValue out of enum State for Random()
            int numberOfEnums = Enum.GetNames(typeof(State)).Length;

            return (State)new Random().Next(numberOfEnums);
        }
    }
}
