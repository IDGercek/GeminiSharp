using GeminiAPI.Enums;

namespace GeminiAPI.Models
{
    public class Candidate
    {
        public Content Content { get; set; }
        public FinishReason FinishReason { get; set; }
        public List<SafetyRating> SafetyRatings { get; set; }
        public int TokenCount { get; set; }
        public double AvgLogprobs { get; set; }
        public int Index { get; set; }

        //TODO: citationMetadata, groundingAttributions[], groundingMetadata, logprobsResult
    }
}