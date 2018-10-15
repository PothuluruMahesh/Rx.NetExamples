﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNetExamples
{
    class Take
    {
        static void Main(string[] args)
        {
            Observable.Range(0, 10)
             .Take(3)
             .Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));

        }
    }
}
