using GeminiAPI.Enums;
using GeminiAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiAPI
{
    public class GeminiRequestBuilder
    {
        private GeminiRequest _request;

        public GeminiRequestBuilder()
        {
            _request = new GeminiRequest();
        }

        public GeminiRequest Build()
        {
            return _request;
        }

        /// <summary>
        /// Sets the prompt to the request.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public GeminiRequestBuilder SetPrompt(string prompt)
        {
            if (_request.Contents == null) { _request.Contents = new List<Content>(); }

            // Add new content
            _request.Contents.Add(
                new Content
                {
                    Role = "user",
                    Parts = new List<Part>
                    {
                        new Part
                        {
                            Text = prompt,
                        }
                    }
                });

            return this;
        }

        /// <summary>
        /// Sets the system instruction (aka. system prompt) to the request.
        /// </summary>
        /// <param name="systemInstruction"></param>
        /// <returns></returns>
        public GeminiRequestBuilder SetSystemInstruction(string? systemInstruction)
        {
            // TODO: Instead of setting the object all over, just add a new Part to it. 
            // Set the _request.SystemInstruction object
            _request.SystemInstruction = new SystemInstruction()
            {
                Parts = new List<Part>()
                {
                    new Part()
                    {
                        Text = systemInstruction
                    }
                }
            };
            return this;
        }

        public GeminiRequestBuilder SetGenerationConfig(GenerationConfig generationConfig)
        {
            _request.GenerationConfig = generationConfig;

            return this;
        }

        public GeminiRequestBuilder AddSafetySetting(SafetySetting safetySetting)
        {
            if (_request.SafetySettings == null) { _request.SafetySettings = new List<SafetySetting>(); }

            _request.SafetySettings.Add(safetySetting);

            return this;
        }
        public GeminiRequestBuilder AddSafetySetting(HarmCategory category, SafetyTreshold treshold)
        {
            return AddSafetySetting(new SafetySetting()
            {
                Category = category,
                Threshold = treshold
            });
        }

    }
}
