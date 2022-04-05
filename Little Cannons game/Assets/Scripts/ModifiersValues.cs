using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifiersValues : MonoBehaviour
{
    public Modifiers cannonSpeedModifier, ExtraCannonsModifier;
    public static float cannonSpeedModifierValue = 1, ExtraCannonsModifierValue = 0;
    public static ModifiersValues instance;

    [SerializeField] bool DebugMode;

    void Start(){

        instance = this;
        cannonSpeedModifierValue = cannonSpeedModifier.modifierValue;
        ExtraCannonsModifierValue = ExtraCannonsModifier.modifierValue;

    }

    void FixedUpdate()
    {
        cannonSpeedModifierValue = cannonSpeedModifier.modifierValue;
        ExtraCannonsModifierValue = ExtraCannonsModifier.modifierValue;

        if(DebugMode){
        Debug.Log("Cannon Speed Modifier: " + cannonSpeedModifierValue);
        Debug.Log("Extra Cannons Modifier: " + ExtraCannonsModifierValue);
        }
    }
}
