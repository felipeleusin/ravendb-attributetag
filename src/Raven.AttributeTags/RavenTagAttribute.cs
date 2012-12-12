using System;

namespace Raven.AttributeTags
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class RavenTagAttribute : Attribute
    {
        public string Name { get; set; }

        public RavenTagAttribute(string name)
        {
            this.Name = name;
        }
    }
}
