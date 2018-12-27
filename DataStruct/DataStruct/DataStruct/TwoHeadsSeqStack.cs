using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    /// <summary>
    /// 一个固定长度数组从两边插入元素，实现两个堆栈共用一个数组
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class TwoHeadsSeqStack<T>:SequenceList<T>
    {
        /// <summary>
        /// tag==0 使用从头开始的顺序表作为堆栈
        /// tag==1 使用从尾开始的顺序表作为堆栈
        /// </summary>
        public int tag { get; set; }
        
        //构造函数
        public TwoHeadsSeqStack() { }

        public TwoHeadsSeqStack(int size)
        {
            data = new T[size];
            Maxsize = size;
            Last = -1;
        }
        /// <summary>
        /// 该方法在<code>SequenceList<T></code>和<c>ISeqStack<T></c>有同名同参函数
        /// 但父类函数实现并不满足子类所需要的功能，所以需要用new 关键字覆盖父类中的<c>IsFull</c>方法
        /// </summary>
        /// <returns></returns>
        public new bool IsFull() 
        {

        }

        /// <summary>
        /// 在顺序表中压入一个元素
        /// </summary>
        /// <param name="item"></param>
        /// <param name="tag">表示从顺序表头还是从顺序表尾压入元素</param>
        public void Push(T item,int tag)
        {

        }
    }
}
