using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryArc
{
    public class Bindings
    {
        private readonly List<Binding> bindings = new List<Binding>();

        public event EventHandler OnControlEdited;

        private Object _target;
        public Object Target
        {
            get { return _target; }
            set
            {
                _target = value;
                bindings.ForEach(b => b.Target = value);
            }
        }

        public Bindings AddBinding(Binding binding)
        {
            bindings.Add(binding);
            binding.OnControlEdited += new EventHandler(binding_OnControlEdited);
            return this;
        }

        public Bindings AddBindings(params Binding[] bindings)
        {
            foreach (Binding binding in bindings) AddBinding(binding);
            return this;
        }

        void binding_OnControlEdited(object sender, EventArgs e)
        {
            OnControlEdited(sender, e);
        }

        public void UpdateControls()
        {
            bindings.ForEach(b => b.UpdateControl());
        }
    }
}
