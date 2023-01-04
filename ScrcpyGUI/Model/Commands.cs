using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrcpyGUI
{
    public class Commands
    {
        public static readonly string MAX_SIZE = "--max-size";
        public static readonly string BIT_RATE = "--bit-rate";
        public static readonly string MAX_FPS = "--max-fps";
        public static readonly string PRINT_FPS = "--print-fps";
        public static readonly string CROP = "--crop";
        public static readonly string LOCK_VIDEO_ORIENTATION_CURRENT = "--lock-video-orientation";
        public static readonly string LOCK_VIDEO_ORIENTATION_NATURAL = "--lock-video-orientation=0";
        public static readonly string LOCK_VIDEO_ORIENTATION_LEFT_90 = "--lock-video-orientation=1";
        public static readonly string LOCK_VIDEO_ORIENTATION_180 = "--lock-video-orientation=2";
        public static readonly string LOCK_VIDEO_ORIENTATION_RIGHT_90 = "--lock-video-orientation=3";
        public static readonly string ENCODER = "--encoder";
        public static readonly string RECORD = "--record";
        public static readonly string DISPLAY_BUFFER = "--display_buffer";
        public static readonly string TCP_IP = "--tcpip";
        public static readonly string WINDOW_TITLE = "--window-title";
        public static readonly string WINDOW_BORDERLESS = "--window-borderless";
        public static readonly string ALWAYS_ON_TOP = "--always-on-top";
        public static readonly string FULLSCREEN = "--fullscreen";
        public static readonly string ROTATION = "--rotation";
        public static readonly string NO_CONTROL = "--no-control";
        public static readonly string STAY_AWAKE = "--stay-awake";
        public static readonly string TURN_SCREEN_OFF = "--turn-screen-off";
        public static readonly string POWER_OF_ON_CLOSE = "--power-off-on-close";
        public static readonly string SHOW_TOUCHES = "--show-touches";
        public static readonly string DISABLE_SCREENSAVER = "--disable-screensaver";

        public static string AddArgumentIfChecked(bool isChecked, string command, string arg = "")
        {
            if (isChecked)
            {
                return arg == "" ? $"{command} " : $"{command} {arg} ";
            }
            return "";
        }
    }
}
