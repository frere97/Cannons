using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Modifiers : MonoBehaviour
{
    [Tooltip("the modifier that will be the default option")]
    public int startModifier;
    
    public int currentListValue;
    [SerializeField] List<Modifier> modifier = new List<Modifier>();
    
    public float modifierValue;
    string modifierName = "";
    public Text modifierText;

    void Start()
    {
        AddModifierList(startModifier);
    }

    void Update()
    {
        if(!IsCustomGame.isCustomGame)
        {
            ResetModifiers(startModifier);
        }
    }

    public void AddModifierList(int AmountToAdd){
        if(currentListValue > modifier.Count-1){
           currentListValue = modifier.Count-1;
       }
         if(currentListValue < 0){
              currentListValue = 0;
         }
        currentListValue += AmountToAdd;
       modifierValue = modifier[currentListValue].Value;
       modifierText.text = modifier[currentListValue].Name;
       modifierName = modifier[currentListValue].Name;
       
    }

    void ResetModifiers(int value){
       currentListValue = value;
       modifierValue = modifier[value].Value;
       modifierText.text = modifier[value].Name;
       modifierName = modifier[value].Name;

    }


   
}


 [Serializable]
    public struct Modifier
    {
        public string Name;
       public float Value;
    }
