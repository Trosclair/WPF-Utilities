using System.Diagnostics;

namespace WPFUtilities.Utilities
{
    public class FPSCounter : ObservableObject
    {
        private static long frameRateTime = 0;
        private static int frameRate = 0;
        private static int frameCount = 0;

        private static Stopwatch globalTimer = new();

        public int FrameRate { get => frameRate; set { frameRate = value; OnPropertyChanged(nameof(FrameRate)); } }

        public FPSCounter() { globalTimer.Start(); }

        /// <summary>
        /// Add this to the main processing loop.
        /// </summary>
        public void UpdateFPS()
        {
            if (globalTimer.ElapsedMilliseconds > frameRateTime + 1000)
            {
                FrameRate = frameCount;
                frameCount = 0;
                frameRateTime = globalTimer.ElapsedMilliseconds;
            }
            frameCount++;
        }
    }
}
