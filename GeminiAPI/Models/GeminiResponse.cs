namespace GeminiAPI.Models
{
    public class GeminiResponse
    {
        public List<Candidate> Candidates { get; set; }
        public PromptFeedback PromptFeedback { get; set; }
        public UsageMetadata UsageMetadata { get; set; }
    }
}