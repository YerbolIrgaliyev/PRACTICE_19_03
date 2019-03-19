using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPractice
{
    public static class FisrtExcesise
    {
        public static string Run(string data, int pointA, int lenght)
        {
            Type type = Type.GetType("System.String");
            Type[] arguments = new Type[] { typeof(int), typeof(int) };
            MethodInfo methodInfo = type.GetMethod("Substring", arguments);
            string resultaion = data;
            object[] objects = new object[] { pointA, lenght};
            object objResult = methodInfo.Invoke(data, objects);
            
            return objResult as string;

        }
    }
}
