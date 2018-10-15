using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNetExamples
{
    class Fthrow
    {
        static void Main(string[] args)
        {
            var throws = Observable.Throw<string>(new Exception());
            var subject = new ReplaySubject<string>();
            subject.OnError(new Exception());

            throws.Subscribe(a =>
            {
                Console.WriteLine(subject);
            });
        }
    }
}
