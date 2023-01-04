using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ScrcpyGUI
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public Visibility CropVisibility
        {
            get => CropChecked ? Visibility.Visible : Visibility.Collapsed;
        }

        #region MaxSize
        private bool maxSizeChecked = false;
        public bool MaxSizeChecked
        {
            get => maxSizeChecked;
            set => maxSizeChecked = value;
        }

        private string maxSizeValue = "";
        public string MaxSizeValue
        {
            get => maxSizeValue;
            set => maxSizeValue = value;
        }
        #endregion

        #region MaxBitRate
        private bool maxBitRateChecked = false;
        public bool MaxBitRateChecked
        {
            get => maxBitRateChecked;
            set => maxBitRateChecked = value;
        }

        private string maxBitRateValue = "";
        public string MaxBitRateValue
        {
            get => maxBitRateValue;
            set => maxBitRateValue = value;
        }
        #endregion

        #region MaxFPS
        private bool maxFPSChecked = false;
        public bool MaxFPSChecked
        {
            get => maxFPSChecked;
            set => maxFPSChecked = value;
        }

        private string maxFPSValue = "";
        public string MaxFPSValue
        {
            get => maxFPSValue;
            set => maxFPSValue = value;
        }
        #endregion

        #region PrintFPS
        private bool printFPSChecked = false;
        public bool PrintFPSChecked
        {
            get => printFPSChecked;
            set => printFPSChecked = value;
        }
        #endregion
        
        #region Crop
        private bool cropChecked = false;
        public bool CropChecked
        {
            get => cropChecked;
            set
            {
                cropChecked = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CropVisibility)));
            }
        }

        private string cropWidthValue = "0";
        public string CropWidthValue
        {
            get => cropWidthValue;
            set => cropWidthValue = value;
        }

        private string cropHeightValue = "0";
        public string CropHeightValue
        {
            get => cropHeightValue;
            set => cropHeightValue = value;
        }        
        
        private string cropXValue = "0";
        public string CropXValue
        {
            get => cropXValue;
            set => cropXValue = value;
        }

        private string cropYValue = "0";
        public string CropYValue
        {
            get => cropYValue;
            set => cropYValue = value;
        }
        #endregion

        #region WindowTitle
        private bool windowTitleChecked = false;
        public bool WindowTitleChecked
        {
            get => windowTitleChecked;
            set => windowTitleChecked = value;
        }

        private string windowTitleValue = "";
        public string WindowTitleValue
        {
            get => windowTitleValue;
            set => windowTitleValue = value;
        }
        #endregion

        #region WindowBorderlessChecked
        private bool windowBorderlessChecked = false;
        public bool WindowBorderlessChecked
        {
            get => windowBorderlessChecked;
            set => windowBorderlessChecked = value;
        }
        #endregion

        #region AlwaysOnTopChecked
        private bool alwaysOnTopChecked = false;
        public bool AlwaysOnTopChecked
        {
            get => alwaysOnTopChecked;
            set => alwaysOnTopChecked = value;
        }
        #endregion

        #region FullscreenChecked
        private bool fullscreenChecked = false;
        public bool FullscreenChecked
        {
            get => fullscreenChecked;
            set => fullscreenChecked = value;
        }
        #endregion

        #region NoControlChecked
        private bool noControlChecked = false;
        public bool NoControlChecked
        {
            get => noControlChecked;
            set => noControlChecked = value;
        }
        #endregion

        #region StayAwake
        private bool stayAwakeChecked = false;
        public bool StayAwakeChecked
        {
            get => stayAwakeChecked;
            set => stayAwakeChecked = value;
        }
        #endregion        
        
        #region ShowTouches
        private bool showTouchesChecked = false;

        public bool ShowTouchesChecked
        {
            get => showTouchesChecked;
            set => showTouchesChecked = value;
        }
        #endregion

        public event PropertyChangedEventHandler? PropertyChanged;


        public void Launch()
        {
            string arguments = "scrcpy ";

            arguments += Commands.AddArgumentIfChecked(MaxSizeChecked, Commands.MAX_SIZE, MaxSizeValue);
            arguments += Commands.AddArgumentIfChecked(MaxBitRateChecked, Commands.BIT_RATE, MaxBitRateValue);
            arguments += Commands.AddArgumentIfChecked(MaxFPSChecked, Commands.MAX_FPS, MaxFPSValue);
            arguments += Commands.AddArgumentIfChecked(PrintFPSChecked, Commands.PRINT_FPS);
            arguments += Commands.AddArgumentIfChecked(CropChecked, Commands.CROP, $"{CropWidthValue}:{CropHeightValue}:{CropXValue}:{CropYValue}");
            arguments += Commands.AddArgumentIfChecked(WindowTitleChecked, Commands.WINDOW_TITLE, WindowTitleValue);
            arguments += Commands.AddArgumentIfChecked(WindowBorderlessChecked, Commands.WINDOW_BORDERLESS);
            arguments += Commands.AddArgumentIfChecked(AlwaysOnTopChecked, Commands.ALWAYS_ON_TOP);
            arguments += Commands.AddArgumentIfChecked(FullscreenChecked, Commands.FULLSCREEN);
            arguments += Commands.AddArgumentIfChecked(NoControlChecked, Commands.NO_CONTROL);
            arguments += Commands.AddArgumentIfChecked(StayAwakeChecked, Commands.STAY_AWAKE);
            arguments += Commands.AddArgumentIfChecked(ShowTouchesChecked, Commands.SHOW_TOUCHES);

            Console.WriteLine(arguments);

            try
            {
                Process process = new Process
                {
                    StartInfo =
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        FileName = "cmd.exe",
                        Arguments = "/C" + arguments,
                    }
                };
                process.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("La commande scrcpy n'est pas reconnue ! Vérifiez qu'elle se trouve bien dans le PATH de votre Windows !", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
