using System;

namespace SerializableDictionary
{
    [Serializable]
    public abstract class DefaultSerializableDictionary<TKey, TValue> :
        SerializableDictionary<TKey, TValue, DefaultKeyValuePair<TKey, TValue>> { }
}