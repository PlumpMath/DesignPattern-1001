using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;

namespace ExecuteProxy
{
    /// <summary>
    /// 执行工厂
    /// </summary>
    public class ExecuteFactory
    {
        /// <summary>
        /// 执行设计模式
        /// </summary>
        /// <param name="PatternDllName">设计模式程序集名称</param>
        public static void ExecPorxy(string PatternDllName)
        {
            try
            {
                Type t = CreateExecPorxy(PatternDllName, PatternDllName + "Main").GetType();
                MethodInfo mi = t.GetMethod("Execute");
                object obj = Activator.CreateInstance(t);
                mi.Invoke(obj, null);
            }
            catch (Exception)
            {
                Console.WriteLine("是否继续执行？y/n");
                if (Console.ReadLine().ToLower() == "n")
                    throw new Exception();
            }
        }

        //缓存设计模式执行类
        private static Hashtable htCache;

        /// <summary>
        /// 获取设计模式执行类
        /// </summary>
        /// <param name="PatternDllName">设计模式的程序集名称</param>
        /// <param name="PatternMainClassName">设计模式中执行类名称</param>
        /// <returns>返回设计模式类的执行类</returns>
        private static object CreateExecPorxy(string PatternDllName, string PatternMainClassName)
        {
            object obj = null;

            if (htCache == null)
                htCache = new Hashtable();

            if (htCache.ContainsKey(PatternDllName))
            {
                obj = htCache[PatternDllName] as object;
            }
            else
            {
                try
                {
                    obj = Assembly.Load(PatternDllName).CreateInstance(PatternDllName + "." + PatternMainClassName) as object;
                    if (obj == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("未找到此设计模式，请检查配置文件！");
                        Console.ForegroundColor = ConsoleColor.White;
                        throw new Exception();
                    }
                    htCache.Add(PatternDllName, obj);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("未找到此设计模式，请检查配置文件！");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return obj;
        }

        ///// <summary>
        ///// 获取设计模式执行类(停止使用)
        ///// </summary>
        ///// <param name="PatternName">设计模式的程序集名称</param>
        ///// <param name="PatternNameMain">设计模式中执行类名称</param>
        ///// <returns>返回设计模式类的执行类</returns>
        //private static ExecProxy CreateExecPorxy1(string PatternName, string PatternNameMain)
        //{
        //    ExecProxy ep = null;

        //    if (htCache == null)
        //        htCache = new Hashtable();

        //    if (htCache.ContainsKey(PatternName))
        //    {
        //        ep = htCache[PatternName] as ExecProxy;
        //    }
        //    else
        //    {
        //        try
        //        {
        //            ep = Assembly.Load(PatternName).CreateInstance(PatternName + "." + PatternNameMain) as ExecProxy;
        //            if (ep == null)
        //            {
        //                Console.ForegroundColor = ConsoleColor.Red;
        //                Console.WriteLine("未找到此设计模式，请检查配置文件！");
        //                Console.ForegroundColor = ConsoleColor.White;
        //                throw new Exception();
        //            }
        //            htCache.Add(PatternName, ep);
        //        }
        //        catch (Exception)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("未找到此设计模式，请检查配置文件！");
        //            Console.ForegroundColor = ConsoleColor.White;
        //        }
        //        //加入缓存
        //    }
        //    return ep;
        //}
    }
}
