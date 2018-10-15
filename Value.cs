using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace RxNetExamples
{
    class Value
    {
        static void Main(string[] args)
        {
            var singleValue = Observable.Return<string>("Value");
            var subject = new ReplaySubject<string>();
            subject.OnNext("Value");
            subject.OnNext("Value1");
            subject.OnNext("Value2");
            subject.OnCompleted();
            singleValue.Subscribe(a =>
            {
                Console.WriteLine(a);
            });
        }
    }
}
