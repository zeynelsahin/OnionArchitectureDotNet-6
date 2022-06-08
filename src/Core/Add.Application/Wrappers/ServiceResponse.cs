namespace Add.Application.Wrappers;

public class ServiceResponse<T>
{
    public ServiceResponse(T value)
    {
        Value = value;
    }

    protected ServiceResponse()
    {
        
    }
    private T Value { get; set; }
}