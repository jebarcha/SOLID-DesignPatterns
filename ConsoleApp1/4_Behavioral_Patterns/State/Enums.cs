using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.State
{
    public enum CallState
    {
        Colagado,
        Descolgado,
        Llamando,
        Conectado,
        EnEspera
    }
    public enum CallTrigger 
    { 
        Descolgar,
        MarcarLlamada,
        Colgar,
        Conectado,
        DejarMensaje,
        DejarEnEspera,
        QuitarModoEspera
    }

}
