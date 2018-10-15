using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RxNetExamples
{
   public class TimeSpan
    {
       public static void Main(string[] args)
        {
            ReplaySubjectWindowExample();
        }
        public static void ReplaySubjectWindowExample()
        {
           
            var subject = new ReplaySubject<string>(150);
            subject.OnNext("w");
            Thread.Sleep(100);
            subject.OnNext("x");
            Thread.Sleep(100);
            subject.OnNext("y");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("z");
        }
    }
}
