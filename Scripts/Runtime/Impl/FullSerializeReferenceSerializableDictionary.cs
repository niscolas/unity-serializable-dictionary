using System;

namespace SerializableDictionary
{
    [Serializable]
    public abstract class FullSerializeReferenceSerializableDictionary<TKey, TValue> :
        SerializableDictionary<TKey, TValue, FullSerializeReferenceKeyValuePair<TKey, TValue>> { }
}