using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_01
{
    public interface IBuffer<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        void Write(T value);
        T Read();
    }
    public class Buffer<T> : Object, IBuffer<T>
    {

        public bool IsEmpty
        {
            get { throw new NotImplementedException(); }
        }

        public void Write(T value)
        {
            throw new NotImplementedException();
        }

        public T Read()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator(); 
        }
        public IEnumerator<T> GetEnumerator()
        {
            var x = new Buffer<T>();
            return (IEnumerator)x; 
        }
    }
    class CircularBuffer<T> : Buffer<T> 
    {
        private T[] _buffer;
        public int _start;
        public int _end;
        public CircularBuffer() //: this(capacity: 10)
        {
            Console.WriteLine("CicularBuffer default Constructor");
        }
        public CircularBuffer(int capaicty)
        {
            _buffer = new T[capaicty + 1];
            _start = 0;
            _end = 0;
            Console.WriteLine("CicularBuffer parameterized Constructor");
        }
        public void Write(T value)
        {
            _buffer[_end] = value;
            _end = (_end + 1) % _buffer.Length;
            if(_end==_start)
            {
                _start = (_start + 1) % _buffer.Length;
            }
        }
        public T Read()
        {
            T result = _buffer[_start];
            _start = (_start + 1) % _buffer.Length;
            return result;
        }
        public int Capacity
        {
            get { return _buffer.Length; }
        }
        public bool IsEmpty
        {
            get { return _end == _start; }
        }
        public bool IsFull
        {
            get { return (_end = 1) % _buffer.Length == _start; }
        }
    }
}
