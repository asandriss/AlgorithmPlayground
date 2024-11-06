using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.DataStructures
{
    public class MyHashTable<TKey, TValue>(int hashSize = 100)
        where TValue : class
    {
        private readonly LinkedList<MyDataRecord>[] _data = new LinkedList<MyDataRecord>[hashSize];
        private int _length = 0;

        public void Add(TKey key, TValue value)
        {
            var indexLocation = GetIndexForKey(key);

            _data[indexLocation] ??= new();

            if (SearchLinkedList(_data[indexLocation], key) is not null)
                throw new ArgumentException("Key already exists in the table");

            _data[indexLocation].Add(new MyDataRecord(key, value));
            _length++;
        }

        public TValue Get(TKey key)
        {
            var indexLocation = GetIndexForKey(key);

            var found = SearchLinkedList(_data[indexLocation], key);
            if (found is null) throw new KeyNotFoundException();

            return found;
        }

        public TValue this[TKey key]
        {
            get => Get(key);
            set => Add(key, value);
        }

        public int Length => _length;

        private int GetIndexForKey(TKey key)
        {
            return Math.Abs(key.GetHashCode() % hashSize);
        }

        private static TValue SearchLinkedList(LinkedList<MyDataRecord> list, TKey keyToFind)
        {
            if (list?.Head == null) return null;

            var record = list.Head;

            while (record != null)
            {
                if (record.Data.Key.Equals(keyToFind)) return record.Data.Value;
                record = record.Next;
            }

            return null;
        }

        private class MyDataRecord(TKey key, TValue value)
        {
            public TKey Key { get; } = key;

            public TValue Value { get; } = value;
        }
    }

}
