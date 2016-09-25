using System;

namespace SharpStatey {
    class StateMachine : IStateMachine {
        private IState startingState;

        public StateMachine(IState start) {
            this.startingState = start;
        }

        public Acceptance Parse(string str) {
            Console.WriteLine("Starting string = " + str);
            return this.startingState.Parse(str);
        }
    }
}
