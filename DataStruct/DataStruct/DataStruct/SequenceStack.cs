using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    /// <summary>
    /// 顺序表实现堆栈
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SequenceStack<T>:SequenceList<T>,ISeqStack<T>
    {
        // 构造函数
        public SequenceStack() { }

        public SequenceStack(int size)
        {
            data = new T[size];
            Maxsize = size;
            Last = -1;
        }

        /// <summary>
        /// 在顺序表栈顶压入一个元素
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            Append(item);
        }

        /// <summary>
        /// 在顺序表栈顶弹出一个元素
        /// </summary>
        /// <returns></returns>
        public T pop()
        {
            return Delete(Last);
        }
           
    }
}
