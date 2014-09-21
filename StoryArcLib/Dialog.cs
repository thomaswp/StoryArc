using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoryArc.Actions;

namespace StoryArc
{
    public class Dialog
    {
        public readonly StoryGame game;
        public readonly List<DialogAction> actions = new List<DialogAction>();

        public string Name { get; set; }

        public Dialog(StoryGame game)
        {
            this.game = game;
            this.Name = "New Dialog";
        }
    }
}
