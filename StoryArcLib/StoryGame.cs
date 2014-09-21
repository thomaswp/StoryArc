using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryArc
{
    public class StoryGame
    {
        public List<Character> Characters { get; private set; }
        public List<Dialog> Dialogs { get; private set; }

        public StoryGame() 
        {
            Characters = new List<Character>();
            Dialogs = new List<Dialog>();
        }

        public Dialog AddDialog()
        {
            Dialog dialog = new Dialog(this);
            Dialogs.Add(dialog);
            return dialog;
        }
    }
}
