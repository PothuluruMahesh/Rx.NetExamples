using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNetExamples
{
    class Buffer
    {
        static void Main(string[] args)
        {
            ReplaySubjectBufferExample();
        }
        public static void ReplaySubjectBufferExample()
        {
            var bufferSize = 2;
            var subject = new ReplaySubject<string>(bufferSize);
            subject.OnNext("a");
            subject.OnNext("b");
            subject.OnNext("c");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("d");
        }
    }
}
