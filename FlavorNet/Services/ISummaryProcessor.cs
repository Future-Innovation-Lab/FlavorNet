namespace FlavorNet.Services
{
    public interface ISummaryProcessor
    {
        Task<string> GetSummary(string apiEndPoint, string apiKey, string model, string comment);
    }
}
