using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    /// <summary>
    /// 不带头结点的单链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkList<T> : IListDS<T>
    {
        // 头引用
        public Node<T> Head { get; set; }

        // 构造函数
        public LinkList()
        {
            Head = null;
        }

        /// <summary>
        /// 求链表长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            Node<T> p = Head;
            int length = 0;
            while (p.Next != null)
            {
                length++;
                p = p.Next;
            }
            return length;

        }

        /// <summary>
        /// 清空链表
        /// </summary>
        public void Clear()
        {
            Head = null;
        }

        /// <summary>
        /// 判断链表是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Head == null;
        }

        /// <summary>
        /// 附加一个元素到链表
        /// </summary>
        /// <param name="item"></param>
        public void Append(T item)
        {
            Node<T> q = new Node<T>(item);
            Node<T> p = Head;
            if (p == null)
            {
                Head = p;
                return;
            }
            while (p.Next != null)
            {
                p = p.Next;
            }
            p.Next = q;
        }

        /// <summary>
        /// 在单链表的第i个结点的位置前插入一个值为item的结点
        /// </summary>
        /// <param name="item"></param>
        /// <param name="i">单链表中的第i个结点位置，从1开始</param>
        public void Insert(T item, int i)
        {
            Node<T> q = new Node<T>(item);
            Node<T> p = Head;

            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("链表为空或插入位置不合法");
                return;
            }
            if (i == 1)
            {
                q.Next = Head;
                Head = q;
                return;
            }
            int len = 1;
            while (len != i - 1 && p.Next != null)
            {
                p = p.Next;
                len++;
            }
            if (len == i - 1)
            {
                q.Next = p.Next;
                p.Next = q;
                return;
            }
            Console.WriteLine($"当前链表不存在第{i}个结点");


        }
        /// <summary>
        /// 在单链表的第i个结点的位置后面插入一个值为<c>item</c>的结点
        /// </summary>
        /// <param name="item"></param>
        /// <param name="i">单链表中第i个结点的位置</param>
        public void InsertPost(T item, int i)
        {
            Node<T> q = new Node<T>(item);
            Node<T> p = Head;
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("链表为空或插入位置不合法");
                return;
            }
            int len = 1;
            while (len != i && p.Next != null)
            {
                p = p.Next;
                len++;
            }
            if (len == i)
            {
                q.Next = p.Next;
                p.Next = q;
                return;
            }
            Console.WriteLine($"当前链表不存在第{i}个结点");

        }
        /// <summary>
        /// 删除单链表中的第i个位置的结点
        /// </summary>
        /// <param name="i"></param>
        /// <returns>返回单链表中的第i个位置的结点数据</returns>
        public T Delete(int i)
        {
            Node<T> tmp = new Node<T>();
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("链表为空或删除位置有误");
                return tmp.Data;
            }
            if (i == 1)
            {
                tmp = Head;
                Head = null;
                return tmp.Data;
            }
            int len = 1;
            Node<T> p = Head;
            while (len != i - 1 && p.Next != null)
            {
                p = p.Next;
                len++;
            }
            if (len == i - 1)
            {
                tmp = p.Next;
                p.Next = p.Next.Next;

            }
            else
            {
                Console.WriteLine($"当前链表不存在第{i}个结点");
            }
            return tmp.Data;

        }
        /// <summary>
        /// 取出单链表中第i个结点
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T GetElem(int i)
        {
            Node<T> tmp = new Node<T>();
            T data = tmp.Data;
            if (IsEmpty())
            {
                Console.WriteLine("链表为空或位置有误");
                return data;
            }
            int len = 1;
            Node<T> p = Head;
            while (len != i && p.Next != null)
            {
                p = p.Next;
                len++;
            }

            if (len == i)
            {
                tmp = p.Next;
                return data;
            }
            // 如果i<1时也会走这块
            else
            {
                Console.WriteLine($"当前链表不存在第{i}个结点");
            }
            return data;

        }
        /// <summary>
        /// 按值查找
        /// </summary>
        /// <param name="value"></param>
        /// <returns>该结点所在位置i，从1开始</returns>
        public int Locate(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("表为空");
                return -1;
            }
            Node<T> p = Head;
            int len = 1;
            while (p.Next != null || !p.Data.Equals(value))
            {
                p = p.Next;
                len++;
            }
            if (p.Data.Equals(value)) return len;
            if (p.Next == null)
            {
                Console.WriteLine("链表中没有该元素");

            }
            return -1;

        }
    }
}
