using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    /// <summary>
    /// 顺序表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SequenceList<T> : IListDS<T>
    {
        // 数组，存储顺序表中的数据元素
        protected T[] data;
        // 索引器
        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        // 顺序表中最后一个元素的位置,从0开始
        public int Last { get; set; }

        // 顺序表的容量属性
        public int Maxsize { get; set; }
        // 构造函数
        public SequenceList() { }
        public SequenceList(int size)
        {
            data = new T[size];
            Maxsize = size;
            Last = -1;
        }
        /// <summary>
        /// 求顺序表的长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return Last + 1;
        }

        /// <summary>
        /// 清空顺序表
        /// </summary>
        public void Clear()
        {
            Last = -1;
        }
        /// <summary>
        /// 判断顺序表是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Last == -1;
        }

        /// <summary>
        /// 判断顺序表是否已满
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return Last + 1 == Maxsize;
        }


        /// <summary>
        /// 附加一个元素到顺序表结尾
        /// </summary>
        /// <param name="item"></param>
        public void Append(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("数组已满，无法添加数据");
                return;
            }
            else
            {
                data[++Last] = item;
            }

        }

        /// <summary>
        /// 插入一个元素到顺序表
        /// </summary>
        /// <param name="item"></param>
        /// <param name="i">线性表中的第i个数据元素,从1开始</param>
        public void Insert(T item, int i)
        {
            if (IsFull())
            {
                Console.WriteLine("数组已满，无法添加数据");
                return;
            }
            if (i < 1 || i > Last + 2)
            {
                Console.WriteLine("插入数组位置不合法");
                return;
            }
            int j;
            for (j = Last; j >= i - 1; j--)
            {
                data[j + 1] = data[j];
            }
            data[i - 1] = item;
            Last++;

        }

        /// <summary>
        /// 删除一个元素
        /// </summary>
        /// <param name="i">线性表中的第i个数据元素,从1开始</param>
        /// <returns></returns>
        public T Delete(int i)
        {
            T tmp = default(T);
            if (IsEmpty())
                Console.WriteLine("顺序表为空");
            else if (i < 1 || i > Last + 1)
            {
                Console.WriteLine("删除位置不合法");

            }
            else
            {
                tmp = data[i - 1];
                int j;
                for (j = i; j <= Last; j++)
                {
                    data[j - 1] = data[j];

                }
                Last--;
            }


            return tmp;
        }

        /// <summary>
        /// 获取顺序表指定位置的元素
        /// </summary>
        /// <param name="i">线性表中的第i个数据元素,从1开始</param>
        /// <returns></returns>
        public T GetElem(int i)
        {
            T tmp = default(T);
            if (IsEmpty())
                Console.WriteLine("顺序表为空");
            else if (i < 1 || i > Last + 1)
            {
                Console.WriteLine("位置不合法");

            }
            else
            {
                tmp = data[i - 1];

            }


            return tmp;

        }

        /// <summary>
        /// 在顺序表中按值查找
        /// </summary>
        /// <param name="value"></param>
        /// <returns>元素在线性表中的值，从1开始</returns>
        public int Locate(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("顺序表为空");

            }

            else
            {
                int index = 0;
                while (!value.Equals(data[index]) && index <= Last)
                {
                    index++;
                }
                if (value.Equals(data[index])) return index + 1;
                if (index > Last)
                {
                    Console.WriteLine("没有找到所要查找的值");

                }

            }
            return -1;

        }


    }
}
