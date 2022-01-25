using System;

namespace SerializableDictionary
{
    [Serializable]
    public abstract class OnlyKeySerializeReferenceSerializableDictionary<TKey, TValue> :
        SerializableDictionary<TKey, TValue, OnlyKeySerializeReferenceKeyValuePair<TKey, TValue>> { }
}