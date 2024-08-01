using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Assignment3
{
    [DataContract]
    public class Node
    {
        [DataMember] private Node _next;
        [DataMember] private User _value;
        [DataMember] public Node Next { get { return _next; } set { _next = value; } }
        [DataMember] public User Value { get { return _value; } set { this._value = value; } }
        public Node(User value) 
        {
            this._value = value;
        }

    }
}
