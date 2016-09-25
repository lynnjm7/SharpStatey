using System;

namespace SharpStatey {
     class Transition :  ITransition {
        private string match;
        private IState nextState;

        public Transition(string match, IState next) {
            this.match = match;
            this.nextState = next;
        }

        public Transition() {
            this.match = "";
            this.nextState = null;
        }

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
