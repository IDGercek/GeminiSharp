using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiAPI.Enums
{
    // https://ai.google.dev/gemini-api/docs/safety-settings
    public enum HarmCategory
    {
        HARM_CATEGORY_HATE_SPEECH,       //Hate speech 	        Content that is rude, disrespectful, or profane. 
        HARM_CATEGORY_SEXUALLY_EXPLICIT, //Sexually explicit 	Contains references to sexual acts or other lewd content. 
        HARM_CATEGORY_DANGEROUS_CONTENT, //Dangerous 	        Promotes, facilitates, or encourages harmful acts. 
        HARM_CATEGORY_HARASSMENT,        //Harassment 	        Negative or harmful comments targeting identity and/or protected attributes. 
        HARM_CATEGORY_CIVIC_INTEGRITY    //Civic integrity 	    Election-related queries.  IMPORTANT: May not be supported, not enough information on docs.
    }
}
