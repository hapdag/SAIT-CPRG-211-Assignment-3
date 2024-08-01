﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    [DataContract]
    public class SLL : ILinkedListADT
    {
        [DataMember] private Node _head;
        [DataMember] private int _nodeCount;

        public SLL() 
        {
            _head = null;
            _nodeCount = 0;
        }
        public void Add(User value, int index)
        {
            if (!IsEmpty())
            {
                Node curNode = _head, newNode = new Node(value);
                for(int i  = 0; i < (index - 1); i++)
                {
                    curNode = curNode.Next;
                }
                newNode.Next = curNode.Next;
                curNode.Next = newNode;
                _nodeCount++;
            }
            else
            {
                throw new InvalidOperationException();
            }
            throw new NotImplementedException();
        }

        public void AddFirst(User value)
        {
            Node newNode = new Node(value);
            if (value == null)
            {
                _head = newNode;
                _head.Next = null;
            }
            else
            {
                newNode.Next = _head;
                _head = newNode;
            }
            _nodeCount++;
        }

        public void AddLast(User value)
        {
            if (_head == null)
            {
                AddFirst(value);
            }
            else
            {
                Node lastNode = _head, newNode =  new Node(value);
                for (int i  = 0; i < _nodeCount-1; i++)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = newNode;
                _nodeCount++;
            }
        }

        public void Clear()
        {
            _head = null;
            _nodeCount = 0;
        }

        public bool Contains(User value)
        {
            Node curNode = _head;
            for(int i = 0; i < _nodeCount; i++)
            {
                if (curNode.Value.Equals(value))
                {
                    return true;
                }
                curNode = curNode.Next;
            }
            return false;
        }

        public int Count()
        {
            return _nodeCount;
        }

        public User GetValue(int index)
        {
            if (!IsEmpty())
            {
                if(index< _nodeCount)
                {
                    Node curNode = _head;
                    for(int i  = 0; i < index; i++)
                    {
                        curNode = curNode.Next;
                    }
                    return curNode.Value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public int IndexOf(User value)
        {
            if (!IsEmpty())
            {
                Node curNode = _head;
                int index = -1;
                for(int i = 0; i < _nodeCount; i++)
                {
                    curNode = curNode.Next;
                    if (curNode.Value.Equals(value))
                    {
                        index = i;
                        return index;
                    }
                }
                return index;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public bool IsEmpty()
        {
            if (_head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Remove(int index)
        {
            if (!IsEmpty())
            {
                if (index< _nodeCount)
                {
                    Node curNode = _head;
                    for (int i = 0; i < index-1; i++)
                    {
                        curNode = curNode.Next;
                    }
                    curNode.Next = curNode.Next.Next;
                    _nodeCount--;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                throw new InvalidOperationException();
            }

        }

        public void RemoveFirst()
        {
            if( !IsEmpty())
            {
                _head = _head.Next;
                _nodeCount--;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void RemoveLast()
        {
            if(!IsEmpty())
            {
                Node secondLastNode = _head;
                for (int i = 0; i < (_nodeCount - 2); i++)
                {
                    secondLastNode = secondLastNode.Next;
                }
                secondLastNode.Next = null;
                _nodeCount--;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Replace(User value, int index)
        {
            if (!IsEmpty())
            {
                if (index < _nodeCount)
                {
                    Node curNode = _head, newNode = new Node(value);
                    for (int i = 0; i < index - 1; i++)
                    {
                        curNode = curNode.Next;
                    }
                    newNode.Next = curNode.Next.Next;
                    curNode.Next = newNode;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
