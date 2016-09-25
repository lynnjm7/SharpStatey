/**
 * Define the behavior expected of all transitions that can be defined. Originally,
 * the reason for defining interfaces was to allow for multiple definitions
 * of different types of states/machines/transitions/etc, but in the course of
 * implementing this small toy application I ended up not doing that.
 */
namespace SharpStatey {
    interface ITransition {
        Acceptance Match(string ch, string rest);
    }
}
