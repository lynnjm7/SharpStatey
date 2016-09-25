using System;
using SharpStatey;

class Statey {
    public static StateMachine InitMachine() {
        var b = new State();
        b.AddTransition(new Transition("b", null));

        var o = new State();
        o.AddTransition(new Transition("o", b));

        var start = new State();
        start.AddTransition(new Transition("b", o));

        return new StateMachine(start);
    }

    public static void Main(string[] args) {
        var sm = InitMachine();
        var pass0 = sm.Parse("bob");
        Console.WriteLine("Pass0 = " + pass0);
        Console.WriteLine();

        var fail0 = sm.Parse("ob");
        Console.WriteLine("Fail0 = " + fail0);
        Console.WriteLine();

        var fail1 = sm.Parse("bo");
        Console.WriteLine("Fail1 = " + fail1);
        Console.WriteLine();

        var fail2 = sm.Parse("bobo");
        Console.WriteLine("Fail2 = " + fail2);
        Console.WriteLine();

        var fail3 = sm.Parse("yo mama");
        Console.WriteLine("Fail3 = " + fail3);
        Console.WriteLine();
    }
}
