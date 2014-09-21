using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoryArc
{
    public class RichTextBoxBinding : Binding
    {
        private RichTextBox textBox;

        public RichTextBoxBinding(RichTextBox textBox, Accessor accessor) : base(textBox, accessor)
        {
            this.textBox = textBox;
        }

        protected override void SetValue(object value)
        {
            textBox.Text = (string)value;
        }

        protected override object GetValue()
        {
            return textBox.Text;
        }
    }
}
