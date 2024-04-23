using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brain_battle
{
    public interface IState
    {
        IState ClickStartEvent();
        IState ClickBoardEvent();
        IState ClickHandEvent();
    }
}
