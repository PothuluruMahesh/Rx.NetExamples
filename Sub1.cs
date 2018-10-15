using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;

namespace RxNetExamples
{
    class Sub1
    {
        static void Main(string[] args)
        {
            var subject = new Subject<string>();
            WriteSequenceToConsole(subject);
            subject.OnNext("a");
            subject.OnNext("b");
            subject.OnNext("c");
        }
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {

            sequence.Subscribe(value => Console.WriteLine(value));

        }
    }
}
