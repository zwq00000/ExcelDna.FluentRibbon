﻿namespace ExcelDna.Fluent.Control {
    public interface IElementId {
        IElementId SetId(string name);

        IElementId SetMicrosoftId(string name);

        IElementId SetNamespaceId(string namespaceKey, string name);

        string Value { get; }

        IdType Type { get; }
    }
}