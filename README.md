SharpStatey
=================
A small toy project for playing with a Finite State Machine implementation in
C#.

# Purpose
The purpose of the this project was to build something that was large enough
to be non-trivial, but small enough to be implemented very quickly, just for the
sake of toying around with some things in C#.

# Design choices
Some of implementation choices of this project (i.e. using interfaces) were made
because I had originally planned to implement a few different kinds of nodes/states
and transitions/edges, in the end I didn't end up implementing those because
they were not necessary for the task. However, the interfaces are still defined
and that is something that I may approach doing at a later time.

# Compilation
This project was tested and works with Mono on my MacBook Pro. I haven't
tested it on any other platforms, but I assume that it should work because I
used pretty standard C# and didn't do anything outlandish.

# License
The MIT License (MIT)

Copyright (c) 2016 Joshua Lynn

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
