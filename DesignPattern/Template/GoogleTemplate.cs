using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    internal abstract class GoogleTemplate
    {
        /// <summary>
        /// 执行
        /// </summary>
        internal void Google() 
        {
            OpenBrowser();
            Type();
            Jump();
            Operation();
            CloesBrowser();
        }
        private void OpenBrowser() 
        {
            Console.WriteLine("打开浏览器");
        }
        private void CloesBrowser() 
        {
            Console.WriteLine("关闭浏览器");
        }
        private void Type() 
        {
            Console.WriteLine("输入https://www.google.com.hk/");
        }
        private void Jump()
        {
            Console.WriteLine("跳转到谷歌首页");
        }
        protected abstract void Operation();
    }
}
