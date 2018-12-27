using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    /// <summary>
    /// 顺序表堆栈接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ISeqStack<T>:IStack<T>
    {
        /// <summary>
        /// 判断顺序表堆栈是否已满
        /// </summary>
        /// <returns></returns>
        bool IsFull();
    }
}
