using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    /// <summary>
    /// 无头结点单链表实现堆栈
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkStack<T>:LinkList<T>,IStack<T>
    {
        // 构造函数
        public LinkStack() {
            Head = null;
        }

        /// <summary>
        /// 在单链表栈顶压入一个元素
        /// 单链表的栈顶是第1个结点，如果最后一个结点是栈顶，那么无法实现弹出元素功能，因为无法访问其前一个结点。
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            Insert(item, 1);
        }

        /// <summary>
        /// 在单链表栈顶弹出一个元素
        /// </summary>
        /// <returns></returns>
        public T pop()
        {
           return Delete(1);
        }



    }
}
