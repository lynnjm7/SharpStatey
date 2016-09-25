using System;
using System.Collections.Generic;

/**
 * Define a state that we can transition to.
 */
namespace SharpStatey {
    class State : IState {
        // Keep track of all the different connections/transitions that
        // a state can have...
        private List<ITransition> transitions = new List<ITransition>();

        public State() {;}

        /**
         * Add a transition to our list of transitions.
         */
        public void AddTransition(ITransition trans) {
            transitions.Add(trans);
        }

        /**
         * Traverse our list of tranisitions and attempt to parse the string.
         * If we are unable to parse the string and go to another node, then
         * return failure.
         */
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
