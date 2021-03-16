# Action and Func
#### Simple Console Application that shows the use of Action and Func

An **action** is a predefined delegate that doesn't receive neither return any value

```c#
public delegate void Action();
```

Base on StopWatch form System.Diagnostics, we build example to use an Action and Func

We code a normal and a generic function that receive a delegate to do a benchmark of that delegate