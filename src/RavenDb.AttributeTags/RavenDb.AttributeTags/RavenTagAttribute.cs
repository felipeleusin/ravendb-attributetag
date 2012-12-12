using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavenDb.AttributeTags
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
