using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Stack
    {
        private readonly List<object> _stackList = new List<object>();
       

        public void Push(object obj)
        {
            if (obj == null) throw new InvalidOperationException("Cant add NULL object to the Stack");

            _stackList.Add(obj);
        }

        public object Pop()
        {
            if (_stackList.Count <= 0) throw new InvalidOperationException("The Stack is empty");

            var last = _stackList.Last();
            _stackList.RemoveAt(_stackList.Count - 1);
            return last;
        }

        public void Clear()
        {
            _stackList.Clear();
        }
    }
}