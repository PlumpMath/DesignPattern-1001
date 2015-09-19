using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class CompositeMain
    {
        public void Execute()
        {
            Console.WriteLine("选择组合方式：1.透明方式 2.安全方式");
            string compositeName = Console.ReadLine();
            if (compositeName=="1")
            {
                LucencyComponet boss = new LucencyComposite("BOSS");
                LucencyComposite generalManager1 = new LucencyComposite("General Manager1");
                LucencyComposite generalManager2 = new LucencyComposite("General Manager2");
                generalManager1.Add(new LucencyLeaf("employee1"));
                generalManager1.Add(new LucencyLeaf("employee2"));
                generalManager1.Add(new LucencyLeaf("employee3"));
                generalManager2.Add(new LucencyLeaf("employee4"));
                generalManager2.Add(new LucencyLeaf("employee5"));
                boss.Add(generalManager1);
                boss.Add(generalManager2);
                boss.Display(1);
            }
            else
            {
                SecureComposite boss = new SecureComposite("BOSS");
                SecureComposite generalManager1 = new SecureComposite("General Manager1");
                SecureComposite generalManager2 = new SecureComposite("General Manager2");
                generalManager1.Add(new SecureLeaf("employee1"));
                generalManager1.Add(new SecureLeaf("employee2"));
                generalManager1.Add(new SecureLeaf("employee3"));
                generalManager2.Add(new SecureLeaf("employee4"));
                generalManager2.Add(new SecureLeaf("employee5"));
                boss.Add(generalManager1);
                boss.Add(generalManager2);
                boss.Display(1);
            }
        }
    }
}
