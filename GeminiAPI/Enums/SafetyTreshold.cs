using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiAPI.Enums
{
    // https://ai.google.dev/gemini-api/docs/safety-settings
    public enum SafetyTreshold
    {
        BLOCK_NONE,                         //Block none 	Always show regardless of probability of unsafe content
        BLOCK_ONLY_HIGH,                    //Block few 	Block when high probability of unsafe content
        BLOCK_MEDIUM_AND_ABOVE,             //Block some 	Block when medium or high probability of unsafe content 
        BLOCK_LOW_AND_ABOVE,                //Block most 	Block when low, medium or high probability of unsafe content
        HARM_BLOCK_THRESHOLD_UNSPECIFIED    //N/A 	 	    Threshold is unspecified, block using default threshold
    }
}
