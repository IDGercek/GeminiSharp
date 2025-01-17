using GeminiAPI;
using GeminiAPI.Enums;
using GeminiAPI.Models;
using GeminiAPI.Builders;

namespace GeminiAPI.Examples
{
    public class AdvancedTextPrompting
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
            var systemInstruction = "You are a cookie chef. You know how to prepare most delicious cookie recipies.";

            var gcBuilder = new GenerationConfigBuilder();
            gcBuilder.SetNumbers(0, 1, 1, 2048); // Temperature, TopP, TopK, MaxOutputTokens
            gcBuilder.SetResponseMimeType(ResponseMimeType.Application_Json);
            gcBuilder.AddJsonObjectToResopnseSchema("recipe", DataType.STRING);
            gcBuilder.AddJsonObjectToResopnseSchema("ingredients", DataType.STRING);
            var generationConfig = gcBuilder.Build();

            var reqBuilder = new GeminiRequestBuilder();
            reqBuilder.SetPrompt(prompt);
            reqBuilder.SetSystemInstruction(systemInstruction);
            reqBuilder.SetGenerationConfig(generationConfig);
            reqBuilder.AddSafetySetting(HarmCategory.HARM_CATEGORY_HARASSMENT, SafetyTreshold.BLOCK_ONLY_HIGH);
            reqBuilder.AddSafetySetting(HarmCategory.HARM_CATEGORY_HATE_SPEECH, SafetyTreshold.BLOCK_ONLY_HIGH);
            reqBuilder.AddSafetySetting(HarmCategory.HARM_CATEGORY_SEXUALLY_EXPLICIT, SafetyTreshold.BLOCK_ONLY_HIGH);
            reqBuilder.AddSafetySetting(HarmCategory.HARM_CATEGORY_DANGEROUS_CONTENT, SafetyTreshold.BLOCK_ONLY_HIGH);
            var geminiRequest = reqBuilder.Build();

            var response = await geminiClient.GenerateContentAsync(geminiRequest, CancellationToken.None);

            Console.WriteLine(response.Candidates[0].Content.Parts[0].Text);
            Console.Read();
        }
    }
}
