using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace StoryArc
{
    public abstract class Binding
    {
        public event EventHandler OnControlEdited;

        private readonly Control control;
        private readonly PropertyInfo field;
        private bool manualUpdate;

        protected abstract void SetValue(object value);
        protected abstract object GetValue();

        private Object _target;
        public Object Target
        {
            get { return _target; }
            set
            {
                _target = value;
                UpdateControl();
            }
        }

        public Binding(Control control, PropertyInfo field)
        {
            this.control = control;
            this.field = field;
        }

        public void UpdateControl()
        {
            if (Target == null)
            {
                SetValue(null);
                this.control.Enabled = false;
            }
            else
            {
                this.control.Enabled = true;
                manualUpdate = true;
                SetValue(field.GetValue(Target, null));
                manualUpdate = false;
            }
        }

        protected void controlValueChanged(object sender, EventArgs e)
        {
            if (Target == null || manualUpdate) return;
            field.SetValue(Target, GetValue(), null);
            OnControlEdited(sender, e);
        }
    }
}
