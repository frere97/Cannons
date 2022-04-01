using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifiersValues : MonoBehaviour
{
    public Modifiers cannonSpeedModifier, ExtraCannonsModifier, PowerUpModifiers;
    public static float cannonSpeedModifierValue = 1, ExtraCannonsModifierValue = 0, PowerUpModifiersValue = 1;
    public static ModifiersValues instance;

    [SerializeField] bool DebugMode;

    void Start(){

        instance = this;
        cannonSpeedModifierValue = cannonSpeedModifier.modifierValue;
        ExtraCannonsModifierValue = ExtraCannonsModifier.modifierValue;
        PowerUpModifiersValue = PowerUpModifiers.modifierValue;
    }

    void FixedUpdate()
    {
        cannonSpeedModifierValue = cannonSpeedModifier.modifierValue;
        ExtraCannonsModifierValue = ExtraCannonsModifier.modifierValue;
        PowerUpModifiersValue = PowerUpModifiers.modifierValue;
        if(DebugMode){
        Debug.Log("Cannon Speed Modifier: " + cannonSpeedModifierValue);
        Debug.Log("Extra Cannons Modifier: " + ExtraCannonsModifierValue);
        Debug.Log("Power Up Modifier: " + PowerUpModifiersValue);
        }
    }
}
