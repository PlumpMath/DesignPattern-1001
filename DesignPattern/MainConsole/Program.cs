using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExecuteProxy;
using System.Configuration;

namespace MainConsole
{
    /// <summary>
    /// 作者：Icelove
    /// QQ：775696572
    /// 邮箱：icelove@live.cn
    /// 欢迎与大家交流
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = ConfigurationManager.AppSettings.AllKeys;
            Dictionary<string, string> dicCache = new Dictionary<string, string>();
            for (int i = 0; i < numbers.Length; i++)
            {
                dicCache.Add(numbers[i], ConfigurationManager.AppSettings[numbers[i]].ToString());
            }
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                Console.WriteLine("请选择设计模式：");
                foreach (var item in dicCache)
                {
                    //Console.WriteLine(Convert.ToInt32(item.Key)<0?"":item.Key+"."+item.Value);
                    string id = Convert.ToInt32(item.Key) < 0 ? "" : item.Key + ".";
                    Console.WriteLine(id+ item.Value);
                }
                string selPattern = "";
                while (true)
                {
                    selPattern = Console.ReadLine();
                    if (dicCache.Keys.Contains(selPattern))
                        break;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("没有此选项，请从新选择！");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (true)
                {
                    Console.WriteLine("设计模式：" + dicCache[selPattern]);
                    ExecuteFactory.ExecPorxy(dicCache[selPattern].Substring(0, dicCache[selPattern].IndexOf("-")));
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("是否重新执行此模式：y/n");
                    Console.ForegroundColor = ConsoleColor.White;
                    string b = "";
                    while (true)
                    {
                        b= Console.ReadLine().ToLower();
                        if (b == "y" || b == "n")
                        {
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("输入错误，请从新输入：");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (b=="y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
            }
        }
    }
}
