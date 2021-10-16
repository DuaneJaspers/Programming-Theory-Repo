using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    private string objectname = "Sphere";
    protected override string Name { get => objectname; }

    public override void SaySelectedText()
    {
        string dialog = "I am the best shape, I have no sharp edges!";
        SayDialog(dialog);
    }

    // POLYMORPHISM
    protected override void SayMovementText()
    {
        string dialog = "Keep rollin' rollin' rollin'!";
        SayDialog(dialog);
    }
}