using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observability_With_Opentelemetry
{
    internal class ActivitySourceProvider
    {

        public static ActivitySource Source = new ActivitySource(OpenTelemetryConstants.ActivitySourceName);

    }
}
