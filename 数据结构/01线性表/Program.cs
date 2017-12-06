using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01线性表
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.使用BCL中的List线性表
            List<string> stList = new List<string>();
            stList.Add("aaa");
            stList.Add("123");
            stList.Add("12315");
            Console.WriteLine(stList[0]);

            stList.Remove("123");
            Console.WriteLine(stList.Count);
            stList.Clear();
            Console.WriteLine(stList.Count);
            Console.Read();
        }

        public interface IListDS<T>
        {
            int GetLength();                //求长度
            void Clear();                   //清空操作

            bool IsEmpty();                 //判断线性表是否为空

            void Append(T item);            //附加操作

            void Insert(T item, int i);     // 插入操作

            T Delete(int i);                //删除操作

            T GetElem(int i);               // 取表元

            T this[int index] { get; }      //定义一个索引器获取元素

            int Locate(T value);            //按值查找
        }
    }
}
