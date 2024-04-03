using Azure.AI.OpenAI;
using Azure;

namespace FlavorNet.Services
{
    public class OpenAiSentimentProcessor  : ISentimentProcessor
    {
        public async Task<string> GetSentiment(string apiEndPoint, string apiKey, string model, string comment)
        {
            OpenAIClient client = new OpenAIClient(
new Uri(apiEndPoint),
new AzureKeyCredential(apiKey));

            try
            {
                Response<ChatCompletions> responseWithoutStream = await client.GetChatCompletionsAsync(
      model,
      new ChatCompletionsOptions()
      {
          Messages =
          {
            new ChatMessage(ChatRole.System, @"return the sentiment of the text in only one word.   The options are bad, ok and great"),
            new ChatMessage(ChatRole.User, comment),
          },
          Temperature = (float)0.7,
          MaxTokens = 800,
          NucleusSamplingFactor = (float)0.95,
          FrequencyPenalty = 0,
          PresencePenalty = 0,
      });

                ChatCompletions completions = responseWithoutStream.Value;

                await Task.Delay(100);

                if ((completions != null) && (completions.Choices.Count > 0))
                    return completions.Choices[0].Message.Content;
                else return "na";

            }
            catch (Exception ex)
            {
                return "na";
            }

         


        }

    }
}

