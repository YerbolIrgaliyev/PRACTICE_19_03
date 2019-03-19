using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPractice
{
    public static class SecondExcesise
    {
        public static string Run()
        {
            string result = default;
            
            Type type = typeof(List<>);
            foreach (var memberInfo in type.GetMembers())
            {
                if(memberInfo is ConstructorInfo)
                {
                    result = result + memberInfo + '\n';
                }
            }
            return result;
        }
    }
}
