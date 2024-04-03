namespace FlavorNet.Services
{
    public interface ISentimentProcessor
    {
        Task<string> GetSentiment(string apiEndPoint, string apiKey, string model, string comment);
    }
}
