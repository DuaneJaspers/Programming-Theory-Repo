using System.Collections;
using System.Collections.Generic;
using UnityEditor;

#if UNITY_EDITOR

using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}