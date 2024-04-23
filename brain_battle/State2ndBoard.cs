using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brain_battle
{
    public class State2ndBoard : IState
    {
        public State2ndBoard()
        {
            /* Do Nothing */
        }
        public IState ClickStartEvent()
        {
            return new State1stHand();
        }
        public IState ClickBoardEvent()
        {
            return new State1stHand();
        }
        public IState ClickHandEvent()
        {
            return this;
        }
    }
}
