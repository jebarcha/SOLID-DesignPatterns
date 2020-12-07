using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.NullOject.Demo2
{
    public interface IMobile
    {
        void TurnOn();
    }

    public class SamsungGalaxy : IMobile
    {
        public void TurnOn()
        {
        }
    }

    public class Iphone : IMobile
    {
        public void TurnOn()
        {
        }
    }

    public class NullMobile : IMobile
    {
        private static NullMobile _instance = new NullMobile();
        private NullMobile()
        { }

        public static NullMobile Instance => _instance;

        public void TurnOn()
        { }
    }

    public class MobileRepository
    {
        public IMobile GetMobileByName(string mobileName)
        {
            IMobile mobile = NullMobile.Instance;
            switch (mobileName)
            {
                case "samsung":
                    mobile = new SamsungGalaxy();
                    break;

                case "apple":
                    mobile = new Iphone();
                    break;
            }
            return mobile;
        }
    }


}
