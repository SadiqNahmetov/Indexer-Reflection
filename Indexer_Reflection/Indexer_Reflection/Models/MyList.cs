using System;
using System.Collections.Generic;
using System.Text;

namespace CustomAddedMethod.Models
{
    public class MyLIst<T>
    {
        public string[] arr;

        public MyLIst()
        {
            arr = new string[0];
        }

        public void Add(string names)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = names;
        }

        public void Clear(string names)
        {
            foreach (var item in arr)
            {
                if (item != names)
                {
                    Console.WriteLine(item);
                }

            }
        }


        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}

