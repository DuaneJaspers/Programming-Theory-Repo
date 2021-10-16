using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Encapsulation
    public static MainManager Instance { get; private set; } = null;

    private string characterName = "Perry";

    // Encapsulation
    public string CharacterName
    {
        get { return characterName; }
        set { characterName = value; }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = new MainManager();
        DontDestroyOnLoad(gameObject);
    }
}