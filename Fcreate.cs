using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RxNetExamples
{
    class Fcreate
    {
        private IObservable<string> BlockingMethod()
        {
            var subject = new ReplaySubject<string>();
            subject.OnNext("a");
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnNext("d");
            subject.OnCompleted();
            Thread.Sleep(1000);
            subject.Subscribe(a => { Console.WriteLine(a); });
            return subject;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("....................From Main Method Start.............");
            Fcreate fc = new Fcreate();
            fc.BlockingMethod();
            Console.WriteLine("....................From Main Method End................");
        }
    }
}





