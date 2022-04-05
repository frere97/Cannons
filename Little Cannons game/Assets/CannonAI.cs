using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonAI : MonoBehaviour
{
    public float AILevelValue = 0;
    public GameObject ShootButton;
    public LayerMask layerMask;
    public float ShootTime;
    bool canShoot = true;
    Cannon cannon;
    void Start()
    {
        if(!AIManager.AIOn){return;}
        AILevelValue = AIManager.AILevelValue;
        ShootButton.SetActive(false);
        cannon = GetComponent<Cannon>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!AIManager.AIOn){return;}
        ShootTime  = 4 - AILevelValue;
        //trigger a 2D raycast that if it hit's the disk, it will fire
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up * 100, Mathf.Infinity, layerMask);
        //Draw a 2dRay for debug
        
        Debug.Log(hit.collider.gameObject.name);
        if (hit.collider.gameObject != null)
        {
            
                float ChanceForShooting = Random.Range(1,30000) ;
                Debug.Log("chance" + ChanceForShooting);
                if(ChanceForShooting < AILevelValue * 10000 && canShoot)
                {
                
                cannon.Shoot();
                StartCoroutine(ShootCooldown());

                }
        }
        
    }

    IEnumerator ShootCooldown()
    {
        canShoot = false;
        yield return new WaitForSeconds(ShootTime);
        canShoot = true;
    }
}
