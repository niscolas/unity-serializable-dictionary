using System;

namespace SerializableDictionary
{
    [Serializable]
    public abstract class OnlyValueSerializeReferenceSerializableDictionary<TKey, TValue> :
        SerializableDictionary<TKey, TValue, OnlyValueSerializeReferenceKeyValuePair<TKey, TValue>> { }
}