using System;
using System.Collections.Generic;

namespace SharpStatey {
    class State : IState {
        private List<ITransition> transitions = new List<ITransition>();

        public State() {;}

        public void AddTransition(ITransition trans) {
            transitions.Add(trans);
        }

        public Acceptance Parse(string str) {
            Console.WriteLine("    State->Parse: str = " + str);
            foreach (var trans in transitions) {
                if (str == "") {
                    return Acceptance.FAILURE;
                }
                var match = trans.Match(str[0].ToString(), str.Substring(1));

                // If the match is successful, we don't want to try the rest
                // of the transitions, so we can short circuit the return here.
                if (match == Acceptance.SUCCESS) {
                    return match;
                }
            }
            return Acceptance.FAILURE;
        }
    }
}
