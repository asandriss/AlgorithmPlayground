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
        private readonly int _hashSize = hashSize;
        private readonly MyDataRecord[] _data = new MyDataRecord[hashSize];

        public void Add(int key, string value)
        {
            _data[key] = new MyDataRecord(key, value);
        }

        public string Get(int key)
        {
            return _data[key].Value;
        }

        public string this[int key]
        {
            get
            {
                if (_data[key] is not null)
                {
                    return _data[key].Value;
                }

                throw new KeyNotFoundException();
            }
            set
            {
                if (_data[key] is not null)
                    throw new ArgumentException("Cannot add duplicate keys");

                _data[key] = new MyDataRecord(key, value);
            }
        }

        public int Length => _data.Length;

        internal class MyDataRecord(int key, string value)
        {
            public int Key { get; } = key;

            public string Value { get; } = value;
        }
    }

}
