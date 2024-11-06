using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.DataStructures
{
    public class MyHashTable<TKey, TValue> where TValue : class
    {
        private readonly LinkedList<MyDataRecord>[] _data;
        private readonly int _hashSize;

        public MyHashTable(int hashSize)
        {
            _hashSize = hashSize;
            _data = new LinkedList<MyDataRecord>[hashSize];
        }

        public void Add(TKey key, TValue value)
        {
            var indexLocation = key.GetHashCode() % _hashSize;

            _data[indexLocation] ??= new();

            if (SearchLinkedList(_data[indexLocation], key) is not null)
                throw new ArgumentException("Key already exists in the table");

            _data[indexLocation].Add(new MyDataRecord(key, value));
        }

        public TValue Get(TKey key)
        {
            var indexLocation = key.GetHashCode() % _hashSize;

            var found = SearchLinkedList(_data[indexLocation], key);
            if (found is null) throw new KeyNotFoundException();

            return found;
        }

        private TValue SearchLinkedList(LinkedList<MyDataRecord> list, TKey keyToFind)
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

        public TValue this[TKey key]
        {
            get => Get(key);
            set => Add(key, value);
        }

        public int Length => _data.Length;

        private class MyDataRecord(TKey key, TValue value)
        {
            public TKey Key { get; } = key;

            public TValue Value { get; } = value;
        }
    }

}
