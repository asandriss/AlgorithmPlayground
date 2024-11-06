using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.DataStructures
{
    public class MyHashTable(int hashSize)
    {
        private readonly LinkedList<MyDataRecord>[] _data = new LinkedList<MyDataRecord>[hashSize];

        public void Add(int key, string value)
        {
            var indexLocation = key % hashSize;

            _data[indexLocation] ??= new LinkedList<MyDataRecord>();

            if (SearchLinkedList(_data[indexLocation], key) is not null)
                throw new ArgumentException("Key already exists in the table");

            _data[indexLocation].Add(new MyDataRecord(key, value));
        }

        public string Get(int key)
        {
            var indexLocation = key % hashSize;

            var found = SearchLinkedList(_data[indexLocation], key);
            if (found is null) throw new KeyNotFoundException();

            return found;
        }

        private string SearchLinkedList(LinkedList<MyDataRecord> list, int keyToFind)
        {
            if (list?.Head == null) return null;

            var record = list.Head;

            while (record != null)
            {
                if (record.Data.Key == keyToFind) return record.Data.Value;
                record = record.Next;
            }

            return null;
        }

        public string this[int key]
        {
            get => Get(key);
            set => Add(key, value);
        }

        public int Length => _data.Length;

        internal class MyDataRecord(int key, string value)
        {
            public int Key { get; } = key;

            public string Value { get; } = value;
        }
    }

}
