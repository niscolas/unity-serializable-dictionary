using System;
using System.Collections.Generic;
using System.Linq;
using niscolas.UnityUtils.Core.Extensions;
using UnityEngine;

namespace SerializableDictionary
{
    [Serializable]
    public class FakeSerializableDictionary<TKey, TValue, TKeyValuePair>
        where TKeyValuePair : IKeyValuePair<TKey, TValue>, new()
    {
        [SerializeField]
        private List<TKeyValuePair> _content = new List<TKeyValuePair>();

        public bool TryGetValue(TKey key, out TValue value)
        {
            value = _content
                .Where(x => x.Key.Equals(key))
                .Select(x => x.Value)
                .FirstOrDefault();

            return !value.IsUnityNull();
        }
    }
}