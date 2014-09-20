using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryArc
{
    public class StoryGame
    {
        public List<Character> Characters { get; private set; }
        public List<Conversation> Conversations { get; private set; }

        public StoryGame() 
        {
            Characters = new List<Character>();
            Conversations = new List<Conversation>();
        }

        public Conversation CreateConversation()
        {
            return new Conversation(this);
        }
    }
}
