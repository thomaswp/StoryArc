using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StoryArc.Actions;

namespace StoryArc
{
    public partial class MessageActionEditor : Form
    {
        private Bindings bindings = new Bindings();

        private MessageAction _action;
        public MessageAction Action
        {
            get { return _action; }
            set
            {
                _action = value;
                bindings.UpdateControls();
            }
        }

        public MessageActionEditor()
        {
            InitializeComponent();
            bindings.AddBinding(new RichTextBoxBinding(this.richTextBoxMessage, new PropertyAccessor(typeof(MessageAction).GetProperty("Message"))));
            bindings.AddBinding(new ComboBoxBinding(this.comboBoxSpeaker, new PropertyAccessor(typeof(MessageAction).GetProperty("Speaker"))));
        }
    }
}
