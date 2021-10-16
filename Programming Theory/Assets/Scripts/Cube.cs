using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private string objectname = "Cube";
    protected override string Name { get => objectname; }

    public override void SaySelectedText()
    {
        string dialog = "I'm perfect, all my sides and angles are the same!";
        SayDialog(dialog);
    }

    // POLYMORPHISM
    protected override void SayMovementText()
    {
        string dialog = $"Let's slide together {MainManager.Instance?.CharacterName}!";
        SayDialog(dialog);
    }
}