using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoryArc.Dialog;

namespace StoryArc
{
    public class Conversation
    {
        private readonly StoryGame game;
        private readonly List<StoryAction> actions = new List<StoryAction>();

        public Conversation(StoryGame game)
        {
            this.game = game;
        }
    }
}
