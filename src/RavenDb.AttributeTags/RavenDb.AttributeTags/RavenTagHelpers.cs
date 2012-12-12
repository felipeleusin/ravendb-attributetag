using System;
using System.Collections.Concurrent;

namespace RavenDb.AttributeTags
{
    public static class RavenTagHelpers
    {
        public static readonly ConcurrentDictionary<Type, string> TypeTagsCache = new ConcurrentDictionary<Type, string>();

        public static string GetTag(Type t)
        {
            string tagName;
            if ( !TypeTagsCache.TryGetValue(t, out tagName) )
            {
                var tagAttributes = t.GetCustomAttributes(typeof (RavenTagAttribute), true);
                if (tagAttributes.Length == 0)
                {
                    return null;
                }
                tagName = TypeTagsCache.GetOrAdd(t, ((RavenTagAttribute)tagAttributes[0]).Name);
            }

            return tagName;
        }
    }
}