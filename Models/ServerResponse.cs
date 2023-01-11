namespace mekashron.Models
{
    public class ServerResponse
    {
        public string EntityId { get; init; } = string.Empty;
        public string FirstName { get; init; } = string.Empty;
        public string LastName { get; init; } = string.Empty;
        public int? ResultCode { get; init; }
        public string? ResultMessage { get; init; }
    }
}
