using System;

public static class MyExtensions
{
    public static Action Create(Action a) => a;
}