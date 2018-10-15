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
    class range
    {
        static void Main(string[] args)
        {
            var range = Observable.Range(10, 15);
            range.Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
        }
    }
}





