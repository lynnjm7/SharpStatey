using System;

namespace SharpStatey {
    interface IStateMachine {
        Acceptance Parse(string str);
    }
}
