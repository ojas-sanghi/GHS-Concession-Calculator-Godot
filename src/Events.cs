using System;
using Godot;

public class Events : Node
{
    public static event Action costChanged;

    ///////////////////////////////////

    public static void publishCostChanged() => costChanged?.Invoke();
}