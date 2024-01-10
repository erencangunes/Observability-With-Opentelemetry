﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observability_With_Opentelemetry
{
    internal class ServiceHelper
    {

        internal void Work1()
        {

            using var activity = ActivitySourceProvider.Source.StartActivity();

            Console.WriteLine("Work1 Tamamlandı.");

        }

    }
}
