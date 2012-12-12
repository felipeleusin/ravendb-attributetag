# RavenTag Attribute

Attribute that helps definig custom tag names for classes in RavenDB

Inspired from: https://groups.google.com/forum/?fromgroups=#!topic/ravendb/Y9WNSiCV5kg

## Usage

Set in the DocumentStoreConventions like this:

store.Conventions.FindTypeTagName = type => RavenTagHelpers.GetTag(type) ?? DocumentConvention.DefaultTypeTagName(type);

## Caching

You can call in you`re initialization code

RavenTagHelpers.CacheAssembly(assembly);

To cache the tags for all types in an Assembly. If you want to cache a single type just call

RavenTagHelpers.GetTag(type);
