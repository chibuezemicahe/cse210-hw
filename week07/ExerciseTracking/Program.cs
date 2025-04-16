using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create one of each activity type
        activities.Add(new Running(
            DateTime.Parse("2024-02-15"),
            30,
            3.0)); // 3.0 miles

        activities.Add(new Cycling(
            DateTime.Parse("2024-02-15"),
            45,
            15.0)); // 15 mph

        activities.Add(new Swimming(
            DateTime.Parse("2024-02-15"),
            30,
            20)); // 20 laps

        // Display summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
