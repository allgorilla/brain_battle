using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brain_battle
{
    public class State1stBoard:IState
    {
        public State1stBoard()
        {
            /* Do Nothing */
        }
        public IState ClickStartEvent()
        {
            return new State1stHand();
        }
        public IState ClickBoardEvent()
        {
            return new State2ndHand();
        }
        public IState ClickHandEvent()
        {
            return this;
        }
    }
}
