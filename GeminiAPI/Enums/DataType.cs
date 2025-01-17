using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiAPI.Enums
{
    // https://ai.google.dev/api/caching#Type
    public enum DataType
    {
        TYPE_UNSPECIFIED,
        STRING,
        NUMBER,
        INTEGER,
        BOOLEAN,
        ARRAY,
        OBJECT
    }
}
