using System;

namespace SharpStatey {
    interface IState {
        Acceptance Parse(string str);
        void AddTransition(ITransition trans);
    }
}
