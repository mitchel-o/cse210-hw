using System;
using System.Collections.Generic;
namespace JournalProgram
{

    public class PromptGenerator
    {
        private List<string> _prompts = new List<string>
    {
        "What made me happy today?",
        "What did I learn today?",
        "What am I grateful for?",
        "What challenged me today?",
        "What would I like to improve tomorrow?",
        "Who made a positive impact on my day?"
    };
        public string GetRandomPrompt()
        {
            Random random = new Random();

            int index = random.Next(_prompts.Count);

            return _prompts[index];
        }
    }
}