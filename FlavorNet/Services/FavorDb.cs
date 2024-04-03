using FlavorNet.Data;

namespace FlavorNet.Services
{
    public class FavorDb : IFavorDb
    {
        private FlavorContext _context;
        private IConfiguration _configuration;
        private ISentimentProcessor _sentimentProcessor;
        private ISummaryProcessor _summaryProcessor;

        public FavorDb(FlavorContext context, IConfiguration configuration, ISentimentProcessor sentimentProcessor, ISummaryProcessor summaryProcessor)
        {
            _context = context;
            _configuration = configuration;
            _sentimentProcessor = sentimentProcessor;
            _summaryProcessor = summaryProcessor;

        }
        
        public async Task UpdateAllSentiment()
        {
            string apiKey = _configuration["OpenAiKey"];
            string apiEndpoint = _configuration["OpenAiEndpoint"];
            string model = _configuration["OpenAiModel"];

            var reviews = _context.Reviews.Where(x => x.Sentiment == null).ToList();

            foreach (var review in reviews)
            {
                var sentiment = await _sentimentProcessor.GetSentiment(apiEndpoint, apiKey, model, review.Comment);

                if (sentiment.ToLower().Contains("great"))
                    review.Sentiment = SentimentEnum.Great;
                else

                if (sentiment.ToLower().Contains("ok"))
                    review.Sentiment = SentimentEnum.Ok;
                else
                if (sentiment.ToLower().Contains("bad"))
                    review.Sentiment = SentimentEnum.Bad;

                var summary = await _summaryProcessor.GetSummary(apiEndpoint, apiKey, model, review.Comment);
                review.Summary = summary;

                _context.Reviews.Update(review);
            }

            await _context.SaveChangesAsync();

        }
    }
}
