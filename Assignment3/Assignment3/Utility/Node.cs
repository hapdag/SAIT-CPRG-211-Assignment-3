using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Node
    {
        private Node _next;
        private User _value;
        public Node Next { get { return _next; } set { _next = value; } }
        public User Value { get { return _value; } set { this._value = value; } }
        public Node(User value) 
        {
            this._value = value;
        }

    }
}
