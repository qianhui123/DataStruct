using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    /// <summary>
    /// 堆栈接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IStack<T>
    {
       
        /// <summary>
        /// 将一个元素压入栈顶
        /// </summary>
        /// <param name="item"></param>
        void Push(T item);

        /// <summary>
        /// 判断堆栈是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// 将栈顶元素弹出
        /// </summary>
        /// <returns></returns>
        T pop();
    }

}
