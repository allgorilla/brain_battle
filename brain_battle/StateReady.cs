using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brain_battle
{
    public class StateReady : IState
    {
        public StateReady() 
        {
            /* Do Nothing */
        }
        public IState ClickStartEvent() 
        {
            return new State1stHand();
        }
        public IState ClickBoardEvent() 
        {
            return this;
        }
        public IState ClickHandEvent() 
        {
            return this;
        }

    }
}
