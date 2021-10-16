using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Start is called before the first frame update\
    public static MainManager Instance { get; private set; } = null;

    private string characterName;

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