using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilities
{
    internal class MyProgressbar
    {
        #region Local Variables
        public static string TraceClass;
        #endregion // Local Variables

        #region Constructor

        public MyProgressbar()
        {
            TraceClass = GetType().Name; // Assign the class name to the static variable
        }
        #endregion // Constructor

        #region Local Methods

        /// <summary>
        public async Task UpdateProgressBarUp(ProgressBar progressBar, int duration)
        {
            int progressUpdateInterval = 100; // Update progress every 100ms
            int steps = duration / progressUpdateInterval;
            progressBar.Minimum = 0;
            progressBar.Maximum = steps;
            progressBar.Value = 0;

            for (int i = 0; i < steps; i++)
            {
                await Task.Delay(progressUpdateInterval);
                progressBar.Value = i + 1;
            }

            // Ensure progress bar is set to maximum value at the end
            progressBar.Value = steps;
        }

        public async Task TokenUpdateProgressBarUp(ProgressBar progressBar, int duration, CancellationToken token)
        {
            int progressUpdateInterval = 100; // Update progress every 100ms
            int steps = duration / progressUpdateInterval;
            progressBar.Minimum = 0;
            progressBar.Maximum = steps;
            progressBar.Value = 0;

            try
            {
                for (int i = 0; i < steps; i++)
                {
                    await Task.Delay(progressUpdateInterval, token);
                    token.ThrowIfCancellationRequested();
                    progressBar.Value = i + 1;
                }

                // Ensure progress bar is set to maximum value at the end
                progressBar.Value = steps;
            }
            catch (TaskCanceledException)
            {
                progressBar.Value = 0;
#if DEBUG
                Trace.WriteLine("Delay was cancelled.");
#endif
            }
        }

        public async Task TokenUpdateTsProgressBarUp(ToolStripProgressBar progressBar, int duration, CancellationToken token)
        {
            int progressUpdateInterval = 100; // Update progress every 100ms
            int steps = duration / progressUpdateInterval;
            progressBar.Minimum = 0;
            progressBar.Maximum = steps;
            progressBar.Value = 0;

            try
            {
                for (int i = 0; i < steps; i++)
                {
                    await Task.Delay(progressUpdateInterval, token);
                    token.ThrowIfCancellationRequested();
                    progressBar.Value = i + 1;
                }

                // Ensure progress bar is set to maximum value at the end
                progressBar.Value = steps;
            }
            catch (TaskCanceledException)
            {
                progressBar.Value = 0;
#if DEBUG
                Trace.WriteLine("Delay was cancelled.");
#endif
            }
        }

        /// <summary>
        /// Progressbar Async Displays going DOWN with Delay</summary>
        public async Task UpdateProgressBarDown(ProgressBar progressBar, int duration)
        {
            int progressUpdateInterval = 100; // Update progress every 100ms
            int steps = duration / progressUpdateInterval;
            progressBar.Minimum = 0;
            progressBar.Maximum = steps;
            progressBar.Value = steps;

            for (int i = steps; i > 0; i--)
            {
                await Task.Delay(progressUpdateInterval);
                progressBar.Value = i - 1;
            }

            // Ensure progress bar is set to minimum value at the end
            progressBar.Value = 0;
        }
        #endregion // Local Methods

        public async Task TokenUpdateProgressBarDown(ProgressBar progressBar, int duration, CancellationToken token)
        {
            int progressUpdateInterval = 100; // Update progress every 100ms
            int steps = duration / progressUpdateInterval;
            progressBar.Minimum = 0;
            progressBar.Maximum = steps;
            progressBar.Value = steps;

            try
            {
                for (int i = steps; i > 0; i--)
                {
                    await Task.Delay(progressUpdateInterval);
                    token.ThrowIfCancellationRequested();
                    progressBar.Value = i - 1;
                }

                // Ensure progress bar is set to minimum value at the end
                progressBar.Value = 0;
            }
            catch (TaskCanceledException)
            {
                progressBar.Value = 0;
#if DEBUG
                Trace.WriteLine("Delay was cancelled.");
#endif
            }
        }

        public async Task TokenUpdateTsProgressBarDown(ToolStripProgressBar progressBar, int duration, CancellationToken token)
        {
            int progressUpdateInterval = 100; // Update progress every 100ms
            int steps = duration / progressUpdateInterval;
            progressBar.Minimum = 0;
            progressBar.Maximum = steps;
            progressBar.Value = steps;

            try
            {
                for (int i = steps; i > 0; i--)
                {
                    await Task.Delay(progressUpdateInterval);
                    token.ThrowIfCancellationRequested();
                    progressBar.Value = i - 1;
                }

                // Ensure progress bar is set to minimum value at the end
                progressBar.Value = 0;
            }
            catch (TaskCanceledException)
            {
                progressBar.Value = 0;
#if DEBUG
                Trace.WriteLine("Delay was cancelled.");
#endif
            }
        }
    }
}
