using GeminiAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiAPI.Models
{
    public class ResponseSchema
    {
        public DataType Type { get; set; }
        public bool? Nullable { get; set; }
        public Dictionary<string, ResponseSchema> Properties { get; set; }
        public ResponseSchema Items { get; set; }

    }
}
