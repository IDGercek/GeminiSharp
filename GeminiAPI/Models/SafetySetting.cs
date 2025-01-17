using GeminiAPI.Enums;

namespace GeminiAPI.Models
{
    public class SafetySetting
    {
        public HarmCategory Category { get; set; }
        public SafetyTreshold Threshold { get; set; }
    }
}