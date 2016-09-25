using System;

/**
 * StateMachine defines the overall wrapper around the individual states and
 * their transitions.
 */
namespace SharpStatey {
    class StateMachine : IStateMachine {
        // We only need the starting point because of recursion...
        private IState startingState;

        /**
         * Create a new State Machine given the starting state. The
         * rest of the machine is defined recusively through traversing
         * the transitions of the states.
         */
        public StateMachine(IState start) {
            this.startingState = start;
        }

        /**
         * Start the parsing of ALL the things!
         */
        public Acceptance Parse(string str) {
            Console.WriteLine("Starting string = " + str);
            return this.startingState.Parse(str);
        }
    }
}
