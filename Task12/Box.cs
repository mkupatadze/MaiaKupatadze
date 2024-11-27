using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    public class Box<T>
    {
        private T value;

        public void SetValue(T newValue)
        {
            value = newValue;
        }

        public T GetValue()
        {
            return value;
        }
    }

    public static class Utility
    {
        public static int GetListCount<T>(this List<T> list)
        {
            return list.Count;
        }

    }







}
