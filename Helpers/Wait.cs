using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Demo_DotNet.Helpers
{


    public class Wait
    {
        public static void Until(TimeSpan timeSpan, Func<bool> condition)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var outcome = false;
            while (outcome == false && stopwatch.Elapsed < timeSpan)
            {
                try
                {
                    outcome = condition();
                }
                catch (Exception)
                {
                    // Swallow exception
                }

                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }

            if (stopwatch.Elapsed > timeSpan)
            {
                throw new TimeoutException(string.Format("Timed out after {0}m {1}s", timeSpan.Minutes, timeSpan.Seconds));
            }
        }
    }

}