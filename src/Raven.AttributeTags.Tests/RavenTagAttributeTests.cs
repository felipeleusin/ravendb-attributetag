using Xunit;

namespace Raven.AttributeTags.Tests
{
    public class RavenTagAttributeTests : TagTestBase
    {
        [Fact]
        public void GeneratesTagWithNameFromAttribute()
        {
            using (var store = NewDocumentStore())
            {
                using (var session = store.OpenSession())
                {
                    var user = new TaggedUser()
                               {
                                   Name = "Test"
                               };

                    session.Store(user);

                    Assert.True(user.Id.StartsWith("UserTag"));
                }
            }
        }

        [Fact]
        public void UsesTheDefaultMethodWhenTagIsntPresent()
        {
            using (var store = NewDocumentStore())
            {
                using (var session = store.OpenSession())
                {
                    var user = new User()
                    {
                        Name = "Test"
                    };

                    session.Store(user);

                    Assert.False(user.Id.StartsWith("UserTag"));
                    Assert.True(user.Id.StartsWith("user"));
                }
            }
        }
    }

}