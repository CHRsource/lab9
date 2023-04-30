public class FunctionxException : Exception
{
    public string Reason { get; }

    public FunctionxException(string message, string reason) : base(message)
    {
        Reason = reason;
    }
}