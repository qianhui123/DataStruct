using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    /// <summary>
    /// 单链表节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        // 数据
        public T Data { get; set; }

        // 指针域
        public Node<T> Next { get; set; }

        // 构造函数

        //默认构造函数
        public Node()
        {
            Data = default(T);
            Next = null;
        }

        public Node(T value)
        {
            Data = value;
            Next = null;
        }

        public Node(Node<T> next)
        {
            Data = default(T);
            Next = next;
        }

        public Node(T value, Node<T> next)
        {
            Data = value;
            Next = next;
        }


    }

}
