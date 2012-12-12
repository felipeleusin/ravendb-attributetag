namespace Raven.AttributeTags.Tests
{
    public class User
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }

    [RavenTag("UserTag")]
    public class TaggedUser : User
    { }
}