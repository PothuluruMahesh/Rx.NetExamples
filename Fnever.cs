using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNetExamples
{
    class Fnever
    {
        static void Main(string[] args)
        {
            var never = Observable.Never<string>();
            
            var subject = new Subject<string>();
            subject.OnNext("From Never");
            subject.OnCompleted();
            never.Subscribe(a =>
            {
                Console.WriteLine("It return infinite without any Notification");
            });
        }
    }
}
