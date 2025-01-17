using GeminiAPI.Enums;

namespace GeminiAPI.Models
{
    public class SafetyRating
    {
        public HarmCategory Category { get; set; }
        public HarmProbability Probability { get; set; }
    }
}