using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Node<T>
    {
        private Node<T> _next;
        private T _value;
        public Node<T> Next { get { return _next; } set { _next = value; } }
        public T Value { get { return _value; } set { this._value = value; } }
        public Node(T value) 
        {
            this._value = value;
            _next = null;
        }

    }
}
