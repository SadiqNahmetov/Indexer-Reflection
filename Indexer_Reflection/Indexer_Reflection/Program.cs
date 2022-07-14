using CustomAddedMethod.Models;
using System;
using System.Collections.Generic;

namespace CustomAddedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLIst<string> teacherList = new MyLIst<string>();

            teacherList.Add("Cavid");
            teacherList.Add("Sadiq");
            teacherList.Add("Esqin");
            teacherList.Add("Ramil");


            teacherList.Clear("Esqin");

            //teacherList.Find("Ramil");



        }
    }

}