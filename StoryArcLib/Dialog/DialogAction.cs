using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryArc.Dialog
{
    public class DialogAction : StoryAction
    {
        public string Message { get; set; }
        public Character Speaker { get; set; }
    }
}
