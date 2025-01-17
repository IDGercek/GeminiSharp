using GeminiAPI;
using GeminiAPI.Enums;
using GeminiAPI.Models;
using GeminiAPI.Builders;

namespace GeminiAPI.Examples
{
    public class BasicTextPrompting
    {
        public static async Task Example(string[] args)
        {
            const string apiKey = "YOUR-API-KEY";
            const string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent";

            var options = new GeminiOptions()
            {
                Url = url,
                ApiKey = apiKey
            };
            var geminiClient = new GeminiClient(options);

            var prompt = "Give me three cookie recipies and their ingredients.";

            var gcBuilder = new GenerationConfigBuilder();
            gcBuilder.SetNumbers(0, 1, 1, 2048); // Temperature, TopP, TopK, MaxOutputTokens
            var generationConfig = gcBuilder.Build();

            var reqBuilder = new GeminiRequestBuilder();
            reqBuilder.SetPrompt(prompt);
            reqBuilder.SetGenerationConfig(generationConfig);
            var geminiRequest = reqBuilder.Build();

            var response = await geminiClient.GenerateContentAsync(geminiRequest, CancellationToken.None);

            Console.WriteLine(response.Candidates[0].Content.Parts[0].Text);
            Console.Read();
        }
    }
}
