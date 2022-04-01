using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsCustomGame : MonoBehaviour
{
    public static bool isCustomGame = false;
     Toggle customGameToggle;
     public GameObject customGamePanel;
    // Start is called before the first frame update
    void Start()
    {
        customGameToggle = GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        isCustomGame = customGameToggle.isOn;

        foreach (Button button in customGamePanel.GetComponentsInChildren<Button>())
        {
            button.interactable = isCustomGame;
        }
    }
}
