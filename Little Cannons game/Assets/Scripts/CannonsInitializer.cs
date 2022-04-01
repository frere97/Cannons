using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonsInitializer : MonoBehaviour
{
    public List<GameObject> cannons;
    void Start()
    {
        for(int i = 0; i < cannons.Count; i++)
        {
            if(i <= ModifiersValues.ExtraCannonsModifierValue)
            {
                cannons[i].SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
