using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace CommandLineParser
{

    public abstract class CommandLineOptions
    {
        public abstract string GetHelp();

        public void SetValue(string optionLongName, string value)
        {
            if (HasField(optionLongName))
            { 
                SetField(optionLongName, value)
            }
        }

        private bool HasField(string optionLongName) => GetFieldType(optionLongName) != null;

        private bool HasProperty(string optionLongName) => GetPropertyInfo(optionLongName) != null;

        private Type GetFieldType(string optionLongName) => 

        private object ConvertToOriginType(Type type, string value)=> Convert.ChangeType(value, type);

        private void SetProperty(string optionLongName, object value)=>GetPropertyInfo(optionLongName).SetValue(this, value);

        private void SetField(string optionLongName, object value) => GetFieldInfo(optionLongName).SetValue(this, value);

        private FieldInfo GetFieldInfo(string optionLongName) => this.GetType().GetFields()
                                .FirstOrDefault((f) => HasAttribute(f, optionLongName));

        private PropertyInfo GetPropertyInfo(string optionLongName) => this.GetType().GetProperties()
                                .FirstOrDefault((p)=> this.HasAttribute( p, (string)optionLongName));
        private bool HasAttribute(PropertyInfo propertyInfo, string attributeLongName) => propertyInfo.GetCustomAttributes<CommandLineOptionAttribute>()
            .Any((a) => a.LongName == attributeLongName);
        private bool HasAttribute(FieldInfo propertyInfo, string attributeLongName) => propertyInfo.GetCustomAttributes<CommandLineOptionAttribute>()
        .Any((a) => a.LongName == attributeLongName);

    }
}
