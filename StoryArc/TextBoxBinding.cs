using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace StoryArc
{
    public class TextBoxBinding : Binding
    {
        private readonly TextBox textBox;

        public TextBoxBinding(TextBox textBox, PropertyInfo field) : base(textBox, field)
        {
            this.textBox = textBox;
            textBox.TextChanged += controlValueChanged;
        }

        protected override void SetValue(object value)
        {
            textBox.Text = (string) value;
        }

        protected override object GetValue()
        {
            return textBox.Text;
        }
    }
}
