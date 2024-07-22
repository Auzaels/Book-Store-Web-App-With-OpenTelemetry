using System.Diagnostics.Metrics;


public static class DiagnosticsConfig
{
    //Resource name for Aspire Dashboard
    public const string ServiceName = "BasicOpenTelemetry.API";

    public static Meter Meter = new(ServiceName);

    //Metric to track the number of students
    public static Counter<int> StudentCounter = Meter.CreateCounter<int>("students.count");

}