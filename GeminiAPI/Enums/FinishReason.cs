using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiAPI.Enums
{
    // https://ai.google.dev/api/generate-content#FinishReason
    public enum FinishReason
    {
        FINISH_REASON_UNSPECIFIED,
        STOP,
        MAX_TOKENS,
        SAFETY,
        RECITATION,
        LANGUAGE,
        OTHER,
        BLOCKLIST,
        PROHIBITED_CONTENT,
        SPII,
        MALFORMED_FUNCTION_CALL
    }
}
