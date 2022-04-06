using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.MODELS
{
    class MyList<T>
    {
        private T[] _arr;
        private int _count;
        public int Capacity { get; set; } = 0;
        public int Count { get => _count; }
        public int Length { get => _arr.Length; }
        public MyList()
        {
            _count = 0;
            _arr = new T[0];
        }
        public void Additem(T input)
        {
            Resizable(_count == _arr.Length);
            _arr[Count] = input;
            _count++;
        }
        private void Resizable(bool b)
        {
            if (b) Array.Resize(ref _arr, (_arr.Length == 0 ? 1 : _arr.Length) * 2);
        }

    }
}
}
