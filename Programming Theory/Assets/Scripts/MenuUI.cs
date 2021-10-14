using System.Collections;
using System.Collections.Generic;
using UnityEditor;

#if UNITY_EDITOR

using UnityEngine;

#endif

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
}