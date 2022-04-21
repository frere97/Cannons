using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIManager : MonoBehaviour
{
    public Modifiers AILevel;
    public Slider AISlider;
    public static float AILevelValue = 0;
    public Toggle AIOnToggle;
    public static bool AIOn = false;

    void Start(){

        AILevelValue = AILevel.modifierValue;
        AIOnToggle.isOn = false;

    }

     void FixedUpdate()
    {
 
            AIOn = AIOnToggle.isOn;
            AISlider.interactable = AIOn;
            AILevelValue = AISlider.value;

    }


}
