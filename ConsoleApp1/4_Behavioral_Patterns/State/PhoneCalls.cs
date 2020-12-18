using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.State
{
    public static class PhoneCalls
    {
        public static Dictionary<CallState, List<(CallTrigger, CallState)>> Rules =
            new Dictionary<CallState, List<(CallTrigger, CallState)>>
            { 
                [CallState.Colagado] = new List<(CallTrigger, CallState)> 
                { 
                    (CallTrigger.Descolgar, CallState.Descolgado)
                },
                [CallState.Descolgado] = new List<(CallTrigger, CallState)>
                {
                    (CallTrigger.MarcarLlamada, CallState.Llamando)
                },
                [CallState.Llamando] = new List<(CallTrigger, CallState)>
                {
                    (CallTrigger.Colgar, CallState.Colagado),
                    (CallTrigger.Conectado, CallState.Conectado)
                },
                [CallState.Conectado] = new List<(CallTrigger, CallState)>
                {
                    (CallTrigger.Colgar, CallState.Colagado),
                    (CallTrigger.DejarEnEspera, CallState.EnEspera),
                    (CallTrigger.DejarMensaje, CallState.Colagado)
                },
                [CallState.EnEspera] = new List<(CallTrigger, CallState)>
                {
                    (CallTrigger.QuitarModoEspera, CallState.Conectado)
                }
            };


    }
}
