using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoryArc
{
    public class ComboBoxBinding : Binding
    {
        private ComboBox comboBox;

        public ComboBoxBinding(ComboBox comboBox, Accessor accessor) : base(comboBox, accessor)
        {
            this.comboBox = comboBox;
        }

        protected override void SetValue(object value)
        {
            comboBox.SelectedItem = value;
        }

        protected override object GetValue()
        {
            return comboBox.SelectedItem;
        }
    }
}
