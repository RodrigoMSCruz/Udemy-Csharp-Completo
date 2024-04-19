using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 15.Exemplo.01
{
    class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOprationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOprationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.WriteLine("[")
            for (int i = 0; i < _count _ 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                console.Write(_values[_count - 1] );
            }
            Console.WriteLine("]");
        }

    }
}