using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Adapter.Demo2
{
    public class AdapterDemo2
    {
        public interface IEuropeanPlugConnector
        {
            string GiveElectricity();
        }

        public class EuropeanElectricalConnector : IEuropeanPlugConnector
        {
            public string GiveElectricity()
            {
                return "Give Electricity";
            }
        }

        public interface USPlugConnector
        {
            string ProvideElectricity();
        }

        // Implement an adapter called EuropeanToUSAdapter that converts 
        // IEuropeanPlugConnector to USPlugConnector
        public class EuropeanToUSAdapter : USPlugConnector
        {
            private IEuropeanPlugConnector _europeanPlugConnector;

            public EuropeanToUSAdapter(IEuropeanPlugConnector europeanPlugConnector)
            {
                _europeanPlugConnector = europeanPlugConnector;
            }

            public string ProvideElectricity()
            {
                return _europeanPlugConnector.GiveElectricity();
            }
        }


    }
}
