using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiAPI.Enums
{
    // https://ai.google.dev/api/generate-content#BlockReason
    public enum BlockReason
    {
        BLOCK_REASON_UNSPECIFIED,   //Default value. This value is unused.
        SAFETY,                     //Prompt was blocked due to safety reasons. Inspect safetyRatings to understand which safety category blocked it.
        OTHER,                      //Prompt was blocked due to unknown reasons.
        BLOCKLIST,                  //Prompt was blocked due to the terms which are included from the terminology blocklist.
        PROHIBITED_CONTENT          //Prompt was blocked due to prohibited content.
    }
}
