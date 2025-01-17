using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiAPI.Enums
{
    // https://ai.google.dev/api/generate-content#HarmProbability
    public enum HarmProbability
    {
        HARM_PROBABILITY_UNSPECIFIED,   //  Probability is unspecified.
        NEGLIGIBLE,                     // 	Content has a negligible chance of being unsafe.
        LOW,                            // 	Content has a low chance of being unsafe.
        MEDIUM,                         // 	Content has a medium chance of being unsafe.
        HIGH                            // 	Content has a high chance of being unsafe.
    }
}
