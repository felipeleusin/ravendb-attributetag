using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Raven.AttributeTags.Tests
{
    public class RavenTagHelpersTests
    {
        [Fact]
        public void CanCacheAssembly()
        {
            RavenTagHelpers.CacheAssembly(Assembly.GetExecutingAssembly());

            Assert.Equal(RavenTagHelpers.TypeTagsCache.Count(), 1);
        }

        [Fact]
        public void GetsTagNameFromAttribute()
        {
            var tagName = RavenTagHelpers.GetTag(typeof (TaggedUser));

            Assert.Equal("UserTag",tagName);
        }

        [Fact]
        public void ReturnsNullWhenNoTagAvaiable()
        {
            var tagName = RavenTagHelpers.GetTag(typeof(User));

            Assert.Null(tagName);
        }
    }
}
