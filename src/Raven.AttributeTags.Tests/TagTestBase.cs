using Raven.Client.Document;
using Raven.Tests.Helpers;

namespace Raven.AttributeTags.Tests
{
    public class TagTestBase : RavenTestBase
    {
        protected override void ModifyStore(Raven.Client.Embedded.EmbeddableDocumentStore documentStore)
        {
            documentStore.Conventions.FindTypeTagName = type => RavenTagHelpers.GetTag(type) ?? DocumentConvention.DefaultTypeTagName(type);
        }
    }
}
