using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Facade.Demo2
{
    public class MusicController
    {
        public static bool IsOn { get; private set; }
        public void TurnOn() => IsOn = true;
        public void TurnOff() => IsOn = false;
    }

    public class RunningController
    {
        public static bool IsOn { get; private set; }
        public void TurnOn() => IsOn = true;
        public void TurnOff() => IsOn = false;
    }


    public class RunningApp
    {
        private MusicController _musicController = new MusicController();
        private RunningController _runningAppController = new RunningController();

        public void GoRunning()
        {
            _musicController.TurnOn();
            _runningAppController.TurnOn();

        }

        public void CompleteRunning()
        {
            _musicController.TurnOff();
            _runningAppController.TurnOff();

        }
    }

}
