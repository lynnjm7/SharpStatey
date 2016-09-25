using System;

namespace SharpStatey {
    interface ITransition {
        Acceptance Match(string ch, string rest);
    }
}
