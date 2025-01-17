namespace GeminiAPI.Models
{
    public class GenerationConfig
    {
        public int Temperature { get; set; }
        public int TopK { get; set; }
        public int TopP { get; set; }
        public int MaxOutputTokens { get; set; }
        public List<object> StopSequences { get; set; }

        public string? ResponseMimeType { get; set; } = "text/plain"; // application/json is for strcutured output
        public ResponseSchema ResponseSchema { get; set; }
    }
}