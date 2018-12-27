using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    /// <summary>
    /// 线性表接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IListDS<T>
    {
        /// <summary>
        /// 长度
        /// </summary>
        /// <returns></returns>
        int GetLength();

        /// <summary>
        /// 清空
        /// </summary>
        void Clear();

        /// <summary>
        /// 判断线性表是否为空
        /// </summary>
        bool IsEmpty();

        /// <summary>
        /// 附加
        /// </summary>
        /// <param name="item"></param>
        void Append(T item);

        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="item"></param>
        /// <param name="i">线性表的第i个元素</param>
        void Insert(T item, int i);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="i">线性表的第i个元素</param>
        /// <returns>删除的元素</returns>
        T Delete(int i);

        /// <summary>
        /// 取表元
        /// </summary>
        /// <param name="i">线性表的第i个元素</param>
        /// <returns>插入的元素</returns>
        T GetElem(int i);

        /// <summary>
        /// 按值查找
        /// </summary>
        /// <param name="value"></param>
        /// <returns>元素在线性表中的位置，位置从1开始</returns>
        int Locate(T value);
    }
}
