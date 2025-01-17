using GeminiAPI.Enums;
using GeminiAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace GeminiAPI.Builders
{
    public class GenerationConfigBuilder
    {
        private GenerationConfig _config;

        public GenerationConfigBuilder()
        {
            _config = new GenerationConfig();
        }

        public GenerationConfig Build()
        {
            return _config;
        }

        public GenerationConfigBuilder SetNumbers(int temperature, int topP, int topK, int maxOutputTokens)
        {
            _config.Temperature = temperature;
            _config.TopP = topP;
            _config.TopK = topK;
            _config.MaxOutputTokens = maxOutputTokens;

            return this;
        }

        public GenerationConfigBuilder AddStopSequence(string stopSequence)
        {
            if (_config.StopSequences == null) { _config.StopSequences = new List<object>(); }

            _config.StopSequences.Add(stopSequence);

            return this;
        }

        public GenerationConfigBuilder SetResponseMimeType(ResponseMimeType type)
        {
            switch (type)
            {
                case ResponseMimeType.Text_Plain:
                    _config.ResponseMimeType = "text/plain";
                    break;
                case ResponseMimeType.Application_Json:
                    _config.ResponseMimeType = "application/json";
                    break;
                case ResponseMimeType.Text_XEnum:
                    _config.ResponseMimeType = "text/x.enum";
                    break;
                default:
                    break;
            }

            return this;
        }

        public GenerationConfigBuilder AddJsonObjectToResopnseSchema(string name, DataType type)
        {
            // This is some serious engineering.
            // https://ai.google.dev/gemini-api/docs/structured-output?lang=rest#generate-json

            if (_config.ResponseSchema == null)
            {
                _config.ResponseSchema = new ResponseSchema()
                {
                    Type = DataType.ARRAY,
                    Items = new ResponseSchema()
                    {
                        Type = DataType.OBJECT,
                        Properties = new Dictionary<string, ResponseSchema>()
                    }
                };
            }

            _config.ResponseSchema.Items.Properties.Add(name, new ResponseSchema() { Type = type });

            return this;
        }
    }
}
