using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNetExamples
{
    class Where
    {
        static void Main(string[] args)
        {
            var oddNumbers = Observable.Range(0, 50)
            .Where(i => i % 2 == 0)
            .Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("Completed"));
        }
    }
}
