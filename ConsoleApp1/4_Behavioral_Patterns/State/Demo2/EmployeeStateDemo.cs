using Stateless;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.State.Demo2
{
    public enum EmployeeState 
    { 
        Cesante,
        WithJob,
        IsABoss,
        Millionary
    }
    public enum Actions 
    { 
        PasarEntrevista,
        DeleteFromWithouWhereProduction,
        PlayTheLottery,
        GetGoodEvaluation
    }
    public static class EmployeeStateDemo
    {
        public static void StateDemo2()
        {
            bool GanarseLaLoteria = false;
            var stateMachine = new StateMachine<EmployeeState, Actions>(EmployeeState.Cesante);

            stateMachine.Configure(EmployeeState.Cesante)
                .Permit(Actions.PasarEntrevista, EmployeeState.WithJob);
            stateMachine.Configure(EmployeeState.WithJob)
                .Permit(Actions.GetGoodEvaluation, EmployeeState.IsABoss)
                .PermitIf(Actions.PlayTheLottery, EmployeeState.Millionary, () =>
                    GanarseLaLoteria
                 );
            stateMachine.Configure(EmployeeState.WithJob)
                .Permit(Actions.DeleteFromWithouWhereProduction, EmployeeState.Cesante);
        }
    }
}
