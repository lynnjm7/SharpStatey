using System;

/**
 * Transition defines the transition that exists to move from one state
 * to another. The transition edge is what directs the machine into the
 * next state of parsing the input string.
 */
namespace SharpStatey {
     class Transition :  ITransition {
        private string match;
        private IState nextState;

        /**
         * Create a new transition edge given a match and the next state for
         * that match.
         */
        public Transition(string match, IState next) {
            this.match = match;
            this.nextState = next;
        }

        /**
         * Create an end transition.
         */
        public Transition() {
            this.match = "";
            this.nextState = null;
        }

        /**
         * Perform a Match operation given the first char of a string.
         *
         * On match, and if at the end of the machine traversal return success.
         * On match, and with nodes left to traverse, recursively call Match.
         * Otherwise, return failure (i.e. the input string was invalid).
         */
        public Acceptance Match(string ch, string rest) {
            Console.WriteLine("        Transition: ch = " + ch);
            Console.WriteLine("        Transition: rest = " + rest);
            if (nextState == null && rest == "") {
                return Acceptance.SUCCESS;
            } else if (nextState != null && match == ch) {
                return nextState.Parse(rest);
            } else {
                return Acceptance.FAILURE;
            }
        }
    }
}
