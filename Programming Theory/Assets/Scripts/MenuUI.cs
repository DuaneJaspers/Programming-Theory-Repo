using System.Collections;
using System.Collections.Generic;
using UnityEditor;

#if UNITY_EDITOR

using UnityEngine;

#endif

[DefaultExecutionOrder(1000)]
public class MenuUI : MonoBehaviour
{
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void ChangeName(string newname)
    {
        MainManager.Instance.CharacterName = newname;
    }

    public void StartGame(string shape)
    {
        Debug.Log(shape);
    }
}