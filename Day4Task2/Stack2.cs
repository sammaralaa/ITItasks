using System;
using System.Collections.Generic;
using System.Text;

    class Stack2: Object
    {
    private List<object> objlist;

    public Stack2()
    {
        objlist = new List<object>();
    }
    public void Push(object obj) { 
    if(obj!= null)
        {
            objlist.Add(obj);
        }
        else
        {
            throw (new InvalidOperationException("can not store null values"));
        }
    }
    
    public object Pop()
    {
        if (objlist.Count != 0)
        {
            int indexOfLast = objlist.Count - 1;
            object o = objlist[indexOfLast];
            objlist.RemoveAt(indexOfLast);
            return o;
        }
        else
        { 
            throw new Exception("the stack is empty");
        }
    }

    public void Clear()
    {
        if(objlist.Count != 0)
        {
            objlist.Clear();
        }
        else
        {
            throw (new Exception("the stack is empty"));

        }
    }

    }

