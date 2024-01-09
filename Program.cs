// See https://aka.ms/new-console-template for more information
using Observability_With_Opentelemetry;
using OpenTelemetry;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

Console.WriteLine("Hello, World!");

var traveProvider = Sdk.CreateTracerProviderBuilder()
                        .ConfigureResource(configure =>
                        {
                            configure.AddService(OpenTelemetryConstants.ServiceName, OpenTelemetryConstants.ServiceVersion)
                                        .AddAttributes(new List<KeyValuePair<string, object>>()
                                        {
                                        new KeyValuePair<string, object>("host.machine", Environment.MachineName),
                                        new KeyValuePair<string, object>("host.os", Environment.OSVersion.VersionString),
                                        new KeyValuePair<string, object>("host.version", "dev")
                                        });

                        }).Build();

traveProvider.