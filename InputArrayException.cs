public class InputArrayException : Exception
{
    public string Reason { get; }
    public InputArrayException(string message, string reason) : base(message)
    {
        Reason = reason;
    }
}