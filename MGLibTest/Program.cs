using MGLib.Osu.Reader.Osb;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGLibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            OsbElementList elements = new OsbElementList(@"Z:\Dollscythe - Flashes (Extended) (Skystar).osb");
            Stopwatch sw = new Stopwatch();
            int count = 0;
            int commandCount = 0;
            sw.Start();
            foreach (var item in elements)
            {
                sw.Stop();
                ++count;
                commandCount += item.Commands.Count();
                sw.Start();
            }
            sw.Stop();
            Console.WriteLine($"总用时：{sw.ElapsedMilliseconds}ms，平均单个物件用时: {sw.ElapsedMilliseconds / count}ms，命令总数：{commandCount}个，平均1000个命令用时：{(float)sw.ElapsedMilliseconds / (float)(commandCount / 1000)}ms");
        }
    }
}
