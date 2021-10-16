using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    // Start is called before the first frame update
    public static MainUI Instance { get; set; } = null;

    [SerializeField]
    private Text dialogText;

    private List<string> Dialogs = new List<string>();

    private void Awake()
    {
        Instance = this;
        UpdateText();
    }

    private void UpdateText()
    {
        string fulltext = "";
        foreach (string item in Dialogs)
        {
            fulltext += $"{item}\n";
        }
        dialogText.text = fulltext;
    }

    public void AddText(string text)
    {
        if (Dialogs.Count == 5)
        {
            Dialogs.RemoveAt(0);
        }
        Dialogs.Add(text);
        UpdateText();
    }
}