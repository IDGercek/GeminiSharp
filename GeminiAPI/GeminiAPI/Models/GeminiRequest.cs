namespace GeminiAPI.Models
{
    public class GeminiRequest
    {
        public List<Content> Contents { get; set; }
        public SystemInstruction SystemInstruction { get; set; }
        public GenerationConfig GenerationConfig { get; set; }
        public List<SafetySetting> SafetySettings { get; set; }

        //TODO: Tools
        //TODO: Tool config
    }
}