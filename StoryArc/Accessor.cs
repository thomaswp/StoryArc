using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace StoryArc
{
    public interface Accessor
    {
        void SetValue(object target, object value);
        object GetValue(object target);
    }

    public class PropertyAccessor : Accessor
    {
        private PropertyInfo info;

        public PropertyAccessor(PropertyInfo info)
        {
            this.info = info;
        }

        public void SetValue(object target, object value)
        {
            info.SetValue(target, value, null);
        }

        public object GetValue(object target)
        {
            return info.GetValue(target, null);
        }
    }

    public class FieldAccessor : Accessor
    {
        private FieldInfo info;

        public FieldAccessor(FieldInfo info)
        {
            this.info = info;
        }

        public void SetValue(object target, object value)
        {
            info.SetValue(target, value);
        }

        public object GetValue(object target)
        {
            return info.GetValue(target);
        }
    }
}
