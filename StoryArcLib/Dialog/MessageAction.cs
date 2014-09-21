using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryArc.Actions
{
    public class MessageAction : DialogAction
    {
        public string Message { get; set; }
        public Character Speaker { get; set; }
    }
}
