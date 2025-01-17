using GeminiAPI.Enums;

namespace GeminiAPI.Models
{
    public class PromptFeedback
    {
        public BlockReason BlockReason { get; set; }
        public List<SafetyRating> SafetyRatings { get; set; }
    }
}