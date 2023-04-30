public class RandomArrayException : Exception
{
    public string Reason { get; }
    public RandomArrayException(string message, string reason) : base(message)
    {
        Reason = reason;
    }
}
